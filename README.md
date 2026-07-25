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

## Architecture

The solution follows Clean Architecture and Tactical Domain-Driven Design:

- `Quiz.Domain` — rich domain model, aggregates, entities, business rules, and
  repository contracts.
- `Quiz.Application` — CQRS use cases implemented with MediatR and DTO-based
  responses.
- `Quiz.Infrastructure` — Entity Framework Core, PostgreSQL mappings, and
  repository implementations.
- `Quiz.Api` — REST API and the future composition root of the application.

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
- Clean Architecture and Tactical DDD

## Current status

The Domain, Application, and Infrastructure foundations are implemented. The
next step is to configure dependency injection, expose the use cases through
API endpoints, add validation, and create the initial database migration.

Build the solution with:

```powershell
dotnet restore QuizApp.sln
dotnet build QuizApp.sln
```
