using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain;

/// <summary>
/// Реквизит
/// </summary>
public record PaymentDetail
{
    /// <summary>
    /// Название реквизита
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Описание деталей реквизита
    /// </summary>
    public string Description { get; set; } = string.Empty;


    public static Result<PaymentDetail> Create(string title, string description)
    {
        var paymentDetails = new PaymentDetail(title, description);
        return paymentDetails;
    }

    private PaymentDetail(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
