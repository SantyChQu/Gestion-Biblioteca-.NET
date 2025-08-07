using Biblioteca.Aplicacion.Entidades;
using Biblioteca.Aplicacion.InterfacesRepositorios;
public class ModificarEstudianteUseCase{
    private readonly iRepositorioEstudiante re;

     public ModificarEstudianteUseCase(iRepositorioEstudiante re){
        this.re=re;
    }
    public void Ejecutar(Estudiante e){
       re.ModificarEstudiante(e);
    }
}

