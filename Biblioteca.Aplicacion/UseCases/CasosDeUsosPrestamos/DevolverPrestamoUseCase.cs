namespace Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class DevolverPrestamoUseCase{

    private readonly IRepositorioPrestamo _repe;

      public DevolverPrestamoUseCase(IRepositorioPrestamo repe){
        _repe=repe;
      }
  public  void Ejecutar(Prestamo prestamo){
        _repe.DevolverPrestamoUseCase(prestamo);
    }
}
