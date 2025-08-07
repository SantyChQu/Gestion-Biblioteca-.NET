using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class ListarLibrosUseCase{
    private readonly IRepositorioLibro ra;

    public ListarLibrosUseCase(IRepositorioLibro ra){
        this.ra=ra;
    }

    public List<Libro> Ejecutar(){
        return ra.ListarLibros();
    }
}