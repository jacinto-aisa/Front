using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desaprendiendo.Models;
using Desaprendiendo.Models.DomainModel;
using Desaprendiendo.Models.Interfaces;
using Desaprendiendo.Services.Repository.Context.Builders;

namespace Desaprendiendo.Services.Repository.Context
{
    public enum Tipo { Categoria, SubCategoria, Curso, Modulo, Leccion };
    //Abstract Factory
    public class FakeRepositoryBuilder : IFakeRepositoryBuilder
    {
        private int leccionContador;
        private int moduloContador;
        private int cursoContador;
        private int SubCategoriaContador;

        public IEntity Createinstance(Tipo tipo)
        {
            switch (tipo)
            {
                case Tipo.Leccion: { break; }
            }
            return new Lección();

        }

        private IEnumerable<Lección> CreateLeccionesDeModulo(Modulo modulo)
        {
            var lecciones = new List<Lección>();
            var leccion1 = new Lección
            {
                Lección1 = "Titulo Lección" + BuilderUtils.CrearStringDeLong(10),
                Id = this.leccionContador++,
                HayEjercicios = false,
                Modulo = modulo.Id,
                ModuloNavigation = modulo,
                ComentarioHtml = "<p>skksksks</p>",
                Pos = this.leccionContador
            };

            var leccion2 = new Lección
            {
                Lección1 = "Titulo de leccion" + BuilderUtils.CrearStringDeLong(22),
                Id = this.leccionContador++,
                HayEjercicios = false,
                Modulo = modulo.Id,
                ModuloNavigation = modulo,
                ComentarioHtml = "<p>skksssssksks</p>",
                Pos = this.leccionContador
            };

            var leccion3 = new Lección
            {
                Lección1 = "Titulo leccion" + BuilderUtils.CrearStringDeLong(34),
                Id = this.leccionContador++,
                HayEjercicios = false,
                Modulo = modulo.Id,
                ModuloNavigation = modulo,
                ComentarioHtml = "<p>skksssssksks</p>",
                Pos = this.leccionContador
            };

            lecciones.Add(leccion1);
            lecciones.Add(leccion2);
            lecciones.Add(leccion3);
            return lecciones;
        }

        private IEnumerable<Modulo> CreateModuloDeCurso(Curso curso)
        {
            var modulos = new List<Modulo>();
            Random rng = new Random();

            var modulo1 = new Modulo
            {
                Id = this.moduloContador++,
                Modulo1 = "Modulo:" + BuilderUtils.CrearStringDeLong(15),
                ComentarioHtml = "<p>paptapapa</p>",
                DuracionEnMinutos = rng.Next(),
                HayEjercicios = true,
                Pos = this.moduloContador++
            };
            modulo1.Lección = CreateLeccionesDeModulo(modulo1).ToArray();
            modulo1.Curso = curso.Id;
            modulo1.CursoNavigation = curso;

            var modulo2 = new Modulo
            {
                Id = this.moduloContador++,
                Modulo1 = "Modulo:" + BuilderUtils.CrearStringDeLong(15),
                ComentarioHtml = "<p>ptapapa</p>",
                DuracionEnMinutos = rng.Next(),
                HayEjercicios = false,
                Pos = this.moduloContador++
            };
            modulo2.Lección = CreateLeccionesDeModulo(modulo2).ToArray();
            modulo2.Curso = curso.Id;
            modulo2.CursoNavigation = curso;

            modulos.Add(modulo1);
            modulos.Add(modulo2);


            return modulos;
        }
        private IEnumerable<Curso> CreateCursoDeSubCategoria(SubCategoria subcategoria)
        {
            var cursos = new List<Curso>();

            var curso1 = new Curso
            {
                Id = this.cursoContador++,
                Curso1 = "Curso: " + BuilderUtils.CrearStringDeLong(15),
                ComentarioHtml = @"<a href='www.google.es' \>",
                ImagenGrande = null,
                ImagenMiniatura = null,
                SubCategoria = subcategoria.Id,
                SubCategoriaNavigation = subcategoria
            };
            curso1.Modulo = CreateModuloDeCurso(curso1).ToArray();

            var curso2 = new Curso
            {
                Id = this.cursoContador++,
                Curso1 = "Curso: " + BuilderUtils.CrearStringDeLong(15),
                ComentarioHtml = @"<a href='www.google.es' \>",
                ImagenGrande = null,
                ImagenMiniatura = null,
                SubCategoria = subcategoria.Id,
                SubCategoriaNavigation = subcategoria
            };
            curso2.Modulo = CreateModuloDeCurso(curso2).ToArray();

            cursos.Add(curso1);
            cursos.Add(curso2);
            return cursos;
        }
        private IEnumerable<SubCategoria> CreateSubCategoriaDeCategoria(Categoria categoria)
        {
            var subCategorias = new List<SubCategoria>();

            var subCategoria1 = new SubCategoria
            {
                Id = this.SubCategoriaContador++,
                SubCategoria1 = "SubCaregoria: " + BuilderUtils.CrearStringDeLong(15),
                ComentarioHtml = @"<a href='www.google.es' \>",
                ImagenGrande = null,
                ImagenMiniatura = null,
                Categoria = categoria.Id,
                CategoriaNavigation = categoria
            };
            subCategoria1.Curso = CreateCursoDeSubCategoria(subCategoria1).ToArray();

            var subCategoria2 = new SubCategoria
            {
                Id = this.SubCategoriaContador++,
                SubCategoria1 = "SubCategoria: " + BuilderUtils.CrearStringDeLong(25),
                ComentarioHtml = @"<a href='www.google.es' \>",
                ImagenGrande = null,
                ImagenMiniatura = null
            };

            subCategorias.Add(subCategoria1);
            subCategorias.Add(subCategoria2);
            return subCategorias;
        }



    }
}
