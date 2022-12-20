using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;
using System.IO;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.BreadCum
{
    public static class BreadFactory
    {


        public static Bread CreateInstance(IEntity entidad)
        {

            var tipoEntidad = entidad.GetType().Name;

            var elemento = new Bread {Accion = "Index", ParametroId = null, ImagenVisible = true};
            if (tipoEntidad == "Categoria")
            {
                elemento.Titulo = (entidad as Categoria).Categoria1;
                elemento.Imagen = (entidad as Categoria).ImagenMiniatura;
                elemento.Controlador = "SubCategoriasFront";
                elemento.ParametroId = (entidad as Categoria).Id;
                
            }
            if (tipoEntidad == "SubCategoria")
            {
                elemento.Titulo = ((SubCategoria)entidad).SubCategoria1;
                elemento.Imagen = ((SubCategoria)entidad).ImagenMiniatura;
                elemento.Controlador = "CursosFront";
                elemento.ParametroId = (entidad as SubCategoria).Id;
            }
            if (tipoEntidad == "Curso")
            {
                var _Curso = (entidad as Curso);
                elemento.Titulo = _Curso.Curso1+"\n (Pulse para información)";
                elemento.ImagenVisible = true;
                string path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\images\icon-email-64.jpg"}";
                elemento.Imagen = File.ReadAllBytes(path);
                elemento.Controlador = "CursosFront";
                elemento.Accion = "Information";
                elemento.ParametroId = _Curso.Id;
            }
            if (tipoEntidad == "Modulo")
            {
            }
            return elemento;
        }
    }
}
