using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;

public class ObtenerEstudianteUseCase{
   private readonly iRepositorioEstudiante repo;
    public ObtenerEstudianteUseCase(iRepositorioEstudiante r){
        repo=r;
    }

    public Estudiante Ejecutar(int id){
       return repo.GetEstudiante(id);
    }
}