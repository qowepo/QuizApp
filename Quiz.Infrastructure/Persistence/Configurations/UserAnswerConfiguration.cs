using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Описывает хранение ответов пользователей в PostgreSQL.
/// </summary>
internal sealed class UserAnswerConfiguration
    : IEntityTypeConfiguration<UserAnswer>
{
    public void Configure(EntityTypeBuilder<UserAnswer> builder)
    {
        builder.ToTable("user_answers");

        builder.HasKey(answer => answer.Id);

        builder.Property(answer => answer.Id)
            .HasColumnName("id")
            .ValueGeneratedNever();

        builder.Property(answer => answer.UserId)
            .HasColumnName("user_id")
            .IsRequired();

        builder.Property(answer => answer.QuestionId)
            .HasColumnName("question_id")
            .IsRequired();

        builder.Property(answer => answer.AnswerText)
            .HasColumnName("answer_text")
            .HasColumnType("text")
            .IsRequired();

        builder.Property(answer => answer.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone")
            .IsRequired();

        // Ограничение БД защищает от повторного ответа при конкурентных запросах.
        builder.HasIndex(answer => new { answer.UserId, answer.QuestionId })
            .IsUnique()
            .HasDatabaseName("ux_user_answers_user_id_question_id");
    }
}
