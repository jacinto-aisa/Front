using Desaprendiendo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desaprendiendo.Models.DomainModel
{
    public class ModuloAnnotation
    {

        public int Id { get; set; }
        [Display(Name = "Titulo del módulo")]
        [Required]
        public string Modulo1 { get; set; }
        public string ComentarioHtml { get; set; }
        public int? Curso { get; set; }
        public int? DuracionEnMinutos { get; set; }

        [DisplayName("Se incluyen ejercicios en esta lección")]
        public bool? HayEjercicios { get; set; }

        public Curso CursoNavigation { get; set; }
        public ICollection<Lección> Lección { get; set; }
    }
    [ModelMetadataType(typeof(ModuloAnnotation))]
    public partial class Modulo : IEntity{ }

}
