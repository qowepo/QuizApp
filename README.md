# QuizApp

QuizApp is a self-assessment platform for developers preparing for senior-level
technical and architecture interviews. It helps users practice open-ended
questions in areas such as C#, Entity Framework, RabbitMQ, PostgreSQL, and
architecture patterns.

## Core idea

A user selects a topic and receives up to five random questions. Questions that
the user has answered before are excluded. The reference answer remains hidden
until the user's own answer has been submitted and saved.

The intended API workflow is:

1. `GET /api/quiz/{topic}/start` returns questions as `{ id, text }`.
2. The user writes and submits an answer.
3. `POST /api/quiz/answer` saves it and returns `{ idealAnswer }`.

Until authentication is introduced, the client sends a stable anonymous user
identifier in the `X-User-Id` header.

## Architecture

The solution follows Clean Architecture and Tactical Domain-Driven Design:

- `Quiz.Domain` — rich domain model, aggregates, entities, business rules, and
  repository contracts.
- `Quiz.Application` — CQRS use cases implemented with MediatR and DTO-based
  responses.
- `Quiz.Infrastructure` — Entity Framework Core, PostgreSQL mappings, and
  repository implementations.
- `Quiz.Api` — REST API and the composition root of the application.
- `Quiz.Client` — Blazor WebAssembly UI built with MudBlazor.

Dependencies point inward:

```text
Quiz.Api ───────────────┐
  │                     │
  ├── Quiz.Application ─┼──> Quiz.Domain
  └── Quiz.Infrastructure ┘
```

## Important business rules

- A user must never receive a question they have already answered.
- A quiz batch contains no more than five unique questions.
- The ideal answer is never included in the initial question response.
- A user can submit only one answer per question.
- Database uniqueness protects the answer rule during concurrent requests.

## Technology

- .NET 8 / C#
- ASP.NET Core Web API
- MediatR and CQRS
- Entity Framework Core
- PostgreSQL with Npgsql
- Blazor WebAssembly and MudBlazor
- Clean Architecture and Tactical DDD

## Current status

The end-to-end quiz flow is implemented, including the Blazor topic selection,
answer, review, and completion states. The next step is to add validation and
centralized error handling, replace the anonymous browser identifier with
authentication claims, and create the initial database migration.

Build the solution with:

```powershell
dotnet restore QuizApp.sln
dotnet build QuizApp.sln
```

Run the API and client in separate terminals:

```powershell
dotnet run --project Quiz.Api
dotnet run --project Quiz.Client
```

For local development, keep the PostgreSQL password outside the repository by
using .NET User Secrets:

```powershell
dotnet user-secrets set "ConnectionStrings:PostgreSql" `
  "Host=localhost;Port=5432;Database=quiz_app;Username=postgres;Password=your-password" `
  --project Quiz.Api
```

Production environments should provide the same value through the
`ConnectionStrings__PostgreSql` environment variable or a dedicated secret
store.
