using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Repositorios;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Repositorios;
public class RepositorioDocente : iRepositorioDocente
{
    private readonly List<Docente> _listaDocente = new List<Docente>();

    public void AgregarDocente(Docente d)
    {
        using(var context = new RepositoriosContext())
        {
            context.Persona.Add(d);
            context.SaveChanges();
        }
    }

    public List<int> IdsDisponibles()
    {

        using(var context = new RepositoriosContext())
        {
            var lis = context.Persona.Select(p=>p.id).ToList();  //retorna en una lista todos los ids que son pertenecientes a docentes o estudiantes

         return lis;
         }

    }

    public void EliminarDocente(int id)
    {
        using(var context = new RepositoriosContext())
        {
            var EliminarD = context.Persona.SingleOrDefault(d => d.id==id);

            if(EliminarD!=null){
                context.Persona.Remove(EliminarD);
                context.SaveChanges();
            }
        }
    }

    public Docente? GetDocente(int id)
    {
        using(var context = new RepositoriosContext())
        {
            var ObtenerDocente= context.Persona.OfType<Docente>().SingleOrDefault(d=> d.id==id);

            return ObtenerDocente;
        }
    }

    public List<Docente> ListarDocentes()
    {
        using(var context = new RepositoriosContext ())
        {
            return context.Persona.OfType<Docente>().ToList();
        }
       
    }

    public void ModificarDocente(Docente d)
    {
        using(var context = new RepositoriosContext())
        {
        var docente = context.Persona.OfType<Docente>().SingleOrDefault(doc => doc.id==d.id);
 
         if(docente!=null){
            docente.Nombre=d.Nombre;
            docente.Apellido=d.Apellido;
            context.SaveChanges();
         }
        }
    }
}
