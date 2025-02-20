public class Cuerpo_tecnico : Persona
{
    public string Rol { get; set; }
    public string Experiencia { get; set; }
    

    public Cuerpo_tecnico( string nombres, string apellidos, int edad, string nacionalidad, double estatura, int numero_camisa, string rol ,string experiencia): base (nombres, apellidos, edad, nacionalidad, estatura, numero_camisa)  {
       
        Rol=rol;
        Experiencia=experiencia;
  
    }

    public new void MostrarInformacion() {
        
        base.MostrarInformacion();
        
        Console.WriteLine($"Rol: {Rol}");
        
        Console.WriteLine($"Experiencia:{Experiencia}");
        
        



    }
}    