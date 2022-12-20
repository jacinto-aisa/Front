using System;
using System.Collections.Generic;

namespace Desaprendiendo.Models.DomainModel
{
    public partial class Lección
    {
        public int Id { get; set; }
        public string Lección1 { get; set; }
        public string ComentarioHtml { get; set; }
        public int? Modulo { get; set; }
        public bool? HayEjercicios { get; set; }
        public int? Pos { get; set; }

        public Modulo ModuloNavigation { get; set; }
    }
}
