using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.InterfacesRepositorios;
public interface iRepositorioEstudiante{
    void AgregarEstudiante(Estudiante e);

    void EliminarEstudiante(int id);

    void ModificarEstudiante(Estudiante e);

    Estudiante? GetEstudiante(int id);

    List<Estudiante> ListarEstudiantes();

    int CantidadEstudiantes();
}