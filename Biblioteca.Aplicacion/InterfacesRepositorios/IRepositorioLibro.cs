using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.InterfacesRepositorios;

public interface IRepositorioLibro{

     void AgregarLibro(Libro l);
    void ModificarLibro(Libro l);
    void EliminarLibro(int id);

    Libro? GetLibro(int id);
    List<Libro> ListarLibros();

    List<int> IdDisponible();
}