using Microsoft.AspNetCore.Mvc;
using TP05-SCHNAIDER.Models;
using Newtonsoft.Json;

public class HomeController : Controller
{
    private Jugador ObtenerJugador()
    {
        string json = HttpContext.Session.GetString("jugador");
        if (string.IsNullOrEmpty(json)) return null;
        return JsonSerializer.Deserialize<Jugador>(json);
    }

    private void GuardarJugador(Jugador jugador)
    {
        string json = JsonSerializer.Serialize(jugador);
        HttpContext.Session.SetString("jugador", json);
    }

    public IActionResult Index(){
        View();
    }
    public IActionResult Historia(){
        View();
    }
    public IActionResult Creditos(){
        View();
    }
    [HttpGet]
    public IActionResult Iniciar(){
        View();
    }
    [HttpPost]
    public IActionResult Iniciar(string nombre)
    {
        Jugador jugador = new Jugador(nombre);
        GuardarJugador(jugador);
        return RedirectToAction("Sala", new { id = 1 });
    }

    [HttpGet]
    public IActionResult Sala(int id)
    {
        Jugador jugador = ObtenerJugador();
        if (jugador == null || jugador.SalaActual < id)
        {
            return RedirectToAction("Index");
        }
        return View("Sala" + id);
    }

    [HttpPost]
    public IActionResult ResolverSala(int id, string codigo)
    {
        Jugador jugador = ObtenerJugador();
        if (jugador == null) return RedirectToAction("Index");

        if (ControladorJuego.ValidarCodigo(codigo, id))
        {
            if (id == 2) jugador.ObtenerLlave();
            if (id == 4) jugador.TerminarJuego();
            jugador.AvanzarSala();
            GuardarJugador(jugador);
            return RedirectToAction("Sala", new { id = jugador.SalaActual });
        }
        else
        {
            jugador.IncrementarErrores();
            if (id == 4 && jugador.IntentosFallidos >= 3)
            {
                jugador.TerminarJuego();
                GuardarJugador(jugador);
                return RedirectToAction("FinalMalo");
            }
            GuardarJugador(jugador);
            ViewBag.Error = "Código incorrecto. Intentá nuevamente.";
            return View("Sala" + id);
        }
    }

    public IActionResult FinalBueno(){
        View();
    }
    public IActionResult FinalMalo(){
        View();
    }
}