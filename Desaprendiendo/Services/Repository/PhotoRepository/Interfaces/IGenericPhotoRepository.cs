using Desaprendiendo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Desaprendiendo.Services.Repository
{
    public interface IGenericPhotoRepository <T> where T : class, IImageEntity
    {
        FileContentResult GetImg<T1>(int id, Sizes sizes);
        FileContentResult getDefaultImage(Sizes sizes);
    }
}
