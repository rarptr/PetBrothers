namespace PetBrothers.Domain.Volunteers.Pets;

/// <summary>
/// Домашний питомец
/// </summary>
public class Pet
{
    /// <summary>
    /// Id
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Кличка
    /// </summary>
    public Name Name { get; private set; } = default!;

    /// <summary>
    /// Вид животного
    /// </summary>
    public Species Species { get; private set; } = default!;

    /// <summary>
    /// Общее описание
    /// </summary>
    public Description Description { get; private set; } = default!;
    /// <summary>
    /// Порода
    /// </summary>
    public Breed Breed { get; private set; } = default!;

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

    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreatedDateTime { get; private set; } = DateTime.UtcNow;
}
