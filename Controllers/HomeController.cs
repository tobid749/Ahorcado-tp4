
using Microsoft.AspNetCore.Mvc;
using Ahorcado.Models;

namespace Ahorcado.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
{
    Juego.inicializarJuego();
    return View("Index");
}

        public IActionResult juego()
        {
             
           
            if (Juego.JuegoFinalizado())
            {
                if (Juego.JugadorGano())
                {
                    ViewBag.Palabra = Juego.ObtenerPalabra();
                    return View("Ganaste");
                }
                else
                {
                    ViewBag.Palabra = Juego.ObtenerPalabra();
                    return View("Perdiste");
                }
            }

            ViewBag.Palabra = Juego.ObtenerProgreso();
            ViewBag.Intentos = Juego.ObtenerIntentos();
            ViewBag.LetrasUsadas = Juego.ObtenerLetrasUsadas();

            return View("Juego");
        }

        [HttpPost]
        public IActionResult tirarLetra(string letra)
        {
                char letrita = letra[0];
                Juego.tirarLetra(letrita);
                 return juego(); 
        }

        [HttpPost]
        public IActionResult tirarPalabra(string palabra)
        {
                Juego.tirarPalabra(palabra);
               return juego();
        }
    }
}