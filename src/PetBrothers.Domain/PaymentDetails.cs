namespace PetBrothers.Domain;

/// <summary>
/// Реквизит
/// </summary>
public class PaymentDetails
{
    /// <summary>
    /// Название реквизита
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Описание деталей реквизита
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
