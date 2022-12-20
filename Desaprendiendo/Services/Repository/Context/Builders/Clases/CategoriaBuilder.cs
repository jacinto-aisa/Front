using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Services.Repository.Context.Builders.Interfaces;

namespace Desaprendiendo.Services.Repository.Context.Builders.Clases
{
    public class CategoriaBuilder : ICategoriaBuilder
    {
        
        public CategoriaBuilder()
        {

        }
        public Categoria GetInstance(ref int number)
        {
            Categoria nuevaCategoria = new Categoria
            {
                Id = number++,
                Categoria1 = "Fake Categoria" + number.ToString() + ":" + BuilderUtils.CrearStringDeLong(10),
                Color = "black",
                ComentarioHtml = @"<b> hola mundo cruel </b>" + BuilderUtils.CrearStringDeLong(8),
                ImagenGrande = null,
                ImagenMiniatura = null,
                SubCategoria = null
            };
            return nuevaCategoria;
        }
    }
}
