using Desaprendiendo.Models;
using Desaprendiendo.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Services.SearchService.Model
{
    public static class SearchResultFactory
    {
        public static int contador;
        public static SearchResult CreateInstance(IEntity entidad)
        {
            contador++;
            var tipoEntidad = entidad.GetType().Name;

            var elemento = new SearchResult {Action = "index", Parameter = null};
            //if (tipoEntidad == "Categoria")
            //{
            //    elemento.SearchResultId = contador;
            //    elemento.ItemType = "Categoria";
            //    elemento.Title = (entidad as Categoria).Categoria1;
            //    elemento.Content = (entidad as Categoria).ComentarioHtml;
            //    elemento.Controller = "CategoriaFront";
            //    elemento.Parameter = (entidad as Categoria).Id;
            //}
            //if (tipoEntidad == "SubCategoria")
            //{
            //    elemento.SearchResultId = contador;
            //    elemento.ItemType = "SubCategoria";
            //    elemento.Title = (entidad as SubCategoria).SubCategoria1;
            //    elemento.Content = (entidad as SubCategoria).ComentarioHtml;
            //    elemento.Controller = "CategoriaFront";
            //    elemento.Parameter = (entidad as SubCategoria).Id;
            //}
            if (tipoEntidad == "Curso")
            {
                elemento.SearchResultId = contador;
                elemento.ItemType = "Curso";
                elemento.Title = (entidad as Curso).Curso1;
                elemento.Content = (entidad as Curso).ComentarioHtml;
                elemento.Controller = "ModulosFront";
                elemento.Parameter = (entidad as Curso).Id;
            }
            //if (tipoEntidad == "Modulo")
            //{
            //    elemento.SearchResultId = contador;
            //    elemento.ItemType = "Modulo";
            //    elemento.Title = (entidad as Modulo).Modulo1;
            //    elemento.Content = (entidad as Modulo).ComentarioHtml;
            //    elemento.Controller = "CursosFront";
            //    elemento.Parameter = (entidad as Modulo).Curso;
            //}
            return elemento;
        }
    }
}
