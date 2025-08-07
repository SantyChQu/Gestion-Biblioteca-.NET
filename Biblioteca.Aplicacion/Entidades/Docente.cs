using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace Biblioteca.Aplicacion.Entidades;

public class Docente:Persona{


 [Required (ErrorMessage ="el numero de matricula es obligatorio")]
 [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para Número de matricula.")]
    public int NumMatricula{set;get;}

     [Required (ErrorMessage ="el año de inicio es obligatorio")]
     [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para año de inicio.")]
    public int AñoInicio{set;get;}

    //public List<Prestamo> ListaPrestamos {set;get;}=new List<Prestamo>();
    public Docente(){
        Discriminator="Docente";
    }
    public Docente(int nm, int ai,int n , string nom ,string ape ,string dir, string fa, int tel, string co):base(n, nom, ape, dir,fa, tel, co){
        this.NumMatricula=nm;
        this.AñoInicio=ai;
    }


    public string ToString(){
        return this.Nombre + this.Apellido;
    }
}