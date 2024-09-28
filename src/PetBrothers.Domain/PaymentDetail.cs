using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain;

/// <summary>
/// Реквизит
/// </summary>
public record PaymentDetail
{
    public const int TITLE_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;
    
    public const int DESCRIPTION_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Описание деталей
    /// </summary>
    public string Description { get; set; } = string.Empty;


    public static Result<PaymentDetail> Create(string title, string description)
    {
        if (string.IsNullOrWhiteSpace(title) || title.Length > TITLE_MAX_LENGTH)
            return $"{nameof(title)} is invalid";

        if (string.IsNullOrWhiteSpace(description) || description.Length > DESCRIPTION_MAX_LENGTH)
            return $"{nameof(description)} is invalid";

        return new PaymentDetail(title, description);
    }

    private PaymentDetail(string title, string description)
    {
        Title = title;
        Description = description;
    }
}
