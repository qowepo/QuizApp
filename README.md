# QuizApp

QuizApp is a self-assessment platform for developers preparing for senior-level
technical and architecture interviews. It focuses on open-ended questions about
C#, Entity Framework Core, RabbitMQ, PostgreSQL, and architecture patterns.

## Core idea

A user selects a topic and receives up to five random questions. Questions that
the user has already answered are excluded. The reference answer remains hidden
until the user's own answer has been submitted and saved.

The interactive session has four stages:

1. Select a topic.
2. Write and submit an answer.
3. Compare it with the ideal answer.
4. Continue until the batch is complete.

The MVP includes 25 ready-to-use questions: five for each supported topic.

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

The UI calls Application use cases directly through `IMediator`; no HTTP API is
required inside this deployment.

```text
Quiz.WebUI ───────> Quiz.Application ───────> Quiz.Domain
     │                                         ▲
     └───────────> Quiz.Infrastructure ─────────┘
```

## Important business rules

- A user never receives a question they have already answered.
- A quiz batch contains no more than five unique questions.
- The ideal answer stays hidden until the user's answer is saved.
- A user can submit only one answer per question.
- A unique database index protects this rule during concurrent operations.

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

## Troubleshooting

If the build reports `MSB3021` or `MSB3027` and says that `Quiz.WebUI` is using
a DLL file, stop the currently running application before rebuilding:

```powershell
Get-Process Quiz.WebUI -ErrorAction SilentlyContinue | Stop-Process
dotnet build QuizApp.sln
```

In Visual Studio, the equivalent action is **Stop Debugging** before selecting
**Rebuild Solution**.
