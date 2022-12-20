using System;
using System.Collections.Generic;

namespace Desaprendiendo.Models.DomainModel
{
    public partial class SubCategoria
    {
        public SubCategoria()
        {
            Curso = new HashSet<Curso>();
        }

        public int Id { get; set; }
        public string SubCategoria1 { get; set; }
        public int? Categoria { get; set; }
        public string ComentarioHtml { get; set; }
        public byte[] ImagenMiniatura { get; set; }
        public byte[] ImagenGrande { get; set; }

        public Categoria CategoriaNavigation { get; set; }
        public ICollection<Curso> Curso { get; set; }
    }
}
