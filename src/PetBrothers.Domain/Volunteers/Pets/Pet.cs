using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

/// <summary>
/// Домашний питомец
/// </summary>
public sealed class Pet : Entity<PetId>
{
    /// <summary>
    /// Кличка
    /// </summary>
    public Name Name { get; private set; } = default!;

    /// <summary>
    /// Общее описание
    /// </summary>
    public Description Description { get; private set; } = default!;

    /// <summary>
    /// Тип животного
    /// </summary>
    public AnimalType AnimalType { get; private set; } = default!;

    /// <summary>
    /// Окрас
    /// </summary>
    public Colour Colour { get; private set; } = default!;

    /// <summary>
    /// Информация о здоровье
    /// </summary>
    public HealthInformation HealthInformation { get; private set; } = default!;

    /// <summary>
    /// Адрес текущего местоположения
    /// </summary>
    public CurrentAddress CurrentAddress { get; private set; } = default!;

    /// <summary>
    /// Вес
    /// </summary>
    public Weight Weight { get; private set; } = default!;

    /// <summary>
    /// Рост
    /// </summary>
    public Height Height { get; private set; } = default!;

    /// <summary>
    /// Номер телефона для связи с владельцем
    /// </summary>
    public OwnerPhoneNumber OwnerPhoneNumber { get; private set; } = default!;

    /// <summary>
    /// Указывает кастрирован ли питомец. true - кастрирован, иначе - false
    /// </summary>
    public IsCastrated IsCastrated { get; private set; } = default!;

    /// <summary>
    /// Дата рождения
    /// </summary>
    public BirthDate BirthDate { get; private set; } = default!;

    /// <summary>
    /// Указывает вакцинирован ли питомец. true - вакцинирован, иначе - false
    /// </summary>
    public IsVaccinated IsVaccinated { get; private set; } = default!;

    /// <summary>
    /// Статус помощи
    /// </summary>
    public PetAssistanceStatusEnum AssistanceStatus { get; private set; } = PetAssistanceStatusEnum.None;

    /// <summary>
    /// Реквизиты для финансовой помощи
    /// </summary>
    public PetDetails PetDetails = default!;

    public static Result<Pet> Create(
        PetId petId,
        Name name,
        Description description,
        AnimalType animalType,
        Colour colour,
        HealthInformation healthInformation,
        CurrentAddress currentAddress,
        Weight weight,
        Height height,
        OwnerPhoneNumber ownerPhoneNumber,
        IsCastrated isCastrated,
        BirthDate birthDate,
        IsVaccinated isVaccinated,
        PetAssistanceStatusEnum assistanceStatus,
        PetDetails petDetails)
    {
        return new Pet(
            petId,
            name,
            description,
            animalType,
            colour,
            healthInformation,
            currentAddress,
            weight,
            height,
            ownerPhoneNumber,
            isCastrated,
            birthDate,
            isVaccinated,
            assistanceStatus,
            petDetails
        );
    }

    private Pet() : base(PetId.New()) { }

    private Pet(
        PetId id,
        Name name,
        Description description,
        AnimalType animalType,
        Colour colour,
        HealthInformation healthInformation,
        CurrentAddress currentAddress,
        Weight weight,
        Height height,
        OwnerPhoneNumber ownerPhoneNumber,
        IsCastrated isCastrated,
        BirthDate birthDate,
        IsVaccinated isVaccinated,
        PetAssistanceStatusEnum assistanceStatus,
        PetDetails petDetails
    ) : base(id)
    {
        Name = name;
        Description = description;
        AnimalType = animalType;
        Colour = colour;
        HealthInformation = healthInformation;
        CurrentAddress = currentAddress;
        Weight = weight;
        Height = height;
        OwnerPhoneNumber = ownerPhoneNumber;
        IsCastrated = isCastrated;
        BirthDate = birthDate;
        IsVaccinated = isVaccinated;
        AssistanceStatus = assistanceStatus;
        PetDetails = petDetails;
    }
}
