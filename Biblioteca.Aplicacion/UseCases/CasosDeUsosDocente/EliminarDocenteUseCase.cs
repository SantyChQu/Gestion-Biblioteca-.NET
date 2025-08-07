using Biblioteca.Aplicacion;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;

public class EliminarDocenteUseCase{

   private readonly iRepositorioDocente rd;

    public EliminarDocenteUseCase(iRepositorioDocente rd){
        this.rd=rd;
    }

    public void Ejecutar(int id){
        rd.EliminarDocente(id);
    }
}