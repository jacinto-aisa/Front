using Desaprendiendo.Services.Repository;
using Desaprendiendo.Services.SearchService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desaprendiendo.Services.SearchService
{
    public class SearchService : ISearchService
    {
        readonly ICategoriaRepository _categoryRepository;
        readonly ISubCategoriaRepository _subCategoryRepository;
        readonly ICursoRepository _cursoRepository;
        readonly IModuloRepository _moduloRepository;
        public SearchService(ICategoriaRepository categoryRepository, ISubCategoriaRepository subCategoryRepository, ICursoRepository cursoRepository, IModuloRepository moduloRepository)
        {
            _categoryRepository = categoryRepository;
            _subCategoryRepository = subCategoryRepository;
            _cursoRepository = cursoRepository;
            _moduloRepository = moduloRepository;
        }
        
        public async Task<IEnumerable<SearchResult>> Search(string searchedText)
        {
            List<SearchResult> ResultList = new List<SearchResult>();
           
            //var searchResultsCategoria = _categoryRepository.Search(p => p.Categoria1.Contains(searchedText) 
            //                                                          || p.ComentarioHtml.Contains(searchedText));
            //foreach (var item in searchResultsCategoria)
            //{
            //    ResultList.Add(SearchResultFactory.CreateInstance(item));
            //}

            //var searchResultsSubCategoria = _subCategoryRepository.Search(p => p.SubCategoria1.Contains(searchedText)
            //                                                          || p.ComentarioHtml.Contains(searchedText));
            //foreach (var item in searchResultsSubCategoria)
            //{
            //    ResultList.Add(SearchResultFactory.CreateInstance(item));
            //}

            var searchResultsCursos = _cursoRepository.Search(p => p.Curso1.Contains(searchedText)
                                                                      || p.ComentarioHtml.Contains(searchedText));
            foreach (var item in searchResultsCursos)
            {
                ResultList.Add(SearchResultFactory.CreateInstance(item));
            }

            // var searchResultsModulos = _moduloRepository.Search(p => p.Modulo1.Contains(searchedText)
            //                                              && p.ComentarioHtml.Contains(searchedText));
            //foreach (var item in searchResultsModulos)
            //{
            //    ResultList.Add(SearchResultFactory.CreateInstance(item));
            //}

            return ResultList;
        }


    }
}
