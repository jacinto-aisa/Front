using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;

namespace Desaprendiendo.Models.DomainModel
{
    public class SubCategoriaAnnotation 
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Descripción de la categoría")]
        [Required]
        public string SubCategoria1 { get; set; }
        public int? Categoria { get; set; }
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

        public Categoria CategoriaNavigation { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
    [ModelMetadataType(typeof(SubCategoriaAnnotation))]
    public partial class SubCategoria: IEntity, IImageEntity { }

}
