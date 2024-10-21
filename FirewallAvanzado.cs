using System;
namespace firewall;

public class FirewallAvanzado : Firewall
{
    FirewallHardware hardwareFirewall;
    FirewallSoftware softwareFirewall;
    private List<string> TecnologiasSoportadas = new List<string>();
    // constructor 
    public FirewallAvanzado(string Nombre, string Tipo, FirewallHardware hardwareFirewall, FirewallSoftware softwareFirewall, string TecnologiasSoportadas)
    : base(Nombre, Tipo)
    {
        base.SetNombre(Nombre);
        base.SetTipo(Tipo);
        this.hardwareFirewall = hardwareFirewall;
        this.softwareFirewall = softwareFirewall;
        this.TecnologiasSoportadas.Add(TecnologiasSoportadas);

    }
    //metodo para selecionar una opcion 
    public void Tecnologias(string Tecnologias)
    {
        this.TecnologiasSoportadas.Add(Tecnologias);
    }
    //activar 
    public override void Activar()
    {
        this.TecnologiasSoportadas.Add("React");
        Console.WriteLine("El firewall avanzado se ha activado");
        this.hardwareFirewall.Activar();
        this.softwareFirewall.Activar();
        foreach (var item in this.TecnologiasSoportadas)
        {
            Console.WriteLine($"Tecnologias Soportadas: {item}");
        }

    }
    // mostrar la informacion 
    public override void MostrarEstado()
    {
        Console.WriteLine("*********************Tecnologias Soportadas************************");
        this.hardwareFirewall.MostrarEstado();
        this.softwareFirewall.MostrarEstado();

    }
    // metodos set y get 
    public FirewallHardware GethardwareFirewall()
    {
        return this.hardwareFirewall;
    }
    public FirewallHardware SethardwareFirewall(FirewallHardware hardwareFirewall)
    {
        return this.hardwareFirewall = hardwareFirewall;
    }
    public FirewallSoftware GetsoftwareFirewall()
    {
        return this.softwareFirewall;
    }
    public FirewallSoftware SetFirewallSoftware(FirewallSoftware softwareFirewall)
    {
        return this.softwareFirewall = softwareFirewall;
    }
    public List<string> GetTecnologiasSoportadas()
    {
        return this.TecnologiasSoportadas;
    }
    public List<string> SetTecnologiasSoportadas(string TecnologiasSoportadas)
    {
        this.TecnologiasSoportadas.Add(TecnologiasSoportadas);
        return this.TecnologiasSoportadas;
    }


}