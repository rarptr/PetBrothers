using PetBrothers.Domain.Shared;

namespace PetBrothers.Domain.Volunteers.Pets;

/// <summary>
/// Фото животного
/// </summary>
public record PetPhoto
{
    /// <summary>
    /// Путь хранения
    /// </summary>
    public string StoragePath { get; private set; } = default!;

    /// <summary>
    /// Указывает главное ли фото. true - главное, иначе - false
    /// </summary>
    public bool IsMain { get; }


    public static Result<PetPhoto> Create(string storagePath, bool isMain)
    {
        var petPhoto = new PetPhoto(storagePath, isMain);
        return petPhoto;
    }

    private PetPhoto() { }

    private PetPhoto(string storagePath, bool isMain)
    {
        StoragePath = storagePath;
        IsMain = isMain;
    }
}
