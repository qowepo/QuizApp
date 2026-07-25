using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Quiz.Domain.Questions;

namespace Quiz.Infrastructure.Persistence.Configurations;

/// <summary>
/// Описывает хранение агрегата Question в SQLite.
/// </summary>
internal sealed class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("questions");

        builder.HasKey(question => question.Id);

        builder.Property(question => question.Id)
            .HasColumnName("id")
            .ValueGeneratedNever();

        builder.Property(question => question.Topic)
            .HasColumnName("topic")
            .HasConversion<string>()
            .HasMaxLength(32)
            .IsRequired();

        builder.Property(question => question.Text)
            .HasColumnName("text")
            .HasColumnType("text")
            .IsRequired();

        builder.Property(question => question.IdealAnswer)
            .HasColumnName("ideal_answer")
            .HasColumnType("text")
            .IsRequired();

        builder.HasIndex(question => question.Topic)
            .HasDatabaseName("ix_questions_topic");

        builder.HasMany(question => question.Answers)
            .WithOne()
            .HasForeignKey(answer => answer.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        // EF изменяет приватную коллекцию напрямую, не обходя методы агрегата.
        builder.Navigation(question => question.Answers)
            .HasField("_answers")
            .UsePropertyAccessMode(PropertyAccessMode.Field);

        builder.HasData(MvpQuestionSeed.All);
    }
}
