using PetBrothers.Domain.Shared;
using PetBrothers.Domain.Volunteers.Pets;

namespace PetBrothers.Domain.Volunteers;

/// <summary>
/// Волонтёр
/// </summary>
public sealed class Volunteer : Entity<VolunteerId>
{
    private readonly List<Pet> _ownedPets = [];

    /// <summary>
    /// ФИО
    /// </summary>
    public FullName FullName { get; private set; } = default!;

    /// <summary>
    /// Email
    /// </summary>
    public Email Email { get; private set; } = default!;

    /// <summary>
    /// Общее описание
    /// </summary>
    public CommonDescription CommonDescription { get; private set; } = default!;

    /// <summary>
    /// Лет опыта
    /// </summary>
    public YearsExperience YearsExperience { get; private set; } = default!;

    /// <summary>
    /// Номер телефона
    /// </summary>
    public PhoneNumber PhoneNumber { get; private set; } = default!;

    /// <summary>
    /// Дополнительная информация о волонтёре
    /// </summary>
    public VolunteerDetails VolunteerDetails = default!;

    /// <summary>
    /// Количество удомашненных животных
    /// </summary>
    public int NumberOfDomesticatedPets
        => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.FoundHome);

    /// <summary>
    /// Количество домашних животных, ищущих дом
    /// </summary>
    public int NumberOfPetsLookingForHome
        => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.LookingForHome);

    /// <summary>
    /// Количество животных на лечении
    /// </summary>
    public int NumberOfPetsOnTreatment
        => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.NeedsHelp);

    /// <summary>
    /// Домашние животные, закреплённые за волонтёром
    /// </summary>
    public List<Pet> OwnedPets = [];

    public Result AddOwnedPet(Pet pet)
    {
        _ownedPets.Add(pet);
        return Result.Success();
    }

    public static Result<Volunteer> Create(
        VolunteerId volunteerId,
        FullName fullName,
        Email email,
        CommonDescription commonDescription,
        YearsExperience yearsExperience,
        PhoneNumber phoneNumber,
        VolunteerDetails volunteerDetails)
    {
        ArgumentNullException.ThrowIfNull(volunteerId, nameof(volunteerId));
        ArgumentNullException.ThrowIfNull(fullName, nameof(fullName));
        ArgumentNullException.ThrowIfNull(email, nameof(email));
        ArgumentNullException.ThrowIfNull(commonDescription, nameof(commonDescription));
        ArgumentNullException.ThrowIfNull(phoneNumber, nameof(phoneNumber));
        ArgumentNullException.ThrowIfNull(volunteerDetails, nameof(volunteerDetails));

        return new Volunteer(
            volunteerId,
            fullName,
            email,
            commonDescription,
            yearsExperience,
            phoneNumber,
            volunteerDetails
        );
    }

    private Volunteer(
        VolunteerId volunteerId,
        FullName fullName,
        Email email,
        CommonDescription commonDescription,
        YearsExperience yearsExperience,
        PhoneNumber phoneNumber,
        VolunteerDetails volunteerDetails
    ) : base(volunteerId)
    {
        FullName = fullName;
        Email = email;
        CommonDescription = commonDescription;
        YearsExperience = yearsExperience;
        PhoneNumber = phoneNumber;
        VolunteerDetails = volunteerDetails;
    }
}
