using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TP05_SCHNAIDER.Models;

namespace TP05_SCHNAIDER.Controllers{
public class HomeController : Controller
{
    public IActionResult Index(){
        return View();
    }
    public IActionResult Historia(){
        return View();
    }
    public IActionResult Creditos(){
        return View();
    }
    [HttpGet]    
    public IActionResult Iniciar()
    {   
        return View();
    }
    [HttpPost
    ] 
    public IActionResult Iniciar(string nombre)
    {   
        if (nombre == null){
            return View ("Index");
        }
        ControladorJuego juego = new ControladorJuego(nombre);
        HttpContext.Session.SetString("juego", Objeto.ObjectToString(juego));
        return View("Sala1");
    }

    public IActionResult Salas(string codigo)
    {
        string siguiente = null;
        string error = "";
        ControladorJuego juego = Objeto.StringToObject<ControladorJuego>(HttpContext.Session.GetString("juego"));
        if(juego.ValidarCodigo(codigo)){
            juego.jugador.AvanzarSala();
            siguiente = "Sala" + juego.jugador.SalaActual;
        }
        else{
           juego.jugador.IncrementarErrores();
            error = "Codigo incorrecto, intente nuevamente";
            siguiente = "Sala" + juego.jugador.SalaActual;
            }
        if (juego.jugador.IntentosFallidos >= 10)
            {
              
             siguiente = "FinalMalo";
            }
        if (juego.jugador.SalaActual == 5)
        {
            siguiente = "FinalBueno";
        }
        ViewBag.Error = error;
        return View(siguiente);
        }
    }
}
