using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
namespace Biblioteca.Aplicacion.UseCases;
public class CantidadEstudianteUseCase{

    private readonly iRepositorioEstudiante rd;

    public CantidadEstudianteUseCase(iRepositorioEstudiante rd){
        this.rd=rd;
    }

    public int Ejecutar(){
        return rd.CantidadEstudiantes();
    }
}