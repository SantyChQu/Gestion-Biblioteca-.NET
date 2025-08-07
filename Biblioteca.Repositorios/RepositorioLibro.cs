using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
using Biblioteca.Repositorios;
using Microsoft.EntityFrameworkCore;
public class RepositorioLibro : IRepositorioLibro
{
    public void AgregarLibro(Libro l)
    {
        using (var context = new RepositoriosContext())
        {
            context.Libros.Add(l);
            context.SaveChanges();
        }
    }

    public void EliminarLibro(int id)
    {
        using(var context =new RepositoriosContext())

        {
            var EliminarLibro= context.Libros.SingleOrDefault(x=> x.Id==id);

            if(EliminarLibro!=null){
                var LisPrestamo= context.Prestamos.Where(x=>x.Idlibro==id).ToList();
                context.Prestamos.RemoveRange(LisPrestamo);
                context.Libros.Remove(EliminarLibro);

                context.SaveChanges();
            }
        }
    }

    public Libro? GetLibro(int id)
    {
        using(var context = new RepositoriosContext())
        {
           // var ObtenerLibro = context.Libros.SingleOrDefault(x=>x.Id ==id);
            var libro = context.Libros
                               .Include(l => l.ListaPrestamo)
                               .SingleOrDefault(x => x.Id == id);

            return libro;
            
        }
    }

    public List<int> IdDisponible()
    {
        using(var context = new RepositoriosContext())
        {
            var lis = context.Libros.Select(p=>p.Id).ToList();
            return lis;
        }
    }

    public List<Libro> ListarLibros()
    {
     using(var context = new RepositoriosContext())
     {
        return context.Libros.ToList();
     }   
    }
    public void ModificarLibro(Libro l)
    {
        using(var context = new RepositoriosContext())
        {
            var LibroModificar= context.Libros.SingleOrDefault(x=>x.Id==l.Id);

            if(LibroModificar!=null){
                LibroModificar.Autor=l.Autor;

                context.SaveChanges();
            }
        }
    }
}
