namespace PetBrothers.Domain;

/// <summary>
/// Статус животного
/// </summary>
public enum PetAssistanceStatusEnum
{
    /// <summary>
    /// Нуждается в помощи
    /// </summary>
    NeedsHelp,

    /// <summary>
    /// Ищет дом
    /// </summary>
    LookingForHome,

    /// <summary>
    /// Дом найден
    /// </summary>
    FoundHome,

    /// <summary>
    /// Статус не определен
    /// </summary>
    None
}
