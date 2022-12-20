using System;
using System.Collections.Generic;

namespace Desaprendiendo.Models.DomainModel
{
    public partial class Curso
    {
        public Curso()
        {
            Modulo = new HashSet<Modulo>();
        }

        public int Id { get; set; }
        public string Curso1 { get; set; }
        public string ComentarioHtml { get; set; }
        public byte[] ImagenMiniatura { get; set; }
        public byte[] ImagenGrande { get; set; }
        public int? SubCategoria { get; set; }

        public SubCategoria SubCategoriaNavigation { get; set; }
        public ICollection<Modulo> Modulo { get; set; }
    }
}
