using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Views.ViewComponents.ViewModels.Base;
using System.Collections.Generic;

namespace Desaprendiendo.Views.ViewComponents.ViewModels.BreadCum
{
    public class ListBreadFactory : BaseComponentFactory, ILListBreadFactory
    {
        public ListBreadFactory(ICategoriaRepository categoriaRepository, ISubCategoriaRepository subCategoriaRepository, ICursoRepository cursoRepository, IModuloRepository moduloRepository,ILeccionRepository leccionRepository):
            base(categoriaRepository,subCategoriaRepository,cursoRepository,moduloRepository,leccionRepository)
        {
        }
        private Categoria DameCategoria(int id)
        {
            return _categoriaRepository.GetById(id);
        }
        private SubCategoria DameSubCategoria(int id)
        {
            return _subCategoriaRepository.GetById(id);
        }
        private Curso DameCurso(int id)
        {
            return _cursoRepository.GetById(id);
        }
        public List<Bread> GetAll(IEntity entidad)
        {
            var tipoEntidad = entidad.GetType().Name;

            var _viewModelBread = new List<Bread>();

            if (tipoEntidad == "SubCategoria")
            {
                var _Categoria = DameCategoria((int)((SubCategoria)entidad).Categoria);
                var CategoriaAPoner = BreadFactory.CreateInstance(_Categoria);

                _viewModelBread.Add(CategoriaAPoner);
            }
            if (tipoEntidad == "Curso")
            {
                var _SubCategoria = DameSubCategoria((int)((Curso)entidad).SubCategoria);
                var subCategoriaAPoner = BreadFactory.CreateInstance(_SubCategoria);
                subCategoriaAPoner.ParametroId = (entidad as Curso).SubCategoria;

                var _Categoria = DameCategoria((int)((SubCategoria)_SubCategoria).Categoria);
                var CategoriaAPoner = BreadFactory.CreateInstance(_Categoria);

                _viewModelBread.Add(CategoriaAPoner);
                _viewModelBread.Add(subCategoriaAPoner);
            }
            if (tipoEntidad == "Modulo")
            {
                var _Curso = DameCurso((int)((Modulo)entidad).Curso);
                var CursoAPoner = BreadFactory.CreateInstance(_Curso);

                var _SubCategoria = DameSubCategoria((int)((Curso)_Curso).SubCategoria);
                var subCategoriaAPoner = BreadFactory.CreateInstance(_SubCategoria);

                var _Categoria = DameCategoria((int)((SubCategoria)_SubCategoria).Categoria);
                var CategoriaAPoner = BreadFactory.CreateInstance(_Categoria);

                _viewModelBread.Add(CategoriaAPoner);
                _viewModelBread.Add(subCategoriaAPoner);
                _viewModelBread.Add(CursoAPoner);
            }
            return _viewModelBread;
        }
    }
}
