using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Height
{
    public float Value { get; }

    public static Result<Height> Create(float value) => new Height(value);

    private Height() { }

    private Height(float value) => Value = value;

}