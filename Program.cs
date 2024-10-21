using System;
using System.Collections.Generic;
using System.Linq;
using firewall;


class Program
{
    //
    public static void Main(string[] args)
    {
        /*
        Firewall firewall= new Firewall("emilio","lic");
        firewall.Activar();
        firewall.MostrarEstado();
        firewall.AgregarRegla("todos deven comer");
        firewall.AgregarRegla("todos no deven comer");
        firewall.MostrarEstado();
        firewall.Desactivar();
        firewall.AgregarRegla("honrar a papa y mama");
        firewall.MostrarEstado();
        firewall.SetReglas("todos deven comer");
        firewall.SetReglas("todos no deven comer");
        */

        //FirewallHardware firewallHardware = new FirewallHardware("luna", "Hardware", "tollots", "mifd352156465");
        /*firewallHardware.MostrarEstado();
        firewallHardware.Activar();
        firewallHardware.MostrarEstado();
        firewallHardware.Desactivar();
        firewallHardware.MostrarEstado();
        */

        /*
        FirewallSoftware firewallSoftware = new FirewallSoftware("luna", "Software", "1.5", "limitada");
        firewallSoftware.Activar();
        firewallSoftware.MostrarEstado();
        */

        /*
        FirewallAvanzado Hardware = new FirewallAvanzado(firewallHardware.GetNombre(), firewallHardware.GetTipo(), firewallHardware, firewallSoftware, "Tecnologia");
        FirewallAvanzado Software = new FirewallAvanzado(firewallHardware.GetNombre(), firewallHardware.GetTipo(), firewallHardware, firewallSoftware, "Tecnologia");
        Hardware.MostrarEstado();
        Software.MostrarEstado();
        Hardware.Activar();
        Hardware.MostrarEstado();
        Software.Activar();
        Software.MostrarEstado();
        */
        /*
        FirewallInteligente firewallInteligente= new FirewallInteligente( firewallHardware.GetNombre(), firewallHardware.GetTipo(),5, " Log Actividade", firewallHardware , firewallSoftware , " TecnologiasSoportadas");
        firewallInteligente.Activar();
        firewallInteligente.MostrarEstado();
        */

        MenuInteractivo menuInteractivo= new MenuInteractivo();
        menuInteractivo.MostrarMenu();

    }
}
