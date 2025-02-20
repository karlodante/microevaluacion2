public class Liga_boliviana : EquipoFutbol 
{
    
    public string Torneo_actual { get; set; }
    public int Posicion { get; set; }
   
    public Liga_boliviana(string nombreEquipo, string ciudad, string estadio, DateTime fundacion,string torneo_actual,int posicion) : base(nombreEquipo, ciudad,  estadio, fundacion) {
        
        Torneo_actual = torneo_actual;
        Posicion=posicion;
    }
    public new void MostrarInformacion() {
        
        base.MostrarInformacion();
        Console.WriteLine($"Torneo_actual {Torneo_actual}");
        Console.WriteLine($"Posicion {Posicion}");

    }
}