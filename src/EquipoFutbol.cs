public class EquipoFutbol {

    public string NombreEquipo { get; set; }
    public string Ciudad { get; set; }
    public string Estadio { get; set; }
    public DateTime Fundacion { get; set; }

    public EquipoFutbol(string nombreEquipo, string ciudad, string estadio, DateTime fundacion) {
         
         NombreEquipo = nombreEquipo;
         Ciudad=  ciudad;
         Estadio = estadio;
         Fundacion = fundacion;

    }

    public void MostrarInformacion() {
        
        Console.WriteLine($"Nombre Equipo: {NombreEquipo}");
        Console.WriteLine($"Ciudad: {Ciudad}");
        Console.WriteLine($"Estadio: {Estadio}");
        Console.WriteLine($"Fundacion: {Fundacion}");
    }
}