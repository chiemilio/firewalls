using System;
using System.Collections.Generic;
using System.Diagnostics;


    public class FirewallHardware : Firewall
    {
        // Atributos Adicionales
        private string Modelo;
        private string IPPublica;
        // Constructor
        public FirewallHardware(string Nombre,string Tipo,bool Estado,string Reglas,string Modelo,string IPPublica)
        : base(Nombre,Tipo,Estado,Reglas) 
        {
            this.Modelo = Modelo;
            this.IPPublica = IPPublica;
        }
        // Sobrecarga de motodos 
        public void Activar(){
            if(this.GetEstado() == true)
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


    public void MostrarEstado()
    {
    Console.WriteLine("********************** Mostrar Estado ****************************");
    Console.WriteLine($"El nombre del Modelo es: {this.Modelo}");
    Console.WriteLine($"La Ip Publica es {this.IPPublica}");
    foreach (var item in GetReglas())
     {
        Console.WriteLine($"Regla: '{item}'");       
     }
    
    Console.WriteLine("*****************************************************************");
    }        

    
    }
