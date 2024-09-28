using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain;

/// <summary>
/// ФИО
/// </summary>
public record FullName
{
    public const int LAST_NAME_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public const int FIRST_NAME_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public const int MIDDLE_NAME_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName { get; private set; } = string.Empty;

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName { get; private set; } = string.Empty;

    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; private set; } = string.Empty;

    public static Result<FullName> Create(string lastName, string firstName, string middleName)
    {
        if (string.IsNullOrWhiteSpace(lastName) || lastName.Length > LAST_NAME_MAX_LENGTH)
            return $"{nameof(LastName)} is invalid";

        if (string.IsNullOrWhiteSpace(firstName) || firstName.Length > FIRST_NAME_MAX_LENGTH)
            return $"{nameof(FirstName)} is invalid";

        if (string.IsNullOrWhiteSpace(middleName) || middleName.Length > MIDDLE_NAME_MAX_LENGTH)
            return $"{nameof(MiddleName)} is invalid";

        return new FullName(lastName, firstName, middleName);
    }

    private FullName() { }

    private FullName(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }
}
