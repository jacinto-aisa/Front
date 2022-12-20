using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Desaprendiendo.Models.Interfaces;

namespace Desaprendiendo.Models.DomainModel
{
    public class CursoAnnotation 
    {
        public int Id { get; set; }

        [Display(Name = "Descripción del curso")]
        [Required]
        public string Curso1 { get; set; }

        [DataType(DataType.MultilineText)]
        public string ComentarioHtml { get; set; }
        [DataType(DataType.Upload)]
        [Display(Name = "Subir Imagen en Miniatura")]
        [FileExtensions(Extensions = "jpg")]
        public byte[] ImagenMiniatura { get; set; }

        [DataType(DataType.Upload)]
        [Display(Name = "Subir Imagen")]
        [FileExtensions(Extensions = "jpg")]
        public byte[] ImagenGrande { get; set; }
        public int? SubCategoria { get; set; }

        public SubCategoria SubCategoriaNavigation { get; set; }
        public ICollection<Modulo> Modulo { get; set; }
    }
    [ModelMetadataType(typeof(CategoriaAnnotation))]
    public partial class Curso : IEntity, IImageEntity
    {
    }
}
