using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.Repository.Context.Builders
{
    public static class BuilderUtils
    {
        public static String CrearStringDeLong(int longitud)
        {
            const string AllowedChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#@$^*()";
            Random rng = new Random();

            return RandomString(rng, AllowedChars, (15, longitud));
        }

        public static int CrearEnteroEnRango(int rangoInferior, int rangoSuperior)
        {
            Random r = new Random();
            return r.Next(rangoInferior, rangoSuperior); 
        }

        public static byte[] ImgFromRoot(Sizes sizes, IWebHostEnvironment webHostEnvironment)
        {
            string webRootPath = webHostEnvironment.WebRootPath;
            string contentRootPath = webHostEnvironment.ContentRootPath;

            string path = webRootPath + "\n" + contentRootPath+@"/image/noimage.jpg";
            return File.ReadAllBytes(path);
        }

        private static string RandomString(
        this Random rnd,
        string allowedChars,
        (int Min, int Max) length)
        {
            ISet<string> usedRandomStrings = new HashSet<string>();
            (int min, int max) = length;
            char[] chars = new char[max];
            int setLength = allowedChars.Length;



            int stringLength = rnd.Next(min, max + 1);

            for (int i = 0; i < stringLength; ++i)
            {
                chars[i] = allowedChars[rnd.Next(setLength)];
            }

            return new string(chars, 0, stringLength);



        }
    }
}

