using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

/// <summary>
/// Социальная сеть
/// </summary>
public record SocialNetwork
{
    public const int TITLE_MAX_LENGTH = Constants.MAX_SMALL_LENGTH;

    public const int LINK_MAX_LENGTH = Constants.MAX_MEDIUM_LENGTH;

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Ссылка
    /// </summary>
    public string Link { get; set; } = string.Empty;

    public static Result<SocialNetwork> Create(string title, string link)
    {
        if (string.IsNullOrWhiteSpace(title) || title.Length > TITLE_MAX_LENGTH)
            return $"{nameof(title)} is invalid";

        if (string.IsNullOrWhiteSpace(link) || link.Length > LINK_MAX_LENGTH)
            return $"{nameof(link)} is invalid";

        return new SocialNetwork(title, link);
    }

    private SocialNetwork() { }

    private SocialNetwork(string title, string link)
    {
        Title = title;
        Link = link;
    }
}
