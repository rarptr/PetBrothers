using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

public record YearsExperience
{
    public int Value { get; }

    public static Result<YearsExperience> Create(int value) => new YearsExperience(value);

    private YearsExperience() { }

    private YearsExperience(int value) => Value = value;
}