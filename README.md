# QuizApp

QuizApp is a self-assessment platform for developers preparing for senior-level
technical and architecture interviews. It focuses on scenario-based questions about
C#, Entity Framework Core, RabbitMQ, PostgreSQL, and architecture patterns.

## Core idea

A user selects a topic and receives up to ten random questions balanced across
Middle, Middle+, Senior, and Senior+ levels. Questions that the user has already
answered are excluded. Correctness and explanations remain hidden until an
answer option has been selected and saved.

The interactive session has five stages:

1. Select a topic.
2. Select the most accurate of four technically plausible answers.
3. Review green/red feedback and the detailed explanation.
4. Continue until the batch is complete.
5. Reset personal progress whenever previously answered questions should be
   available again.

The question bank is extensible: topics and the number of questions are not
hard-coded into the home page. The C# set also contains code-reading tasks about
closures, asynchronous execution, concurrency, resource lifetimes, and exception
handling.

Answer choices use compact, comparable-length statements. The full explanation
is deliberately shown only after submission, so its length cannot reveal the
correct option in advance.

## Architecture

The solution follows Clean Architecture and Tactical Domain-Driven Design:

- `Quiz.Domain` — rich domain model, aggregates, entities, business rules, and
  repository contracts.
- `Quiz.Application` — CQRS use cases implemented with MediatR and DTO-based
  results.
- `Quiz.Infrastructure` — Entity Framework Core, SQLite mappings, migrations,
  and repository implementations.
- `Quiz.WebUI` — Blazor Web App in Interactive Server mode and the application
  composition root.

The current UI calls Application use cases directly through `IMediator`. This
remains the runnable MVP while service boundaries are extracted incrementally.

```text
Quiz.WebUI ───────> Quiz.Application ───────> Quiz.Domain
     │                                         ▲
     └───────────> Quiz.Infrastructure ─────────┘
```

## Microservice migration

The first independently deployable boundary is now available under
`Services/Identity`:

- `Quiz.Identity.Application` — account use-case contracts, role names, scopes,
  and resource identifiers.
- `Quiz.Identity.Infrastructure` — ASP.NET Core Identity stores, PostgreSQL
  `IdentityDbContext`, and account operations.
- `Quiz.Identity.Api` — OpenID Connect/OAuth 2.0 server built with OpenIddict,
  login/registration UI, token endpoints, migrations, client/scope seeding, and
  health checks.

The Identity Service owns its PostgreSQL database. It does not reference the
current quiz domain or SQLite database.

```text
Browser / future BFF ── Authorization Code + PKCE ──> Identity Service
Internal service      ── Client Credentials ─────────> Identity Service
                                                         │
                                                         └── PostgreSQL
```

Supported endpoints:

- `/account/register` and `/account/login`
- `/connect/authorize`
- `/connect/token`
- `/connect/userinfo`
- `/connect/logout`
- `/health`

Access tokens are signed JWTs with a 15-minute lifetime. Browser sessions use
Authorization Code + PKCE and can receive refresh tokens. Internal services use
Client Credentials. Development certificates are local-only; production must
provide managed signing and encryption certificates.

## Important business rules

- A user never receives a question they have already answered.
- A quiz batch contains no more than ten unique questions with mixed difficulty.
- Correctness and explanations stay hidden until the selected option is saved.
- A user can submit only one answer per question.
- A unique database index protects this rule during concurrent operations.
- Resetting progress deletes only the current user's answer history and does
  not modify the shared question bank.

## Technology

- .NET 8 and C#
- Blazor Web App with Interactive Server rendering
- MudBlazor
- MediatR and CQRS
- Entity Framework Core 8
- SQLite
- Clean Architecture and Tactical DDD

## Database

The SQLite connection string is:

```text
Data Source=quiz.db
```

The path is resolved against the `Quiz.WebUI` content root. On startup,
`Database.Migrate()` automatically creates `quiz.db` and applies every pending
migration. The database file is intentionally excluded from Git.

## Build and run

```powershell
dotnet restore QuizApp.sln
dotnet build QuizApp.sln
dotnet run --project Quiz.WebUI
```

Open the URL printed by ASP.NET Core and navigate to `/quiz`.

### Run the Identity Service

Start its PostgreSQL container:

```powershell
$env:QUIZ_IDENTITY_DB_PASSWORD = "<choose-a-local-database-password>"
docker compose -f compose.identity.yml up -d
```

Configure the application in the same PowerShell session and run it:

```powershell
$env:ConnectionStrings__IdentityDatabase = "Host=localhost;Port=5434;Database=quiz_identity;Username=quiz_identity;Password=$env:QUIZ_IDENTITY_DB_PASSWORD"
$env:IdentityClients__WebBff__ClientSecret = "<choose-a-long-random-bff-secret>"
$env:IdentityClients__Service__ClientSecret = "<choose-a-long-random-service-secret>"

dotnet run --project Services/Identity/Quiz.Identity.Api
```

Open `https://localhost:7281/account/register`. In Development, the service
automatically applies its migrations and seeds roles, scopes, and OAuth clients.

To verify the machine-to-machine flow:

```powershell
$body = @{
  grant_type    = "client_credentials"
  client_id     = "quiz-service-client"
  client_secret = $env:IdentityClients__Service__ClientSecret
  scope         = "quiz.read"
}

Invoke-RestMethod `
  -Method Post `
  -Uri "https://localhost:7281/connect/token" `
  -ContentType "application/x-www-form-urlencoded" `
  -Body $body
```

Passwords and OAuth client secrets are never stored in tracked configuration.
For local development use environment variables or .NET user secrets. Production
must supply the same keys through a managed secret store:

```text
ConnectionStrings__IdentityDatabase
IdentityClients__WebBff__ClientSecret
IdentityClients__Service__ClientSecret
```

The next migration step is to turn `Quiz.WebUI` into a BFF/OIDC client, replace
the temporary local browser user id with the token `sub` claim, and then extract
the assessment API behind the `quiz-api` resource.

## Troubleshooting

If the build reports `MSB3021` or `MSB3027` and says that `Quiz.WebUI` is using
a DLL file, stop the currently running application before rebuilding:

```powershell
Get-Process Quiz.WebUI -ErrorAction SilentlyContinue | Stop-Process
dotnet build QuizApp.sln
```

In Visual Studio, the equivalent action is **Stop Debugging** before selecting
**Rebuild Solution**.
