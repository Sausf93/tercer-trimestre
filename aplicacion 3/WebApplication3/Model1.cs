namespace WebApplication3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<ALUMNOS> ALUMNOS { get; set; }
        public virtual DbSet<CURSOS> CURSOS { get; set; }
        public virtual DbSet<NOTAS> NOTAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ALUMNOS>()
                .Property(e => e.COD_ALU)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNOS>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNOS>()
                .Property(e => e.DNI)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNOS>()
                .Property(e => e.APELLIDOS)
                .IsUnicode(false);

            modelBuilder.Entity<ALUMNOS>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<CURSOS>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<CURSOS>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CURSOS>()
                .Property(e => e.TUTOR)
                .IsUnicode(false);

            modelBuilder.Entity<NOTAS>()
                .Property(e => e.COD_CUR)
                .IsUnicode(false);

            modelBuilder.Entity<NOTAS>()
                .Property(e => e.COD_ALU)
                .IsUnicode(false);
        }
    }
}
