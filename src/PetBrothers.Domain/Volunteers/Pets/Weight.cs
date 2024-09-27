using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Weight
{
    public float Value { get; }

    public static Result<Weight> Create(float value) => new Weight(value);

    private Weight() { }

    private Weight(float value) => Value = value;
}