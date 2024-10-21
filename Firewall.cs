using System.Dynamic;

namespace firewall;

public class Firewall
{
    // Atributos
    private string Nombre = "";
    private string Tipo = "";
    private bool Estado;
    private List<string> Reglas = new List<string> { };

    // constructor
    public Firewall(string Nombre, string Tipo)
    {
        this.Nombre = Nombre;
        this.Tipo = Tipo;
        this.Estado = false;
        this.Reglas = new List<string> { };
    }
    //Metodo de Activar 
    public virtual void Activar()
    {
        if (this.Estado != false)
        {
            Console.WriteLine("Ya estava Activado");
            this.Estado = true;
        }
        else
        {
            Console.WriteLine("El estado fue Activado");
            this.Estado = true;
        }
    }

    // Metodo de Desactivat 
    public virtual void Desactivar()
    {
        if (this.Estado == true)
        {
            Console.WriteLine("El estado fue Desactivado");
            this.Estado = false;
        }
        else
        {
            Console.WriteLine("Ya esta Desactivado");
            this.Estado = false;
        }
    }

    // Metodo de Mostrar Estado
    public virtual void MostrarEstado()
    {
        Console.WriteLine("********************** Mostrar Estado ****************************");
        Console.WriteLine($"El nombre es: {this.Nombre}");
        Console.WriteLine($"El tipo es {this.Tipo}");
        if (this.Estado == true)
        {
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

    }

    // Metodos Set y Get

    public string GetNombre()
    {
        return this.Nombre;
    }
    public string GetTipo()
    {
        return this.Tipo;
    }
    public bool GetEstado()
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
