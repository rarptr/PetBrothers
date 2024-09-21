using CSharpFunctionalExtensions;

namespace PetBrothers.Domain;

/// <summary>
/// Волонтёр
/// </summary>
public class Volunteer
{
    private readonly List<SocialNetwork> _socialNetworks = [];
    private readonly List<PaymentDetails> _paymentDetails = [];
    private readonly List<Pet> _ownedPets = [];

    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Фамилия имя отчество
    /// </summary>
    public string FullName { get; private set; } = string.Empty;

    /// <summary>
    /// Email
    /// </summary>
    public string Email { get; private set; } = string.Empty;

    /// <summary>
    /// Общее описание
    /// </summary>
    public string CommonDescription { get; private set; } = string.Empty;

    /// <summary>
    /// Лет опыта
    /// </summary>
    public int YearsExperience { get; private set; }

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; private set; } = string.Empty;

    /// <summary>
    /// Социальные сети
    /// </summary>
    public IReadOnlyList<SocialNetwork> SocialNetworks => _socialNetworks;

    /// <summary>
    /// Реквизиты для финансовой помощи
    /// </summary>
    public IReadOnlyList<PaymentDetails> PaymentDetails => _paymentDetails;

    /// <summary>
    /// Домашние животные, закреплённые за волонтёром
    /// </summary>
    public IReadOnlyList<Pet> OwnedPets => _ownedPets;

    /// <summary>
    /// Количество удомашненных животных
    /// </summary>
    public int NumberOfDomesticatedPets => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.FoundHome);

    /// <summary>
    /// Количество домашних животных, ищущих дом
    /// </summary>
    public int NumberOfPetsLookingForHome => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.LookingForHome);

    /// <summary>
    /// Количество животных на лечении
    /// </summary>
    public int NumberOfPetsOnTreatment => _ownedPets.Count(pet => pet.AssistanceStatus == PetAssistanceStatusEnum.NeedsHelp);


    public Result AddSocialNetwork(SocialNetwork socialNetwork)
    {
        _socialNetworks.Add(socialNetwork);
        return Result.Success();
    }

    public Result AddPaymentDetail(PaymentDetails paymentDetail)
    {
        _paymentDetails.Add(paymentDetail);
        return Result.Success();
    }

    public Result AddOwnedPet(Pet pet)
    {
        _ownedPets.Add(pet);
        return Result.Success();
    }
}
