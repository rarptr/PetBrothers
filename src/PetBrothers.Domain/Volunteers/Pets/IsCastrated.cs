using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record IsCastrated
{
    public bool Value { get; }

    public IsCastrated(bool value) => Value = value;
}