using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain;

/// <summary>
/// ФИО
/// </summary>
public record FullName
{
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
        var fullName = new FullName(lastName, firstName, middleName);
        return fullName;
    }

    private FullName() { }

    private FullName(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }
}
