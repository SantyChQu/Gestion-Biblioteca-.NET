using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class ModificarLibroUseCase{
    private readonly IRepositorioLibro ra;

    public ModificarLibroUseCase(IRepositorioLibro ra){
        this.ra=ra;
    }

    public void Ejecutar(Libro l){
        ra.ModificarLibro(l);
    }
}