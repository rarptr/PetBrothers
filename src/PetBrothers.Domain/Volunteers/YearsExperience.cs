using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record YearsExperience
{
    public int Value { get; }

    public static Result<YearsExperience> Create(int value)
    {
        if (value < 0)
            return $"{nameof(YearsExperience)} cannot be less than zero";

        return new YearsExperience(value);
    }

    private YearsExperience() { }

    private YearsExperience(int value) => Value = value;
}