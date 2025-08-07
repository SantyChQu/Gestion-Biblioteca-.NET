using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class AgregarEstudianteUseCase{

    private readonly iRepositorioEstudiante re;

    public AgregarEstudianteUseCase(iRepositorioEstudiante re){
        this.re=re;
    }
    public void Ejecutar(Estudiante e){
       re.AgregarEstudiante(e);
    }
}