namespace Ahorcado.Models
{
    public static class Juego
    {
        public static string palabra;
        public static int intentos;
        public static List<char> letrasUsadas;
        private static List<char> progreso;
        private static bool juegoFinalizado;

        static Juego()
        {
            reiniciar();
        }

        public static void reiniciar()
        {
            palabra = "ESDRUJULA";
            progreso = palabra.Select(c => '_').ToList();
            letrasUsadas = new List<char>();
            intentos = 0;
            juegoFinalizado = false;
        }
    }
}
  

    

