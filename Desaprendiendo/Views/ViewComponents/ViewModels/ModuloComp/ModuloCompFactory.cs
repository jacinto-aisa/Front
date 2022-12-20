using Desaprendiendo.Models.DomainModel;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.ModuloComp
{
    public static class ModuloCompFactory
    {
        public static ModuloComp CreateInstance(Modulo entidad)
        {
            ModuloComp elemento = new ModuloComp
            {
                TituloModulo = entidad.Modulo1,
                DescripcionModulo = entidad.ComentarioHtml,
                LeccionesDelModulo = entidad.Lección
            };
            return elemento;
        }
    }
}
