using Biblioteca.Aplicacion;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class EliminarEstudianteUseCase{
    private readonly iRepositorioEstudiante re;

     public EliminarEstudianteUseCase(iRepositorioEstudiante re){
        this.re=re;
    }
    public void Ejecutar(int id){
       re.EliminarEstudiante(id);
    }
}
