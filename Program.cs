using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    public static void Main(string[] args)  
    {
        /*Firewall firewall= new Firewall("emilio","lic",false, "nonoino");
        firewall.Activar(true);
        //firewall.MostrarEstado();
        firewall.AgregarRegla("todos deven comer");
        firewall.AgregarRegla("todos no deven comer");
        firewall.MostrarEstado();
        firewall.Desactivar(true);
        firewall.AgregarRegla("honrar a papa y mama");
        firewall.MostrarEstado();*/
        FirewallHardware firewallHardware= new FirewallHardware("emilio","lic",true, "nonoino", "tollots","123121352564");
        firewallHardware.MostrarEstado();
        firewallHardware.Activar(true);
        firewallHardware.Activar();
        firewallHardware.MostrarEstado();

    }
}

