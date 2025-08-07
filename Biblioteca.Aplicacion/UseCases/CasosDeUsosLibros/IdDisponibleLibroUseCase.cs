using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;
public class IdDisponibleLibroUseCase{

    private readonly IRepositorioLibro rd;

    public IdDisponibleLibroUseCase(IRepositorioLibro rd){
        this.rd=rd;
    }

    public List<int> Ejecutar(){
        return rd.IdDisponible();
    }
}