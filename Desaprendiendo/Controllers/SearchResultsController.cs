using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Desaprendiendo.Services.Repository;
using Desaprendiendo.Services.SearchService.Model;
using Desaprendiendo.Services.SearchService;

namespace Desaprendiendo.Controllers
{
    public class SearchResultsController : Controller
    {
        private readonly ISearchService _searchService;

        public SearchResultsController(ISubCategoriaRepository repositorioSubCategoria, ICursoRepository repositorioCursos, IModuloRepository repositorioModulos, ICategoriaRepository categoriaRepository)
        {
            _searchService = new SearchService(categoriaRepository, repositorioSubCategoria, repositorioCursos, repositorioModulos);
        }

        // GET: SearchResults
        public async Task<IActionResult> Index(SearchInput textSearched)
        {
            return View(await _searchService.Search(textSearched.SearchedText));
        }

    }
}
