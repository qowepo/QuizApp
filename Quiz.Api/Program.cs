using MediatR;
using Microsoft.EntityFrameworkCore;
using Quiz.Application.Quiz.Queries.GetQuizBatch;
using Quiz.Domain.Questions;
using Quiz.Infrastructure.Persistence;
using Quiz.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("PostgreSql")
    ?? throw new InvalidOperationException(
        "Connection string 'PostgreSql' was not found.");

var allowedOrigins = builder.Configuration
    .GetSection("Cors:AllowedOrigins")
    .Get<string[]>()
    ?? [];

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("QuizClient", policy =>
        policy
            .WithOrigins(allowedOrigins)
            .AllowAnyHeader()
            .AllowAnyMethod());
});

// Регистрируем все MediatR-хендлеры из сборки Application.
builder.Services.AddMediatR(configuration =>
    configuration.RegisterServicesFromAssemblyContaining<GetQuizBatchQuery>());

// API выступает Composition Root и связывает контракты с реализациями.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("QuizClient");
app.MapControllers();

app.Run();
