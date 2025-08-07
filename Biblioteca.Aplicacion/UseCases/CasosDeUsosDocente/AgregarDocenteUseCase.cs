using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;
public class AgregarDocenteUseCase{

    private readonly iRepositorioDocente rd;

    public AgregarDocenteUseCase(iRepositorioDocente rd){
        this.rd=rd;
    }

    public void Ejecutar(Docente d){
        this.rd.AgregarDocente(d);
    }
}