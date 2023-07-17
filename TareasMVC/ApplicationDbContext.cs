using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Net;
using TareasMVC.Entidades;

namespace TareasMVC
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Usar API Fluente
            //modelBuilder.Entity<Tarea>().Property(testc => testc.Titulo).HasMaxLength(250).IsRequired();
        }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
        public DbSet<ArchivoAdjunto> ArchivosAdjuntos { get; set; }
    }
}
