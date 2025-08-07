using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class RealizarPrestamoUseCase{
      
      private readonly IRepositorioPrestamo _repe;

      public RealizarPrestamoUseCase(IRepositorioPrestamo repe){
        _repe=repe;
      }
   public  void Ejecutar(Prestamo prestamo){
        _repe.RealizarPrestamoUseCase(prestamo);
    }
}