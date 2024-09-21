using CSharpFunctionalExtensions;

namespace PetBrothers.Domain;

/// <summary>
/// Социальная сеть
/// </summary>
public class SocialNetwork
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
        return Result.Success(socialNetwork);
    }

    private SocialNetwork(string title, string link)
    {
        Title = title;
        Link = link;
    }
}
