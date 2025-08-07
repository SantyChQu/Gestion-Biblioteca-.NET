using System.Security.Cryptography.X509Certificates;
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Repositorios;
public class RepositorioPrestamo : IRepositorioPrestamo
{
    public void DevolverPrestamoUseCase(Prestamo p)
    {
        using(var context = new RepositoriosContext())
        {
            var ObtenerPrestamo= context.Prestamos.SingleOrDefault(x=>x.Id == p.Id);
            if(ObtenerPrestamo!=null){
                context.Prestamos.Remove(ObtenerPrestamo);
                context.SaveChanges();
            }
        }
    }

    public Prestamo? GetPrestamo(int id)
    {
        using(var context = new RepositoriosContext())
        {
            return context.Prestamos.SingleOrDefault(x=>x.Id==id);
        }
    }

    public List<Prestamo> ListarPrestamoUseCase()
    {
        using(var context = new RepositoriosContext())
        {
            return context.Prestamos.ToList();
        }
    }

          public void RealizarPrestamoUseCase(Prestamo p)
    {
        using(var context = new RepositoriosContext())
        {
            
        if(context.Persona.Any(x=>x.id==p.Idpersona))
            if(context.Libros.Any(x=>x.Id==p.Idlibro)){
                var libro = context.Libros.SingleOrDefault(x=>x.Id==p.Idlibro);
                if(libro.CantEjemplares - libro.ListaPrestamo.Count() >0){
                    context.Prestamos.Add(p);
                    context.SaveChanges();
                }
                   

            }
        }
            }
    
        }
