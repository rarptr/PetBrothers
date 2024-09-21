using CSharpFunctionalExtensions;

namespace PetBrothers.Domain;

/// <summary>
/// Фото животного
/// </summary>
public class PetPhoto
{
    /// <summary>
    /// Путь хранения
    /// </summary>
    public string StoragePath { get; private set; }

    /// <summary>
    /// Указывает главное ли фото. true - главное, иначе - false
    /// </summary>
    public bool IsMain { get; }


    public static Result<PetPhoto> Create(string storagePath, bool isMain)
    {
        var petPhoto = new PetPhoto(storagePath, isMain);
        return Result.Success(petPhoto);
    }

    private PetPhoto(string storagePath, bool isMain)
    {
        StoragePath = storagePath;
        IsMain = isMain;
    }
}
