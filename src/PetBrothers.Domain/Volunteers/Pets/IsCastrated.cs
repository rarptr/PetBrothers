using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record IsCastrated
{
    public bool Value { get; }

    public static Result<IsCastrated> Create(bool value) => new IsCastrated(value);

    private IsCastrated() { }

    private IsCastrated(bool value) => Value = value;
}