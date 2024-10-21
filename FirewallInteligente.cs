using System.Dynamic;

namespace firewall;

public class FirewallInteligente : FirewallAvanzado
{
    private int NivelDeInteligencia { get; set; }
    private List<string> LogActividades = new List<string>() { };
  
    // contructur 
    public FirewallInteligente(string Nombre, string Tipo, int NivelDeInteligencia, string LogActividades, 
    FirewallHardware har, FirewallSoftware sof, string TecnologiasSoportadas)
     : base(Nombre, Tipo, har, sof, TecnologiasSoportadas)
    {
        base.SetNombre(Nombre);
        base.SetTipo(Tipo);
        this.NivelDeInteligencia = NivelDeInteligencia;
        this.LogActividades.Add(LogActividades);
        base.SetTecnologiasSoportadas(TecnologiasSoportadas);
    }

    // Sobrecarga de metodos
    public override void Activar()
    {
        base.Activar();
        Console.WriteLine("Detectar comportamientos anomalos (escala de 1 a 10)");
        Console.WriteLine($"Firewall Inteligente activado. Nivel de inteligencia: {this.NivelDeInteligencia}");

    }

    public override void MostrarEstado()
    {
        this.LogActividades.Add("Tareas para Realisar ");
        base.MostrarEstado();
        Console.WriteLine("********************** Firewall Inteligente ****************************");
        Console.WriteLine($"Nivel de inteligencia: {this.NivelDeInteligencia},  Log Actividades: {string.Join(",", LogActividades)}");
        AnalizarTrafico();

    }
    // metodo propio de la clase 
    public void AnalizarTrafico()
    {
        Console.WriteLine("Analizando tráfico en busca de comportamientos anómalos...");
        LogActividades.Add("Análisis de tráfico ejecutado.");
    }
    // metodos set y get
    public int GetNivelDeInteligencia()
    {
        return this.NivelDeInteligencia;
    }
    public int SetNivelDeInteligencia(int NivelDeInteligencia)
    {
        return this.NivelDeInteligencia = NivelDeInteligencia;
    }

    public List<string> GetLogActividades()
    {
        return this.LogActividades;
    }
    public List<string> SetLogActividades(List<string> LogActividades)
    {
        return this.LogActividades = LogActividades;
    }

}
