using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace firewall;
public class FirewallHardware : Firewall
{
    // Atributos Adicionales
    private string Modelo ="";
    private string IPPublica;

    // Constructor

    public FirewallHardware(string Nombre, string Tipo, string Modelo, string IPPublica)
    : base(Nombre, Tipo)
    {
        base.SetNombre(Nombre);
        base.SetTipo(Tipo);
        this.Modelo = Modelo;
        this.IPPublica = IPPublica;
    }
    // Sobrecarga de motodos 
    public override void Activar()
    {
        base.Activar();
        if (this.GetEstado() == true)
        {
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"IP Publica: {this.IPPublica}");
        }
        else
        {
            Console.WriteLine($"Modelo no Activado: {this.Modelo}");
            Console.WriteLine($"IP Publica no Activado: {this.IPPublica}");
        }
    }
    // mostrar la informacion

    public override void MostrarEstado()
    {
        base.MostrarEstado();
        Console.WriteLine("********************** Firewall Hardware ****************************");
        Console.WriteLine($"El nombre es: {GetNombre()}");
        Console.WriteLine($"El tipo es {GetTipo()}");
        if (GetEstado() == true)
        {            
            Console.WriteLine("El estado es: Activado");
            Console.WriteLine($"El Modelo es: {this.Modelo}");
            Console.WriteLine($"La Ip publica es: {this.IPPublica}");
        }
        else
        {
            Console.WriteLine("El estado es: Desactivado");
            Console.WriteLine($"El modelo no activado: {this.Modelo}");
            Console.WriteLine($"La Ip es: {this.IPPublica}");
        }

        foreach (var item in GetReglas())
        {
            Console.WriteLine($"Regla: '{item}'");
        }

    }

    // metodos set y get 
    public string GetModelo()
    {
        return this.Modelo;
    }
    public string SetModelo(string Modelo)
    {
        return this.Modelo = Modelo;
    }
    public string GetIPPublica()
    {
        return this.IPPublica;
    }
    public string SetIPPublica(string IPPublica)
    {
        return this.IPPublica = IPPublica;
    }

}