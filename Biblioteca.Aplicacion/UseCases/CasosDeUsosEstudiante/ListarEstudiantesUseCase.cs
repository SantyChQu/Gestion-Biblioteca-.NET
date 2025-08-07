using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class ListarEstudiantesUseCase{
    private readonly iRepositorioEstudiante re;

     public ListarEstudiantesUseCase(iRepositorioEstudiante re){
        this.re=re;
    }
    public List<Estudiante> Ejecutar(){
       return re.ListarEstudiantes();
    }
}
