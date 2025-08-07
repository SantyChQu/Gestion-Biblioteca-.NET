using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
namespace Biblioteca.Aplicacion.Entidades;

public class Libro{
    public int Id{set;get;}

    [Required (ErrorMessage = "el titulo es obligatorio")]
    public string Titulo{set;get;}

    [Required (ErrorMessage = "el autor es obligatorio")]
    public string Autor{set;get;}

    [Required (ErrorMessage = "el año de publicacion es obligatorio")]
     [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para año de inicio.")]
    public int AñoPublicacion{set;get;}   

    [Required (ErrorMessage = "el genero es obligatorio")]
     public string genero{set;get;}

     [Required (ErrorMessage = "la cantidad de ejemplares es obligatorio")]
      [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para los ejemplares.")]
    public int CantEjemplares{set;get;}

   public List<Prestamo> ListaPrestamo{set;get;} = new List<Prestamo>();

    public Libro(){
        
    }

    public Libro(string t , string a , int ap, string g , int cant){
        this.Titulo=t;
        this.Autor=a;
        this.AñoPublicacion=ap;
        this.genero=g;
        this.CantEjemplares=cant;
    }

    public override string ToString(){
       return "ID:" + this.Id + "titulo"+this.Titulo + "Autor:" + this.Autor + "Año de publicacion:"+ this.AñoPublicacion + "Genero:" + this.genero + "cantidad de ejemplares:"+this.CantEjemplares;
    }
}