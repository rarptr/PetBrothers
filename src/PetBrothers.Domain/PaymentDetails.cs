using CSharpFunctionalExtensions;

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


    public static Result<PaymentDetails> Create(string title, string description)
    {
        var paymentDetails = new PaymentDetails(title, description);
        return Result.Success(paymentDetails);
    }

    private PaymentDetails(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
