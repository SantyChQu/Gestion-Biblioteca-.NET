
using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;

public class ObtenerPrestamoUseCase{

    private readonly IRepositorioPrestamo rep;

    public ObtenerPrestamoUseCase(IRepositorioPrestamo r){
        rep=r;
    }

    public Prestamo? Ejecutar(int id){

       return rep.GetPrestamo(id);
    }
}