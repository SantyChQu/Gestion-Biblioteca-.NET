using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace Biblioteca.Aplicacion.Entidades;

public class Estudiante:Persona{

    [Required (ErrorMessage ="el numero de alumno es obligatorio")]
    [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para Número de alumno.")]
    public int NumAlumno{set;get;}
   
   [Required (ErrorMessage ="la carrera es obligatoria")]
    public string Carrera{set;get;}


   public Estudiante(){
        Discriminator="Estudiante";
    }
    public Estudiante(int nm, string carrera){
        this.NumAlumno=nm;
        this.Carrera=carrera;
    }

    public string ToString(){
        return "carrera:"+this.Carrera;
    }
}
