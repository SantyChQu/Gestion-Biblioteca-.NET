using Biblioteca.Aplicacion.Entidades;
namespace Biblioteca.Aplicacion.InterfacesRepositorios;

public interface IRepositorioPrestamo{

      void RealizarPrestamoUseCase(Prestamo p);
    void DevolverPrestamoUseCase(Prestamo p);
    List<Prestamo> ListarPrestamoUseCase();

    Prestamo? GetPrestamo(int id);
}
