using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record IsVaccinated
{
    public bool Value { get; }

    public static Result<IsVaccinated> Create(bool value) => new IsVaccinated(value);

    private IsVaccinated(bool value) => Value = value;
}