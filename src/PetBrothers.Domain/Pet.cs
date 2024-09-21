using CSharpFunctionalExtensions;

namespace PetBrothers.Domain;

/// <summary>
/// Домашний питомец
/// </summary>
public class Pet
{
    private readonly List<PaymentDetails> _paymentDetails = [];

    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Кличка
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Вид животного
    /// </summary>
    public string Species { get; private set; } = string.Empty;

    /// <summary>
    /// Общее описание
    /// </summary>
    public string Description { get; private set; } = string.Empty;

    /// <summary>
    /// Порода
    /// </summary>
    public string Breed { get; private set; } = string.Empty;

    /// <summary>
    /// Окрас
    /// </summary>
    public string Colour { get; private set; } = string.Empty;

    /// <summary>
    /// Информация о здоровье
    /// </summary>
    public string HealthInformation { get; private set; } = string.Empty;

    /// <summary>
    /// Адрес текущего местоположения
    /// </summary>
    public string CurrentAddress { get; private set; } = string.Empty;

    /// <summary>
    /// Вес
    /// </summary>
    public float Weight { get; private set; }

    /// <summary>
    /// Рост
    /// </summary>
    public float Height { get; private set; }

    /// <summary>
    /// Номер телефона для связи с владельцем
    /// </summary>
    public string OwnerPhoneNumber { get; private set; } = string.Empty;

    /// <summary>
    /// Указывает кастрирован ли питомец. true - кастрирован, иначе - false
    /// </summary>
    public bool IsCastrated { get; private set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateOnly BirthDate { get; private set; }

    /// <summary>
    /// Указывает вакцинирован ли питомец. true - вакцинирован, иначе - false
    /// </summary>
    public bool IsVaccinated { get; private set; }

    /// <summary>
    /// Статус помощи
    /// </summary>
    public PetAssistanceStatusEnum AssistanceStatus { get; private set; }

    /// <summary>
    /// Реквизит для финансовой помощи
    /// </summary>
    public IReadOnlyList<PaymentDetails> PaymentDetails => _paymentDetails;

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedDateTime { get; private set; } = DateTime.UtcNow;

    public Result AddPaymentDetails(PaymentDetails paymentDetails)
    {
        _paymentDetails.Add(paymentDetails);

        return Result.Success();
    }
}
