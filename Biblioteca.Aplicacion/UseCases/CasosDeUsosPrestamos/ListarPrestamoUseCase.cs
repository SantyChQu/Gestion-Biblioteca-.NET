namespace Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class ListarPrestamoUseCase{
     private readonly IRepositorioPrestamo _repe;
public ListarPrestamoUseCase(IRepositorioPrestamo repe){
        _repe=repe;
      }
  public List<Prestamo> Ejecutar(){
       return _repe.ListarPrestamoUseCase();
    }
}