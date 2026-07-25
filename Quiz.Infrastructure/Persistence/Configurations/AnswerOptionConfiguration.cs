using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Описывает хранение вариантов ответа в SQLite.
/// </summary>
internal sealed class AnswerOptionConfiguration
    : IEntityTypeConfiguration<AnswerOption>
{
    public void Configure(EntityTypeBuilder<AnswerOption> builder)
    {
        builder.ToTable("answer_options");

        builder.HasKey(option => option.Id);

        builder.Property(option => option.Id)
            .HasColumnName("id")
            .ValueGeneratedNever();

        builder.Property(option => option.QuestionId)
            .HasColumnName("question_id")
            .IsRequired();

        builder.Property(option => option.Text)
            .HasColumnName("text")
            .HasColumnType("text")
            .IsRequired();

        builder.Property(option => option.IsCorrect)
            .HasColumnName("is_correct")
            .IsRequired();

        builder.Property(option => option.Explanation)
            .HasColumnName("explanation")
            .HasColumnType("text")
            .IsRequired();

        builder.HasIndex(option => option.QuestionId)
            .HasDatabaseName("ix_answer_options_question_id");

        builder.HasData(AnswerOptionSeed.All.Select(option => new
        {
            option.Id,
            option.QuestionId,
            option.Text,
            option.IsCorrect,
            option.Explanation
        }));
    }
}
