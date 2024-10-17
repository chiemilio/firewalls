namespace firewalls;
using System;
public class FirewallSoftware : Firewall
{
    // Atributos Adicionales
    private string Version { get; set; }
    private string Licencia{ get; set; }
    public FirewallSoftware(string Nombre, string Tipo, bool Estado, string Reglas, string version,string licencia):base(Nombre, Tipo, Estado, Reglas)
    {
        this.Version = version;
        this.Licencia=licencia;
    }

    // Métodos Sobrecargados

    public void Activar()
    {
        if (GetEstado() == true)
        {
            Console.WriteLine($"La version es: {this.Version}");
            Console.WriteLine($"La licencia es: {this.Licencia }");
        }
        else
        {
            Console.WriteLine($"La version ya espiro: {this.Version}");
            Console.WriteLine($"La licencia ya espiro: {this.Licencia }");
        }
    }
    public void MostrarEstado()
    {
    }


}
