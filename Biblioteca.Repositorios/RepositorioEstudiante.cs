using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Repositorios;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Repositorios;
public class RepositorioEstudiante : iRepositorioEstudiante
{
    private readonly List<Docente> _listaDocente = new List<Docente>();


    public void AgregarEstudiante(Estudiante e)
    {
        using(var context = new RepositoriosContext())
        {
            context.Persona.Add(e);
            context.SaveChanges();
            
        }
    }

    public int CantidadEstudiantes()
    {
        using(var context = new RepositoriosContext())
        {
            return context.Persona.OfType<Estudiante>().Count();
        }
    }

    public void EliminarEstudiante(int id)
    {
     
        using(var context = new RepositoriosContext())
        {
            var EliminarE = context.Persona.OfType<Estudiante>().SingleOrDefault(e => e.id==id);

            if(EliminarE!=null){
                context.Persona.Remove(EliminarE);
                context.SaveChanges();

            }
        }
    }

    public Estudiante? GetEstudiante(int id)
    {
         using(var context = new RepositoriosContext())
        {
            var ObtenerEstudiante= context.Persona.OfType<Estudiante>().SingleOrDefault(d=> d.id==id);

            return ObtenerEstudiante;
        }
    }

    public List<Estudiante> ListarEstudiantes()
    {
       using(var context = new RepositoriosContext ())
        {
          return  context.Persona.OfType<Estudiante>().ToList();
        }
    }



    public void ModificarEstudiante(Estudiante e)
    {
        using(var context = new RepositoriosContext())
        {
        var estudiante = context.Persona.OfType<Estudiante>().SingleOrDefault(est => est.id==e.id);
 
         if(estudiante!=null){
            estudiante.Nombre=e.Nombre;
            estudiante.Apellido=e.Apellido;
            context.SaveChanges();
         }
        }
    }
}
