using MediatR;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Quiz.Application.Quiz.Queries.GetQuizBatch;
using Quiz.Domain.Questions;
using Quiz.Infrastructure.Persistence;
using Quiz.Infrastructure.Persistence.Repositories;
using Quiz.WebUI.Components;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration
    .GetConnectionString("Sqlite")
    ?? throw new InvalidOperationException(
        "Connection string 'Sqlite' was not found.");

var connectionStringBuilder = new SqliteConnectionStringBuilder(
    connectionString);

if (!Path.IsPathRooted(connectionStringBuilder.DataSource))
{
    connectionStringBuilder.DataSource = Path.Combine(
        builder.Environment.ContentRootPath,
        connectionStringBuilder.DataSource);
}

builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();
builder.Services.AddScoped<ProtectedLocalStorage>();

builder.Services.AddMediatR(configuration =>
    configuration.RegisterServicesFromAssemblyContaining<GetQuizBatchQuery>());

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite(connectionStringBuilder.ConnectionString),
    contextLifetime: ServiceLifetime.Transient);

builder.Services.AddTransient<IQuestionRepository, QuestionRepository>();

var app = builder.Build();

// При старте создаём quiz.db и применяем все ещё не установленные миграции.
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<AppDbContext>();

    dbContext.Database.Migrate();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
