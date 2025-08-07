using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace Biblioteca.Aplicacion.Entidades;

public class Prestamo{

   
    public int Id{set;get;}
    [Required (ErrorMessage ="El id de la persona es obligatoria")]
        [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para el id de la persona.")]
    public int Idpersona {set;get;}
[Required (ErrorMessage ="El id del libro es obligatorio")]
    [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para el id del libro.")]
    public int Idlibro {set;get;}


   [Required (ErrorMessage = "La fecha del prestamo es obligatoria")]
    public string FechaPrestamo{set;get;}

    [Required (ErrorMessage = "La fecha de devolucion es obligatoria")]
    public string FechaDevolucion{set;get;}="Indefinido";

    [Required (ErrorMessage = "el estado del libro es obligatorio")]
    public string? Estado{set;get;}

    public Persona persona {set;get;}

    public Libro libro {set;get;}

    public Prestamo(){

    }
public Prestamo(int Pid, int Lid, string fp,string e){  //CONSTRUCTOR PARA PRESTAR UN LIBRO
        this.Idpersona=Pid;
        this.Idlibro=Lid;
        this.FechaPrestamo=fp;
        this.Estado=e;
    }
       public Prestamo(int id,int Pid, int Lid, string e,string fp, string fd){ //CONSTRUCTOR PARA DEVOLVER UN LIBRO
       this.Id=id;
        this.Idpersona=Pid;
        this.Idlibro=Lid;
        this.FechaDevolucion=fd;
         this.FechaPrestamo=fp;
        this.Estado=e;
    }
    public string ToString(){
        return "Id de la persona:"+this.Idpersona + "Id del libro:" + this.Idlibro;
    }

    
}