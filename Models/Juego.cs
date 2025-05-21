

using System.Collections.Generic;
using System.Linq;

namespace Ahorcado.Models
{
    public static class Juego
    {
        public static string palabra;
        public static int intentos;
        public static List<char> letrasUsadas;
        private static char[] progreso;
        private static bool juegoFinalizado;
        private static bool jugadorGano;

        

        public static void tirarLetra(char letra)
        {
            if (juegoFinalizado || letrasUsadas.Contains(letra))
                return;

            letrasUsadas.Add(letra);

            if (palabra.Contains(letra))
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (palabra[i] == letra)
                    {
                        progreso[i] = letra;
                    }
                }

                if (!progreso.Contains('_'))
                {
                    juegoFinalizado = true;
                    jugadorGano = true;
                }
            }
            else
            {
                intentos++; 
            }
        }
           public static void inicializarJuego(){
            palabra = "jazz";
            intentos = 0;
            letrasUsadas = new List<char>();
            progreso = palabra.Select(c => '_').ToArray();//nos dijo angie que lo busquemos en google
            juegoFinalizado = false;
            jugadorGano = false;
        }

        public static void tirarPalabra(string palabraArriesgada)
        {
            if (juegoFinalizado)
            {
                return;
}
            if (palabraArriesgada == palabra)
            {
                for (int i = 0; i < palabra.Length; i++)
                    progreso[i] = palabra[i];

                juegoFinalizado = true;
                jugadorGano = true;
            }
            else
            {
                juegoFinalizado = true;
                jugadorGano = false;
            }
        }
        public static string ObtenerProgreso()
        {
            string palabra="";
            for (int i = 0; i < progreso.Length; i++)
            {
               palabra+= progreso[i] +" ";
            }
            return palabra;
        }

        public static List<char> ObtenerLetrasUsadas()
        {
            return letrasUsadas;
        }

        public static int ObtenerIntentos()
        {
            return intentos;
        }

        public static bool JuegoFinalizado()
        {
            return juegoFinalizado;
        }

        public static bool JugadorGano()
        {
            return jugadorGano;
        }

        public static string ObtenerPalabra()
        {
            return palabra;
        }
     
    }
}
