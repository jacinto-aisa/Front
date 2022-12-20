using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.ContentItem
{
    public static class ContentItemFactory
    {
        public static ContentItem CreateInstance(IEntity entidad)
        {

            var tipoEntidad = entidad.GetType().Name;
            var elemento = new ContentItem
            {
                Accion = "index"
            };

            if (tipoEntidad == "Categoria")
            {
                elemento.Titulo = ((Categoria)entidad).Categoria1;
                elemento.ContenidoHTML = ((Categoria)entidad).ComentarioHtml;
                elemento.Imagen = ((Categoria)entidad).ImagenGrande;
                elemento.ParametroId = ((Categoria)entidad).Id;
                elemento.Controlador = "SubCategoriasFront";

            }
            if (tipoEntidad == "SubCategoria")
            {
                elemento.Titulo = ((SubCategoria)entidad).SubCategoria1;
                elemento.ContenidoHTML = ((SubCategoria)entidad).ComentarioHtml;
                elemento.Imagen = ((SubCategoria)entidad).ImagenGrande;
                elemento.ParametroId = ((SubCategoria)entidad).Id;
                elemento.Controlador = "CursosFront";
            }
            if (tipoEntidad == "Curso")
            {
                elemento.Titulo = ((Curso)entidad).Curso1;
                elemento.ContenidoHTML = ((Curso)entidad).ComentarioHtml;
                elemento.Imagen = ((Curso)entidad).ImagenGrande;
                elemento.ParametroId = ((Curso)entidad).Id;
                elemento.Controlador = "ModulosFront";
            }
            return elemento;
        }
    }
}
