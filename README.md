# QuizApp

QuizApp is a self-assessment platform for developers preparing for senior-level
technical and architecture interviews. It focuses on scenario-based questions about
C#, Entity Framework Core, RabbitMQ, PostgreSQL, and architecture patterns.

## Core idea

A user selects a topic and receives up to ten random questions balanced across
Middle, Middle+, Senior, and Senior+ levels. Questions that the user has already
answered are excluded. Correctness and explanations remain hidden until an
answer option has been selected and saved.

The interactive session has four stages:

1. Select a topic.
2. Select the most accurate of four technically plausible answers.
3. Review green/red feedback and the detailed explanation.
4. Continue until the batch is complete.
5. Reset personal progress whenever previously answered questions should be
   available again.

The question bank includes 210 ready-to-use questions: 50 for C# and 40 for
each other currently supported topic. The C# set also contains code-reading
tasks about closures, asynchronous execution, concurrency, resource lifetimes,
and exception handling. The bank can be extended as topics evolve.

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

The UI calls Application use cases directly through `IMediator`; no HTTP API is
required inside this deployment.

```text
Quiz.WebUI ───────> Quiz.Application ───────> Quiz.Domain
     │                                         ▲
     └───────────> Quiz.Infrastructure ─────────┘
```

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

## Troubleshooting

If the build reports `MSB3021` or `MSB3027` and says that `Quiz.WebUI` is using
a DLL file, stop the currently running application before rebuilding:

```powershell
Get-Process Quiz.WebUI -ErrorAction SilentlyContinue | Stop-Process
dotnet build QuizApp.sln
```

In Visual Studio, the equivalent action is **Stop Debugging** before selecting
**Rebuild Solution**.
