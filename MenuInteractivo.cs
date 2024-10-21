using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace firewall;

public class MenuInteractivo
{
    private List<Firewall> firewalls = new List<Firewall>();

// metodo para selecionar una opcion 
    public void MostrarMenu()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- Sistema de Gestión de Firewalls ---");
            Console.WriteLine("1. Crear Firewall Hardware");
            Console.WriteLine("2. Crear Firewall Software");
            Console.WriteLine("3. Crear Firewall Avanzado");
            Console.WriteLine("4. Crear Firewall Inteligente");
            Console.WriteLine("5. Activar Firewall");
            Console.WriteLine("6. Desactivar Firewall");
            Console.WriteLine("7. Agregar Regla a Firewall");
            Console.WriteLine("8. Mostrar Estado de Firewall");
            Console.WriteLine("9. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CrearFirewallHardware();
                    break;
                case 2:
                    CrearFirewallSoftware();
                    break;
                case 3:
                    CrearFirewallAvanzado();
                    break;
                case 4:
                    CrearFirewallInteligente();
                    break;
                case 5:
                    ActivarFirewall();
                    break;
                case 6:
                    DesactivarFirewall();
                    break;
                case 7:
                    AgregarReglaAFirewall();
                    break;
                case 8:
                    MostrarEstadoFirewall();
                    break;
                case 9:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 9);
    }
// metodo para crear objetos  
    private void CrearFirewallHardware()
    {

        Console.Write("Ingrese el nombre del firewall: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el tipo: ");
        string Tipo = Console.ReadLine();
        Console.Write("Ingrese el modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Ingrese la IP pública: ");
        string ipPublica = Console.ReadLine();
        firewalls.Add(new FirewallHardware(nombre, Tipo, modelo, ipPublica));


    }

    public void CrearFirewallSoftware()
    {
        Console.Write("Ingrese el nombre del firewall: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el tipo: ");
        string Tipo = Console.ReadLine();
        Console.Write("Ingrese la version: ");
        string version = Console.ReadLine();
        Console.Write("Ingrese la licencia: ");
        string licencia = Console.ReadLine();
        firewalls.Add(new FirewallSoftware(nombre, Tipo, version, licencia));
    }

    public void CrearFirewallAvanzado()
    {
        Console.Write("Ingrese el nombre del firewall avanzado: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el tipo: ");
        string Tipo = Console.ReadLine();
        Console.WriteLine("Crear Firewall Hardware para el firewall avanzado.");
        CrearFirewallHardware();

        Console.WriteLine("Crear Firewall Software para el firewall avanzado.");
        CrearFirewallSoftware();

        FirewallHardware hardware = (FirewallHardware)firewalls[firewalls.Count - 2];
        FirewallSoftware software = (FirewallSoftware)firewalls[firewalls.Count - 1];

        Console.Write("Ingrese las tecnologías soportadas: ");
        string tecnologias = Console.ReadLine();

        firewalls.Add(new FirewallAvanzado(nombre, Tipo, hardware, software, tecnologias));
        Console.WriteLine("Firewall Avanzado creado con éxito.");
    }

    public void CrearFirewallInteligente()
    {
        Console.Write("Ingrese el nombre del firewall avanzado: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el tipo: ");
        string Tipo = Console.ReadLine();
        Console.Write("Ingrese el nivel de inteligencia (1-10): ");
        int nivel = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la Log Actividades: ");
        string LogActividades = Console.ReadLine();
        Console.Write("Ingrese la Tecnologias Soportadas: ");
        string TecnologiasSoportadas = Console.ReadLine();
        CrearFirewallAvanzado();
        FirewallAvanzado avanzado = (FirewallAvanzado)firewalls[firewalls.Count - 1];


        firewalls.Add(new FirewallInteligente(nombre, Tipo, nivel, LogActividades, avanzado.GethardwareFirewall(), avanzado.GetsoftwareFirewall(), TecnologiasSoportadas));
        Console.WriteLine("Firewall Inteligente creado con éxito.");
    }
// metodo para buscar 
    private Firewall BuscarFirewall(string nombre)
    {
        return firewalls.Find(f => f.GetNombre() == nombre);
    }
// metodo para activar y desactivar 
    private void ActivarFirewall()
    {
        Console.Write("Ingrese el nombre del firewall a activar: ");
        string nombre = Console.ReadLine();
        Firewall firewall = BuscarFirewall(nombre);
        if (firewall != null)
        {
            firewall.Activar();
        }
        else
        {
            Console.WriteLine("Firewall no encontrado.");
        }
    }

    public void DesactivarFirewall()
    {
        Console.Write("Ingrese el nombre del firewall a desactivar: ");
        string nombre = Console.ReadLine();
        Firewall firewall = BuscarFirewall(nombre);
        if (firewall != null)
        {
            firewall.Desactivar();
        }
        else
        {
            Console.WriteLine("Firewall no encontrado.");
        }
    }
// metodo para agregar reglas 
    private void AgregarReglaAFirewall()
    {
        Console.Write("Ingrese el nombre del firewall al que desea agregar una regla: ");
        string nombre = Console.ReadLine();
        Firewall firewall = BuscarFirewall(nombre);
        if (firewall != null)
        {
            Console.Write("Ingrese la regla a agregar: ");
            string regla = Console.ReadLine();
            firewall.SetReglas(regla);
        }
        else
        {
            Console.WriteLine("Firewall no encontrado.");
        }
    }
// metodo para mostrar todos los objetos 
    public void MostrarEstadoFirewall()
    {
        foreach (var item in firewalls)
        {
            item.MostrarEstado();
        }
    }

}
