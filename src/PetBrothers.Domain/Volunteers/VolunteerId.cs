using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record VolunteerId : IBaseId
{
    public Guid Value { get; }

    public static VolunteerId New() => new(Guid.NewGuid());
    public static VolunteerId Empty() => new(Guid.Empty);
    public static VolunteerId Create(Guid id) => new(id);

    public static implicit operator VolunteerId(Guid id) => new VolunteerId(id);

    public static implicit operator Guid(VolunteerId volunteerId)
        => volunteerId?.Value ?? throw new ArgumentNullException(nameof(volunteerId));

    private VolunteerId(Guid value) => Value = value;
}
