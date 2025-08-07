using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;
public class IdsDisponiblesUseCase{

    private readonly iRepositorioDocente rd;

    public IdsDisponiblesUseCase(iRepositorioDocente rd){
        this.rd=rd;
    }

    public List<int> Ejecutar(){
        return rd.IdsDisponibles();
    }
}