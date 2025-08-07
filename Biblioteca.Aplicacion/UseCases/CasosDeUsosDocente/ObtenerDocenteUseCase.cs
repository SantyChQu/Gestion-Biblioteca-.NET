using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;

public class ObtenerDocenteUseCase{
    private readonly iRepositorioDocente ld;

    public ObtenerDocenteUseCase(iRepositorioDocente ld){
        this.ld=ld;
    }

    public Docente Ejecutar(int id){
        return ld.GetDocente(id);
    }
}