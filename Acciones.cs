using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2_parcial
{
    internal class Acciones
    {
        
        
            public List<Videojuego> listavideojuegos = new List<Videojuego>();
            Videojuego a = new Videojuego();

            public void AgregarVideojuego()
            {
                Console.WriteLine("Juego: ");
                a.Juego = Console.ReadLine();
                Console.WriteLine("Consola: ");
                a.Consola = Console.ReadLine();
                Console.WriteLine("Año: ");
                a.Anio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Genero: ");
                a.Genero = Console.ReadLine();
                Console.WriteLine("Creador: ");
                a.Creador = Console.ReadLine();



                listavideojuegos.Add(new Videojuego(a.Juego, a.Consola, a.Anio, a.Genero, a.Creador));
            }
            public void MostrarVideojuego()
            {
                foreach (var e in listavideojuegos)
                {
                    Console.WriteLine($"El videojuego es: {e.Juego} ");
                    Console.WriteLine($"Consola  es: {e.Consola} ");
                    Console.WriteLine($"El anio  es: {e.Anio} ");
                    Console.WriteLine($"El genero es: {e.Genero} ");
                    Console.WriteLine($"El creador  es: {e.Creador} ");

                }
            }
            public int ContarVideojuego()
            {
                return listavideojuegos.Count;
            }
            public void EliminarVideojuego(string nombrejuego)
            {
                var video = listavideojuegos.Find(y => y.Juego == nombrejuego);
                if (video != null)
                   listavideojuegos.Remove(video);
                else
                    Console.WriteLine("no se encontro tu Videojuego.");
            }
            public void ActualizarVideojuego()
            {
                
                Console.Write("Introduce el videojuego actual del que deseas actualizar: ");
                string marcaAntigua = Console.ReadLine();

                var video = listavideojuegos.Find(y => y.Juego == marcaAntigua);

            
                if (video != null)
                {
                    Console.Write("Introduce la nuevo Videojuego: ");
                    string nuevoJuego = Console.ReadLine();

                    Console.Write("Introduce el nueva consola: ");
                    string nuevaConsola = Console.ReadLine();

                    Console.Write("Introduce el nuevo año del videojuego: ");
                    int nuevoAño = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Introduce el nuevo genero: ");
                     string nuevoGenero = Console.ReadLine();

                    Console.Write("Introduce el nuevo Creador: ");
                    string nuevoCreador = Console.ReadLine();
                   
                    video.Juego = nuevoJuego;
                    video.Consola = nuevaConsola;
                    video.Anio = nuevoAño;
                    video.Genero = nuevoGenero;
                    video.Creador = nuevoCreador;

                    Console.WriteLine("Los datos del Videojuego han sido actualizados correctamente.");
                }
                else
                {
                    Console.WriteLine("No se encontró el videojuego con esa juego.");
                }
            }
        
    }
}
