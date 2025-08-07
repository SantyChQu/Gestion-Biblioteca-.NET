
using System.IO.Compression;
using Biblioteca.Aplicacion.Entidades;
using Microsoft.EntityFrameworkCore;
namespace Biblioteca.Repositorios;

public class RepositoriosContext: DbContext
{
  
  public RepositoriosContext(){
    
  }
  
   public RepositoriosContext(DbContextOptions<RepositoriosContext> options) : base(options)
    {
    }
    
  public DbSet<Libro> Libros{get;set;}
  public DbSet<Prestamo> Prestamos{get;set;}

  public DbSet<Persona> Persona{get;set;}


protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("data source= RepositoriosInfo.sqlite");
    }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Persona>()
        .HasDiscriminator<string>("Discriminator")
        .HasValue<Estudiante>("Estudiante")
        .HasValue<Docente>("Docente");
    modelBuilder.Entity<Prestamo>()
                .HasOne(x=>x.libro)
                .WithMany(x=>x.ListaPrestamo)
                .HasForeignKey(x=>x.Idlibro)
                .OnDelete(DeleteBehavior.Cascade);


    modelBuilder.Entity<Prestamo>()
        .HasOne(x => x.persona)
        .WithMany(x=> x.ListaPrestamos)
        .HasForeignKey(x => x.Idpersona)
        .OnDelete(DeleteBehavior.Cascade);
            
    }

    }
   

