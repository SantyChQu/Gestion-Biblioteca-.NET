using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;

public class ModificarDocenteUseCase{

    private readonly iRepositorioDocente rd;

    public ModificarDocenteUseCase(iRepositorioDocente rd){
        this.rd=rd;
    }

    public void Ejecutar(Docente d){
        rd.ModificarDocente(d);

    }
}