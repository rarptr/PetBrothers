using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

public record HealthInformation
{
    public string Value { get; } = string.Empty;

    public static Result<HealthInformation> Create(string value) => new HealthInformation(value);

    private HealthInformation() { }

    private HealthInformation(string value) => Value = value;
}