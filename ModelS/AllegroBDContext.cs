using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AllegroBackEnd.ModelS
{
    public partial class AllegroBDContext : DbContext
    {
        public virtual DbSet<ClaseCabecera> ClaseCabecera { get; set; }
        public virtual DbSet<ClaseDetalle> ClaseDetalle { get; set; }
        public virtual DbSet<ClasePracticaVideo> ClasePracticaVideo { get; set; }
        public virtual DbSet<ClaseTeorica> ClaseTeorica { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }
        public virtual DbSet<Estilo> Estilo { get; set; }
        public virtual DbSet<Funcion> Funcion { get; set; }
        public virtual DbSet<FuncionesXrol> FuncionesXrol { get; set; }
        public virtual DbSet<Nivel> Nivel { get; set; }
        public virtual DbSet<PlanEstudioCabecera> PlanEstudioCabecera { get; set; }
        public virtual DbSet<PlanEstudioDetalle> PlanEstudioDetalle { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<Preguntero> Preguntero { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<TipoClase> TipoClase { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=AllegroBD;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClaseCabecera>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.PlanEstudioDetalle)
                    .WithMany(p => p.ClaseCabecera)
                    .HasForeignKey(d => d.PlanEstudioDetalleId)
                    .HasConstraintName("FK_ClaseCabecera_PlanEstudioDetalle");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.ClaseCabecera)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_ClaseCabecera_Usuario");
            });

            modelBuilder.Entity<ClaseDetalle>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ClaseCabecera)
                    .WithMany(p => p.ClaseDetalle)
                    .HasForeignKey(d => d.ClaseCabeceraId)
                    .HasConstraintName("FK_ClasePractica_ClaseCabecera");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<ClaseDetalle>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClasePractica_ClasePractica");

                entity.HasOne(d => d.TipoClase)
                    .WithMany(p => p.ClaseDetalle)
                    .HasForeignKey(d => d.TipoClaseId)
                    .HasConstraintName("FK_ClasePractica_TipoClase");
            });

            modelBuilder.Entity<ClasePracticaVideo>(entity =>
            {
                entity.Property(e => e.LinkStorage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LinkVideo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClaseDetalle)
                    .WithMany(p => p.ClasePracticaVideo)
                    .HasForeignKey(d => d.ClaseDetalleId)
                    .HasConstraintName("FK_ClasePracticaVideo_ClaseDetalle");
            });

            modelBuilder.Entity<ClaseTeorica>(entity =>
            {
                entity.Property(e => e.Contendio)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClaseDetalle)
                    .WithMany(p => p.ClaseTeorica)
                    .HasForeignKey(d => d.ClaseDetalleId)
                    .HasConstraintName("FK_ClaseTeorica_ClaseDetalle");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<Curso>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Curso_Curso");

                entity.HasOne(d => d.Nivel)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.NivelId)
                    .HasConstraintName("FK_Curso_Nivel");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Curso)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Curso_Usuario");
            });

            modelBuilder.Entity<Estilo>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HashFoto)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Estilo)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Estilo_Usuario");
            });

            modelBuilder.Entity<Funcion>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FuncionesXrol>(entity =>
            {
                entity.ToTable("FuncionesXRol");

                entity.HasOne(d => d.Funcion)
                    .WithMany(p => p.FuncionesXrol)
                    .HasForeignKey(d => d.FuncionId)
                    .HasConstraintName("FK_FuncionesXRol_Funcion");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.FuncionesXrol)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_FuncionesXRol_Rol");
            });

            modelBuilder.Entity<Nivel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Nivel)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Nivel_Usuario");
            });

            modelBuilder.Entity<PlanEstudioCabecera>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.PlanEstudioCabecera)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_PlanEstudioCabecera_Usuario");
            });

            modelBuilder.Entity<PlanEstudioDetalle>(entity =>
            {
                entity.HasOne(d => d.Curso)
                    .WithMany(p => p.PlanEstudioDetalle)
                    .HasForeignKey(d => d.CursoId)
                    .HasConstraintName("FK_PlanEstudioDetalle_Curso");

                entity.HasOne(d => d.Estilo)
                    .WithMany(p => p.PlanEstudioDetalle)
                    .HasForeignKey(d => d.EstiloId)
                    .HasConstraintName("FK_PlanEstudioDetalle_Estilo");

                entity.HasOne(d => d.PlanEstudioCabecera)
                    .WithMany(p => p.PlanEstudioDetalle)
                    .HasForeignKey(d => d.PlanEstudioCabeceraId)
                    .HasConstraintName("FK_PlanEstudioDetalle_PlanEstudioCabecera");
            });

            modelBuilder.Entity<Pregunta>(entity =>
            {
                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Pregunta1)
                    .HasColumnName("Pregunta")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Pregunta)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Pregunta_Usuario");
            });

            modelBuilder.Entity<Respuesta>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Respuesta1)
                    .IsRequired()
                    .HasColumnName("Respuesta")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.InverseIdNavigation)
                    .HasForeignKey<Respuesta>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Respuesta_Respuesta");

                entity.HasOne(d => d.Usuario)
                    .WithMany(p => p.Respuesta)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Respuesta_Pregunta");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoClase>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .HasMaxLength(520)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasIndex(e => e.Correo)
                    .HasName("IX_Usuario")
                    .IsUnique();

                entity.Property(e => e.Apellido)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.RolId)
                    .HasConstraintName("FK_Usuario_Rol");
            });
        }
    }
}
