using Microsoft.AspNetCore.Mvc;
using Desaprendiendo.Models.Interfaces;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Desaprendiendo.Services.Repository
{
    public class GenericPhotoRepository<T> : IGenericPhotoRepository<T> where T : class , IImageEntity
    {
        private readonly DBContextEF _dbContext;
        public IWebHostEnvironment Env { get; }

        public GenericPhotoRepository(DBContextEF _dbContext, IWebHostEnvironment env)
        {
            this._dbContext = _dbContext;
            this.Env = env;
        }

        public FileContentResult getDefaultImage(Sizes sizes)
        {
            //byte[] PhotoBytes = File.ReadAllBytes();
            return null;
        }
        public FileContentResult GetImg<T1>(int id, Sizes sizes)
        {
            var _repositorioGenerico = new GenericRepository<T>(_dbContext);
            var requestedPhoto = _repositorioGenerico.GetById(id);
            FileContentResult Photo = getDefaultImage(sizes);
            if (requestedPhoto != null)
            {
                Photo = sizes switch
                {
                    Sizes.pequeño => new FileContentResult(requestedPhoto.ImagenMiniatura, "image/jpeg"),
                    Sizes.grande => new FileContentResult(requestedPhoto.ImagenGrande, "image/jpeg"),
                    _ => getDefaultImage(sizes)
                };
            }
            return Photo;
        }
    }
}
