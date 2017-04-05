namespace practica_de_asp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ALUMNO> ALUMNOS { get; set; }
        public virtual DbSet<CURSO> CURSOS { get; set; }
        public virtual DbSet<NOTA> NOTAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALUMNO>()
                .Property(e => e.COD_ALU)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNO>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNO>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNO>()
                .Property(e => e.APELLIDOS)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CURSO>()
                .Property(e => e.TUTOR)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<NOTA>()
                .Property(e => e.COD_ALU)
                .IsUnicode(false);
        }
    }
}