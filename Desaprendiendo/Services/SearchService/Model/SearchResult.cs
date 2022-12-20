using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.SearchService.Model
{
    public class SearchResult
    {
        public int SearchResultId {get; set;}
        public string ItemType { get; set; }
        [Display (Name="Curso")]
        public string Title { get; set; }
        [Display (Name ="Descripción del curso")]
        public string Content{ get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public int? Parameter { get; set; }
    }
}
