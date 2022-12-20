using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Desaprendiendo.Services.Image
{
    public class HelperImage : IHelperImage
    {
        IWebHostEnvironment _webHostEnvironment;

        public HelperImage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public byte[] ImgFromRoot(string ruta)
        {
            string webRootPath = _webHostEnvironment.WebRootPath;
            string contentRootPath = _webHostEnvironment.ContentRootPath;

            string path = webRootPath + "\n" + contentRootPath + ruta;
            return File.ReadAllBytes(path);
        }
    }
}
