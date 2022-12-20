using Desaprendiendo.Models;
using Desaprendiendo.Models.DomainModel;
using Microsoft.EntityFrameworkCore;

namespace Desaprendiendo.Services.Repository
{
    public partial class DBRepository : DbContext
    {
        // ReSharper disable once IdentifierTypo
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Lección> Lección { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<SubCategoria> SubCategoria { get; set; }

        public DBRepository(DbContextOptions<DBRepository> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Categoria1)
                    .HasColumnName("Categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioHtml).HasColumnName("ComentarioHTML");

                entity.Property(e => e.ImagenGrande)
                    .HasColumnName("Imagen Grande")
                    .HasColumnType("image");

                entity.Property(e => e.ImagenMiniatura)
                    .HasColumnName("Imagen Miniatura")
                    .HasColumnType("image");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.ComentarioHtml).HasColumnName("Comentario HTML");

                entity.Property(e => e.Curso1)
                    .HasColumnName("Curso")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImagenGrande)
                    .HasColumnName("Imagen Grande")
                    .HasColumnType("image");

                entity.Property(e => e.ImagenMiniatura)
                    .HasColumnName("Imagen Miniatura")
                    .HasColumnType("image");

                entity.HasOne(d => d.SubCategoriaNavigation)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.SubCategoria)
                    .HasConstraintName("FK_Curso_SubCategoria");
            });

            modelBuilder.Entity<Lección>(entity =>
            {
                entity.Property(e => e.ComentarioHtml).HasColumnName("Comentario HTML");

                entity.Property(e => e.HayEjercicios).HasColumnName("Hay Ejercicios");

                entity.Property(e => e.Lección1)
                    .HasColumnName("Lección")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModuloNavigation)
                    .WithMany(p => p.Lección)
                    .HasForeignKey(d => d.Modulo)
                    .HasConstraintName("FK_Lección_Modulo");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.Property(e => e.ComentarioHtml).HasColumnName("Comentario HTML");

                entity.Property(e => e.DuracionEnMinutos).HasColumnName("Duracion en Minutos");

                entity.Property(e => e.HayEjercicios).HasColumnName("Hay Ejercicios");

                entity.Property(e => e.Modulo1)
                    .HasColumnName("Modulo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CursoNavigation)
                    .WithMany(p => p.Modulo)
                    .HasForeignKey(d => d.Curso)
                    .HasConstraintName("FK_Modulo_Curso");
            });

            modelBuilder.Entity<SubCategoria>(entity =>
            {
                entity.Property(e => e.ComentarioHtml).HasColumnName("ComentarioHTML");

                entity.Property(e => e.ImagenGrande)
                    .HasColumnName("Imagen Grande")
                    .HasColumnType("image");

                entity.Property(e => e.ImagenMiniatura)
                    .HasColumnName("Imagen Miniatura")
                    .HasColumnType("image");

                entity.Property(e => e.SubCategoria1)
                    .HasColumnName("Sub Categoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.SubCategoria)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_SubCategoria_Categoria");
            });
        }
    }
}
