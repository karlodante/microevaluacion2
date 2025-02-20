public class Torneo_internacional : EquipoFutbol
 {
    
    public string Nombre_torneo { get; set; }
    public int Fase_actual { get; set; }
    
    public Torneo_internacional(string nombreEquipo, string ciudad, string estadio, DateTime fundacion, string nombre_torneo,int fase_actual) : base(nombreEquipo, ciudad,  estadio, fundacion) {
    
        Nombre_torneo=nombre_torneo;
        Fase_actual=fase_actual;
    }
    
    public new void MostrarInformacion() {
    
        base.MostrarInformacion();
        Console.WriteLine($"Nombre_torneo {Nombre_torneo}");
        Console.WriteLine($"Fase_actual{Fase_actual}");

    }
}