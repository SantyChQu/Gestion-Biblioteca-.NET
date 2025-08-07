using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;


public class ListarDocentesUseCase{
    private readonly iRepositorioDocente ld;

    public ListarDocentesUseCase(iRepositorioDocente ld){
        this.ld=ld;
    }

    public List<Docente> Ejecutar(){
        return ld.ListarDocentes();
    }
}