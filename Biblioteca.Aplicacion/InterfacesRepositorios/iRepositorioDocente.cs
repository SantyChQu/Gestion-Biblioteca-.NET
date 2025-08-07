using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.InterfacesRepositorios;
public interface iRepositorioDocente{
 void AgregarDocente(Docente d);

  void EliminarDocente(int id);

 void ModificarDocente(Docente d);

 Docente? GetDocente(int id);

  List<Docente> ListarDocentes();

  List<int> IdsDisponibles();

}