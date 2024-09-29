using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record IsVaccinated
{
    public bool Value { get; }

    public IsVaccinated(bool value) => Value = value;
}