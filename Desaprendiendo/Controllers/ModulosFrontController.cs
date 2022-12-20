using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Desaprendiendo.Models;
using Desaprendiendo.Services.Repository;
using Microsoft.AspNetCore.Http;

namespace Desaprendiendo.Controllers
{
    public class ModulosFrontController  : Controller
    {
        private readonly IModuloRepository _repositorioModulos;
        public ICursoRepository RepositorioCurso { get; }

        public ModulosFrontController(IModuloRepository repositorioModulos, 
                                      ICursoRepository repositorioCurso)
        {
            _repositorioModulos = repositorioModulos;
            RepositorioCurso = repositorioCurso;
        }
        public async Task<IActionResult> Index(int id)
        {
            var listaModulos = _repositorioModulos.GetAll().Where(p => p.Curso == id).OrderBy(p => p.Pos);
            return View(await listaModulos.ToListAsync());
        }
    }
}
