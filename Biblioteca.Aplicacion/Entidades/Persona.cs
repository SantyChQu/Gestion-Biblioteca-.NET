using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Biblioteca.Aplicacion.Entidades;

public abstract class Persona
{ 


   public string Discriminator{get;set;}
    public int id{set;get;}


    [Required (ErrorMessage = "el numero de carnet es obligatorio")]
     [Range(1, 100000, ErrorMessage = "Por favor, ingrese un valor mayor que cero para Número de Carnet.")]
    public int NumCarnet{set;get;}

    [Required (ErrorMessage ="el nombre es obligatorio")]
    public string Nombre{set;get;}

     [Required (ErrorMessage ="el apellido es obligatorio")]
  public string Apellido{set;get;}

  [Required (ErrorMessage ="la direccion es obligatorio")]
    public string Direccion{set;get;}

    [Required (ErrorMessage ="el nombre de la facultad es obligatorio")]
   public string Facultad{set;get;}

   [Required (ErrorMessage ="el telefono es obligatorio")]
   [Range(1, int.MaxValue, ErrorMessage = "Por favor, ingrese un valor mayor que cero para el numero de telefono.")]
    public int Telefono{set;get;}

    [Required (ErrorMessage ="el correo es obligatorio")]
  public string Correo{set;get;}


 public List<Prestamo> ListaPrestamos{set;get;}=new List<Prestamo>();
   public Persona(){

   }
   
   public Persona(int n, string nom, string ape, string dir, string fa, int tel, string co){
      this.NumCarnet=n;
      this.Nombre=nom;
      this.Apellido=ape;
      this.Direccion=dir;
      this.Facultad=fa;
      this.Telefono=tel;
      this.Correo=co;
   }

}
