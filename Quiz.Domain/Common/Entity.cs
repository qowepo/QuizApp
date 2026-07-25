namespace Quiz.Domain.Common;

/// <summary>
/// Базовый класс доменной сущности с типизированным идентификатором.
/// </summary>
public abstract class Entity<TId> : IEquatable<Entity<TId>>
    where TId : notnull
{
    protected Entity(TId id)
    {
        Id = id;
    }

    public TId Id { get; private set; }

    /// <summary>
    /// Сравнивает сущности одного типа по их идентификаторам.
    /// </summary>
    public bool Equals(Entity<TId>? other)
    {
        if (other is null || other.GetType() != GetType())
        {
            return false;
        }

        if (EqualityComparer<TId>.Default.Equals(Id, default!) ||
            EqualityComparer<TId>.Default.Equals(other.Id, default!))
        {
            return false;
        }

        return EqualityComparer<TId>.Default.Equals(Id, other.Id);
    }

    public override bool Equals(object? obj) =>
        obj is Entity<TId> other && Equals(other);

    public override int GetHashCode() =>
        HashCode.Combine(GetType(), Id);

    public static bool operator ==(Entity<TId>? left, Entity<TId>? right) =>
        left is null ? right is null : left.Equals(right);

    public static bool operator !=(Entity<TId>? left, Entity<TId>? right) =>
        !(left == right);
}
