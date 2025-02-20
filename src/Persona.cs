
public class Persona {
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public int Edad { get; set; } 
    public string Nacionalidad { get; set; }
    public  double Estatura{ get; set; }
    public int Numero_camisa{get;set;}


    public Persona(string nombres, string apellidos, int edad ,string nacionalidad, double estatura,int numero_camisa) {
    
        Nombres = nombres;
        Apellidos = apellidos;
        Edad=edad;
        Nacionalidad=nacionalidad;
        Estatura=estatura;
        Numero_camisa=numero_camisa;
    }

    public void MostrarInformacion() {
    
        Console.WriteLine($"Nombres: {Nombres}");
        Console.WriteLine($"Apellidos: {Apellidos}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Nacionalidad: {Nacionalidad}");
        Console.WriteLine($"Estatura: {Estatura}");
        Console.WriteLine($"Numero_camisa: {Numero_camisa}");
    }


}