
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public class Firewall {
    // Atributos
   private string Nombre;
   private string Tipo;
   private  bool Estado;
   private List <string> Reglas = new List<string>{};
   
   // constructor
   public Firewall(string Nombre, string Tipo,bool Estado,string Reglas)
   {
    this.Nombre = Nombre;
    this.Tipo = Tipo;   
    this.Estado = Estado;
    this.Reglas.Add(Reglas);
   }
    //Metodo de Activar 
   public void Activar(bool estado) 
   {
    if (Estado == false)
    {
        Console.WriteLine("El estado fue Activado");
        this.Estado = true;
    }
    else
    {
        Console.WriteLine("Ya estava Activado");        
        this.Estado = estado;
    }
   }

   // Metodo de Desactivat 
   public void Desactivar(bool estado)
   {
    if (Estado == true){
         Console.WriteLine("El estado fue Desactivado");
         this.Estado = false;
    }
    else
    {
        Console.WriteLine("Ya esta Desactivado");
        this.Estado = estado;
    }
   }
    // Metodo de Agregar Regla
   public string AgregarRegla(string regla)
   {
     this.Reglas.Add(regla);
     return regla;
   }

   // Metodo de Mostrar Estado
   public void MostrarEstado()
   {
    Console.WriteLine("********************** Mostrar Estado ****************************");
    Console.WriteLine($"El nombre es: {this.Nombre}");
    Console.WriteLine($"El tipo es {this.Tipo}");
    if (this.Estado == true){
        Console.WriteLine("El estado es: Activado");
    }
    else
    {
        Console.WriteLine("El estado es: Desactivado");
    }
    foreach (var item in this.Reglas)
     {
        Console.WriteLine($"Regla: '{item}'");       
     }
    Console.WriteLine("*****************************************************************");
   }
   
   // Metodos Set y Get

   public string GetNombre(){
    return this.Nombre;
   }
   public string GetTipo(){
    return this.Tipo;
   }
   public  bool GetEstado()
   {
    return this.Estado;
   }
   public List<string> GetReglas()
   {
    return this.Reglas;
   }


    public string SetNombre(string nombre)
    {
        return this.Nombre = nombre;
    }
    public string SetTipo(string tipo)
    {
        return this.Tipo = tipo;
    }
   public bool SetEstado(bool val)
   {
        return this.Estado = val;
   }
   public List<string> SetReglas(string reglas)
   {
    this.Reglas.Add(reglas);
    return this.Reglas;
   }

}