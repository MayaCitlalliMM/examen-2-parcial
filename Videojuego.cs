using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2_parcial
{
    internal class Videojuego
    {
        public Videojuego() { }

        public Videojuego(string juego, string consola, int anio, string genero, string creador)
        {
            Juego = juego;
            Consola = consola;
            Anio = anio;
            Genero = genero;
            Creador = creador;
        }

        public string Juego {  get; set; }
        public string Consola { get; set; }
        public int Anio { get; set; }
        public string Genero {  get; set; }
        public string Creador {  get; set; }
    }
}
