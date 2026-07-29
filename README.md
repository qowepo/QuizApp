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
- `Quiz.Identity.Infrastructure` — ASP.NET Core Identity stores, SQLite
  `IdentityDbContext`, and account operations.
- `Quiz.Identity.Api` — OpenID Connect/OAuth 2.0 server built with OpenIddict,
  login/registration UI, token endpoints, migrations, client/scope seeding, and
  health checks.

The Identity Service owns `identity.db`. It does not reference the quiz domain
or the separate `quiz.db` database.

```text
Browser ── secure cookie ──> Quiz.WebUI
                               │
                               ├── OIDC Code + PKCE ──> Identity Service
                               │                          └── identity.db
                               │
                               └── MediatR ───────────> Quiz use cases
                                                          └── quiz.db
```

Supported endpoints:

- `/account/register` and `/account/login`
- `/connect/authorize`
- `/connect/token`
- `/connect/userinfo`
- `/connect/logout`
- `/health`

The `/quiz` route is protected. Browser authentication uses Authorization Code
+ PKCE; WebUI creates an HTTP-only secure cookie and reads the stable user id
from the OIDC `sub` claim. OAuth tokens are not stored in that cookie because
quiz use cases still run in-process through MediatR. When the assessment HTTP API
is extracted, tokens should be kept in a server-side BFF token store.

The local `quiz-web-bff` client is public and protected by PKCE, so no secret is
required for development. Supplying `Authentication__ClientSecret` to WebUI and
`IdentityClients__WebBff__ClientSecret` to Identity makes a fresh deployment use
a confidential client.

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

## Databases

Each executable owns a separate SQLite database:

```text
Quiz.WebUI        → Data Source=quiz.db
Quiz.Identity.Api → Data Source=identity.db
```

Relative paths are resolved against the corresponding application's content
root. Both applications call `Database.Migrate()` on Development startup, so the
files are created automatically. Both database files are excluded from Git.

## Build and run

Trust the local ASP.NET Core development certificate once:

```powershell
dotnet dev-certs https --trust
```

Restore and build the solution:

```powershell
dotnet restore QuizApp.sln
dotnet build QuizApp.sln
```

Run both startup projects in separate terminals. Start Identity first:

```powershell
dotnet run --project Services/Identity/Quiz.Identity.Api --launch-profile https
```

Then start WebUI:

```powershell
dotnet run --project Quiz.WebUI --launch-profile https
```

Open `https://localhost:7087`. Use the header buttons to register or sign in.
Opening `/quiz` while anonymous automatically starts the OIDC login flow.

In Visual Studio, configure both `Quiz.Identity.Api` and `Quiz.WebUI` as startup
projects, with Identity listed first.

No database server, Docker container, database password, or OAuth client secret
is required for this local setup.

The next architectural extraction is an Assessment API behind the `quiz-api`
resource. At that point WebUI becomes a full BFF: it calls the API with a bearer
token while the browser continues to receive only the secure session cookie.

## Troubleshooting

If the build reports `MSB3021` or `MSB3027` and says that `Quiz.WebUI` is using
a DLL file, stop the currently running application before rebuilding:

```powershell
Get-Process Quiz.WebUI -ErrorAction SilentlyContinue | Stop-Process
dotnet build QuizApp.sln
```

In Visual Studio, the equivalent action is **Stop Debugging** before selecting
**Rebuild Solution**.
