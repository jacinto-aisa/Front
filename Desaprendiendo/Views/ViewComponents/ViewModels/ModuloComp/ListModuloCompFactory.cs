using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.Base;
using Desaprendiendo.Views.ViewComponents.ViewModels.ContentItem;
using System.Collections.Generic;
using System.Linq;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.ModuloComp
{
    public class ListModuloCompFactory : BaseComponentFactory, IListModuloCompFactory
    {
        public ListModuloCompFactory(ICategoriaRepository categoriaRepository,
                                  ISubCategoriaRepository subCategoriaRepository,
                                  ICursoRepository cursoRepository,
                                  IModuloRepository moduloRepository,
                                  ILeccionRepository leccionRepository) :
            base(categoriaRepository, subCategoriaRepository, cursoRepository, moduloRepository, leccionRepository)
        {
        }

        public List<ModuloComp> GetAll(IEntity entidad)
        {
            var CursoId = (entidad as Modulo).Curso;
            var _listaViewModel = new List<ModuloComp>();
            var _listaModulos = _moduloRepository.GetAll().Where(p => p.Curso == CursoId).OrderBy(p => p.Pos);
            if (_listaModulos != null)
            {
                foreach (var modulo in _listaModulos)
                { 
                    var elemento = ModuloCompFactory.CreateInstance(modulo);
                    elemento.LeccionesDelModulo = _leccionRepository.GetAll().Where(p => p.Modulo == modulo.Id).OrderBy(p => p.Pos);
                    _listaViewModel.Add(elemento);
                }
            }
            //Para aquellos cursos que están todavía en desarrollo
            else
            {
                ModuloComp elemento = new ModuloComp() { TituloModulo = "Curso no desarrollado", DescripcionModulo = "<b> El contenido de este curso no está desarrollado <br /> Llame al tlf: 626506548 para más información </b>" };
                _listaViewModel.Add(elemento);
                }
            return _listaViewModel;
        }
    }
}
