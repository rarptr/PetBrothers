using CSharpFunctionalExtensions;

namespace PetBrothers.Domain;

/// <summary>
/// ФИО
/// </summary>
public class VolunteerFullName
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


    public static Result<VolunteerFullName> Create(string lastName, string firstName, string middleName)
    {
        var fullName = new VolunteerFullName(lastName, firstName, middleName);
        return Result.Success(fullName);
    }

    private VolunteerFullName(string lastName, string firstName, string middleName)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
    }
}
