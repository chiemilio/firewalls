
using System;

namespace firewall;
public class FirewallSoftware : Firewall
{
    // Atributos Adicionales
    private string Version { get; set; }
    private string Licencia { get; set; }
    public FirewallSoftware(string Nombre, string Tipo, string version, string licencia) : base(Nombre, Tipo)
    {
        base.SetNombre(Nombre);
        base.SetTipo(Tipo);
        this.Version = version;
        this.Licencia = licencia;
    }

    // Métodos Sobrecargados

    public override void Activar()
    {
        base.Activar();
        if (base.GetEstado() == true)
        {

            Console.WriteLine($"La version es: {this.Version}");
            Console.WriteLine($"La licencia es: {this.Licencia}");
        }
        else
        {
            Console.WriteLine($"La version ya espiro: {this.Version}");
            Console.WriteLine($"La licencia ya espiro: {this.Licencia}");
        }
    }
    public override void MostrarEstado()
    {
        base.MostrarEstado();
        Console.WriteLine("********************** Firewall Software ****************************");
        Console.WriteLine($"El nombre es: {GetNombre()}");
        Console.WriteLine($"El tipo es {GetTipo()}");
        if (GetEstado() == true)
        {

            Console.WriteLine("El estado es: Activado");
            Console.WriteLine($"La version es: {this.Version}");
            Console.WriteLine($"La licencia es: {this.Licencia}");
        }
        else
        {
            Console.WriteLine("El estado es: Desactivado");
            Console.WriteLine($"La version ya espiro: {this.Version}");
            Console.WriteLine($"La licencia ya espiro: {this.Licencia}");
        }

        foreach (var item in GetReglas())
        {
            Console.WriteLine($"Regla: '{item}'");
        }

    }

    public string GetVersion()
    {
        return this.Version;
    }
    public string SetVersion(string version)
    {
        return this.Version = version;
    }
    public string GetLicencia()
    {
        return this.Licencia;
    }
    public string SetLicencia(string licencia)
    {
        return this.Licencia = licencia;
    }

}
