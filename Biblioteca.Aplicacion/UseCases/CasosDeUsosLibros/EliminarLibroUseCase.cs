using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class EliminarLibroUseCase{
    private readonly IRepositorioLibro ra;

    public EliminarLibroUseCase(IRepositorioLibro ra){
        this.ra=ra;
    }

    public void Ejecutar(int l){
        ra.EliminarLibro(l);
    }
}