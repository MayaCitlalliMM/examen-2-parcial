using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2_parcial
{
    internal class Program
    {
        public enum Menu
        {
            Agregarvideojuego = 1, Mostrarvideojuego, Contarvideojuego, Eliminarvideojuego, Actualizarvideojuego
        }
        static void Main(string[] args)
        {
            Acciones video = new Acciones();

            while (true)
            {
                switch(menu())
                {
                    case Menu.Agregarvideojuego:
                        video.AgregarVideojuego();
                        break;
                    case Menu.Mostrarvideojuego:
                        video.MostrarVideojuego();
                        break;
                    case Menu.Contarvideojuego:
                        Console.WriteLine($"el resultado es:{video.ContarVideojuego()}");
                        break;
                    case Menu.Eliminarvideojuego:
                        Console.WriteLine("Que Videojuego quieres eliminar:");
                        string juego = Console.ReadLine();
                        video.EliminarVideojuego(juego);
                        break;
                    case Menu.Actualizarvideojuego:
                        video.ActualizarVideojuego();
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;

                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("1) Agregar Videojuego");
            Console.WriteLine("2) Mostrar Videojuego");
            Console.WriteLine("3) Contar Videojuego");
            Console.WriteLine("4) Eliminar Videojuego");
            Console.WriteLine("5) Actualizar Videojuego");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
