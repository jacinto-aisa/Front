using Desaprendiendo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Models.DomainModel
{
    public class LecciónAnnotation
    {
        public int Id { get; set; }
        [Display(Name = "Titulo Lección")]
        [Required]
        public string Lección1 { get; set; }
        [DataType(DataType.MultilineText)]
        public string ComentarioHtml { get; set; }
        public int? Modulo { get; set; }
        [DisplayName("Se incluyen ejercicios en esta lección")]
        public bool? HayEjercicios { get; set; }
        [DisplayName("Orden dentro del curso por defecto")]
        public int? Pos { get; set; }
        public Modulo ModuloNavigation { get; set; }
    }

    [ModelMetadataType(typeof(LecciónAnnotation))]
    public partial class Lección : IEntity { }
}
