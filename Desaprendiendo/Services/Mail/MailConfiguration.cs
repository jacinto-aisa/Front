using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Mail
{
    public class MailConfiguration
    {
        public String PrimaryDomain { get; set; }
        public int PrimaryPort { get; set; }
        public String SecondayDomain { get; set; }
        public int SecondaryPort { get; set; }
        public String UsernameEmail { get; set; }
        public String UsernamePassword { get; set; }
        [Display(Name="Desea consultar algo específico para el curso en cuestión:")]
        [Required(ErrorMessage ="Debe de introducir un contenido en el body:")]
        [DataType(DataType.MultilineText)]
        public String Body { get; set; }

        public String FromEmail { get; set; }
        public String ToEmail { get; set; }
        [Display(Name="Introduzca su correo actual")]
        [Required(ErrorMessage ="Debe de introducir su correo o retornal a la web")]
        [DataType(DataType.EmailAddress)]
        public String CcEmail { get; set; }
    }
}

