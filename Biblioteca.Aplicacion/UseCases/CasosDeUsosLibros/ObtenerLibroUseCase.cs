using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;

public class ObtenerLibroUseCase{

    private readonly IRepositorioLibro repo;

    public ObtenerLibroUseCase(IRepositorioLibro r){
        repo=r;
    }

    public Libro Ejecutar(int id){
        return repo.GetLibro(id);
    }
}