using System;

class Program
{
    static void Main()   {
        
        Console.WriteLine("--------DATOS IMPORTANTES DEL BOLIVAR---------");
        Liga_boliviana objLiga_boliviana = new Liga_boliviana("Bolivar","La Paz", "Hernando Siles", new DateTime(1925,04,12),"Torneo Apertura 2025", 1);
        objLiga_boliviana.MostrarInformacion();
        Console.WriteLine("--------");

        EquipoFutbol objEquipoFutbol1= new EquipoFutbol("Bolivar", "La Paz", "Hernando Siles", new DateTime(1925,04,12));
        objEquipoFutbol1.MostrarInformacion();

        Console.WriteLine("--------CUERPO TECNICO DEL BOLIVAR--------");

        Cuerpo_tecnico objCuerpo_tecnico = new Cuerpo_tecnico("Flavio","Robatto" , 46, "Argentina", 1.73,0,"Director tecnico" ,"Demaciada" );
        objCuerpo_tecnico.MostrarInformacion();
        Console.WriteLine("--------");
        
        Cuerpo_tecnico objCuerpo_tecnico2 = new Cuerpo_tecnico("Sandro","Dominguez" , 43, "Boliviana", 1.75,0,"Asitencia tecnica" ,"Mucha" );
        objCuerpo_tecnico2.MostrarInformacion();
        Console.WriteLine("--------");

        Cuerpo_tecnico objCuerpo_tecnico3 = new Cuerpo_tecnico("Luis","Nasisi" , 34, "Boliviana", 1.76,0,"Preparador fisico" ,"Mucha" );
        objCuerpo_tecnico3.MostrarInformacion();
        Console.WriteLine("--------");
      
        Cuerpo_tecnico objCuerpo_tecnico4 = new Cuerpo_tecnico("Gabriel","Gonzales" , 25, "Boliviana", 1.74,0,"Analista de video" ,"Demaciada " );
        objCuerpo_tecnico4.MostrarInformacion();
        Console.WriteLine("--------");

        Cuerpo_tecnico objCuerpo_tecnico5 = new Cuerpo_tecnico("Guillermo","Aponte" , 52, "Boliviana", 1.76,0,"Medico" ,"Demaciada" );
        objCuerpo_tecnico5.MostrarInformacion();
        Console.WriteLine("--------");

        Cuerpo_tecnico objCuerpo_tecnico6 = new Cuerpo_tecnico("Gonzalo ","Salas" , 34, "Boliviana", 1.78,0,"Kinesiologo" ,"Demaciada" );
        objCuerpo_tecnico6.MostrarInformacion();
        Console.WriteLine("--------");

        Cuerpo_tecnico objCuerpo_tecnico7 = new Cuerpo_tecnico("Carlos","Villarroel" , 36, "Boliviana", 1.77,0,"Nutricionista" ,"Mucha" );
        objCuerpo_tecnico7.MostrarInformacion();

        Console.WriteLine("--------EQUIPO DE JUGADORES DEL BOLIVAR--------");
        Jugador objJugador1 = new Jugador("Carlos", "Lampe", 37, "Bolvia", 1.95, 1, "Portero", 10, 15);
        objJugador1.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador2 = new Jugador("Yomar", "Rocha", 29, "Bolvia", 1.82, 22, "Defensa", 7, 10);
        objJugador2.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador3 = new Jugador("Miguel", "Torren", 29, "Bolvia", 1.81, 3, "Defensa", 5, 10);
        objJugador3.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador4 = new Jugador("Deybi", "Choque", 18, "Bolvia", 1.79, 31, "Mediocampo", 3, 3);
        objJugador4.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador5 = new Jugador("Henry", "Vaca", 27, "Bolvia", 177, 27, "Mediocampo", 30, 20);
        objJugador5.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador6 = new Jugador("Ramiro", "Vaca", 25, "Bolvia", 175, 25, "Mediocampo", 14, 19);
        objJugador6.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador7 = new Jugador("Ervin", "Vaca", 28, "Bolvia", 172, 35, "Mediocampo", 11, 16);
        objJugador7.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador8 = new Jugador("Dorny", "Romero", 27, "Bolvia", 183, 77, "Mediocampo", 21, 21);
        objJugador8.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador9 = new Jugador("Bruno", "Menzdez", 18, "Bolvia", 193, 90, "Delantero", 3, 5);
        objJugador9.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador10 = new Jugador("Dilan", "Ali", 20, "Bolvia", 187, 37, "Delantero", 1, 2);
        objJugador10.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador11 = new Jugador("Jesus", "Velasquez", 18, "Bolvia", 185, 29, "Delantero", 1, 3);
        objJugador11.MostrarInformacion();
        Console.WriteLine("--------");

        Jugador objJugador12 = new Jugador("Patricio", "Rodriguez", 34, "Bolvia", 179, 17, "Delantero", 16, 10);
        objJugador12.MostrarInformacion();

        Console.WriteLine("--------TORNEOS DEL BOLIVAR--------");

        Torneo_internacional objTorneo_internacional = new Torneo_internacional("Bolivar","La Paz", "Hernando Siles", new DateTime(1925,04,12),"Primera Divicion de Bolivia", 33);
        objTorneo_internacional.MostrarInformacion();
        Console.WriteLine("--------");
        
        Torneo_internacional objTorneo_internacional2 = new Torneo_internacional("Bolivar","La Paz", "Hernando Siles", new DateTime(1925,04,12),"Copa libertadores", 28);
        objTorneo_internacional2.MostrarInformacion();
        Console.WriteLine("--------");

        Torneo_internacional objTorneo_internacional3 = new Torneo_internacional("Bolivar","La Paz", "Hernando Siles", new DateTime(1925,04,12),"Copas sudamaricanas", 6);
        objTorneo_internacional3.MostrarInformacion();
        Console.WriteLine("--------");

        Torneo_internacional objTorneo_internacional4 = new Torneo_internacional("Bolivar","La Paz", "Hernando Siles", new DateTime(1925,04,12),"Conmebol", 1);
        objTorneo_internacional4.MostrarInformacion();
        Console.WriteLine("--------");
    
        Console.WriteLine("--------PATROCINADORES DEL BOLIVAR--------");

        Patrocinador objPatrocinador = new Patrocinador("Suzuki", "Automotriz",40.000);
        objPatrocinador.MostrarInformacion();
        Console.WriteLine("--------");

        Patrocinador objPatrocinador2 = new Patrocinador("Honor", "Tegnologia",37.500);
        objPatrocinador2.MostrarInformacion();
        Console.WriteLine("--------");

        Patrocinador objPatrocinador3 = new Patrocinador("Ketal", "Supermercado",24.000);
        objPatrocinador3.MostrarInformacion();

       Console.WriteLine("--------Gracias por leer la presentacion--------");
       Console.WriteLine("--------hecho por Karlo Pacheco y Javier Romero--------");


        
    }
}