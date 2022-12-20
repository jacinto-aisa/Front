using System;
using System.Collections.Generic;

namespace Desaprendiendo.Models.DomainModel
{
    public partial class Categoria
    {
        public Categoria()
        {
            SubCategoria = new HashSet<SubCategoria>();
        }

        public int Id { get; set; }
        public string Categoria1 { get; set; }
        public string ComentarioHtml { get; set; }
        public byte[] ImagenMiniatura { get; set; }
        public byte[] ImagenGrande { get; set; }
        public string Color { get; set; }

        public ICollection<SubCategoria> SubCategoria { get; set; }
    }
}
