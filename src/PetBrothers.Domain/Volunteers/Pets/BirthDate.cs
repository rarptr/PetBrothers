using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record BirthDate
{
    public DateOnly Value { get; }

    public static Result<BirthDate> Create(DateOnly value)
    {
        if (value > DateOnly.FromDateTime(DateTime.Now))
            return $"{nameof(BirthDate)} cannot be in the future.";

        return new BirthDate(value);
    }

    private BirthDate() { }

    private BirthDate(DateOnly value) => Value = value;
}