using PetBrothers.Domain.Shared;
using PetBrothers.Domain.Volunteers.Pets;

namespace PetBrothers.Domain.Volunteers;

/// <summary>
/// Волонтёр
/// </summary>
public class Volunteer
{
    private readonly List<Pet> _ownedPets = [];

    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; private set; }

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
}
