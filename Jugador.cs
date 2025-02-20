public class Jugador : Persona
{
    public string Posicion { get; set; }
    public int Goles { get; set; }
    public int Asistencias { get; set; }
   

    public Jugador(string nombres, string apellidos, int edad ,string nacionalidad, double estatura,int numero_camisa, string posicion, int goles, int asistencias): base(nombres, apellidos, edad, nacionalidad, estatura, numero_camisa ) {
        Posicion = posicion;
        Goles = goles;
        Asistencias = asistencias;
   
    }

    public new void MostrarInformacion() {
        base.MostrarInformacion();
        Console.WriteLine($"Posicion: {Posicion}");
        Console.WriteLine($"Goles: {Goles}");
        Console.WriteLine($"Asistencias: {Asistencias}");
     
    }
}