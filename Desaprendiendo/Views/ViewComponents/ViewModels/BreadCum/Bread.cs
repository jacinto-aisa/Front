namespace Desaprendiendo.Views.ViewComponents.ViewModels.BreadCum
{
    public class Bread 
    {
        public string Titulo { get; set; }
        public byte[] Imagen { get; set; }
        public string Controlador { get; set; }
        public string Accion { get ; set ; }
        public int? ParametroId { get ; set; }
        public bool ImagenVisible { get; set; }
    }
}
