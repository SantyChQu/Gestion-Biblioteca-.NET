using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class AgregarLibroUseCase{
    private readonly IRepositorioLibro ra;

    public AgregarLibroUseCase(IRepositorioLibro ra){
        this.ra=ra;
    }

    public void Ejecutar(Libro l){
        ra.AgregarLibro(l);
    }
}