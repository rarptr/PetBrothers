using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers;

/// <summary>
/// Социальная сеть
/// </summary>
public record SocialNetwork
{
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
        var socialNetwork = new SocialNetwork(title, link);
        return socialNetwork;
    }

    private SocialNetwork() { }

    private SocialNetwork(string title, string link)
    {
        Title = title;
        Link = link;
    }
}
