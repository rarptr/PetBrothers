namespace PetBrothers.Domain.Volunteers.Pets;

public record PetPhotos
{
    List<PetPhoto> Value = [];

    //private readonly List<PetPhoto> _petPhotos = [];

    ///// <summary>
    ///// Фотографии
    ///// </summary>
    //public IReadOnlyList<PetPhoto> PetPhotos => _petPhotos;


    //public Result AddPetPhoto(PetPhoto petPhoto)
    //{
    //    _petPhotos.Add(petPhoto);
    //    return Result.Success();
    //}
}
