public class Patrocinador {
    public string Nombre { get; set; }
    public string Tipo { get; set; } 
    public double AporteAnual { get; set; }

    public Patrocinador(string nombre, string tipo, double aporteAnual) {
        Nombre = nombre;
        Tipo = tipo;
        AporteAnual = aporteAnual;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre:{Nombre}");
        Console.WriteLine($"Tipo :{Tipo}");
        Console.WriteLine($"AporteAnual:{AporteAnual}");
    }

}
