using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.SearchService.Model
{
    public class SearchInput
    {
        [Display(Name = "Descripción del curso")]
        [Required]
        public String SearchedText { get; set; }
    }
}
