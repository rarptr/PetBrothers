using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record Weight
{
    public float Value { get; }

    public static Result<Weight> Create(float value)
    {
        if (value <= 0f)
            return $"{nameof(Weight)} cannot be less than or equal to zero";

        return new Weight(value);
    }

    private Weight() { }

    private Weight(float value) => Value = value;
}