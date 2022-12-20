using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models;
using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Services.Repository.Context.Builders.Interfaces;

namespace Desaprendiendo.Services.Repository.Context.Builders.Clases
{
    public class LeccionBuilder : ILeccionBuilder
    {
        
        public LeccionBuilder()
        {

        }
        public Lección GetInstance(ref int number)
        {
            Lección nuevaLeccion = new Lección
            {
                Id = number++,
                Lección1 = "Fake Lección" + number.ToString() + ":" + BuilderUtils.CrearStringDeLong(10),
                ComentarioHtml = @"<b> hola lección cruel </b>" + BuilderUtils.CrearStringDeLong(8)
            };
            return nuevaLeccion;
        }
    }
}
