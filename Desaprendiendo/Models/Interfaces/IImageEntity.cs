using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Models.Interfaces
{
    public interface IImageEntity
    {
        byte[] ImagenMiniatura { get; set; }
        byte[] ImagenGrande { get; set; }
    }
}
