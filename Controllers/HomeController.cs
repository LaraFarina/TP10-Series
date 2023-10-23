using Microsoft.AspNetCore.Mvc;

namespace TP10Series.Controllers;

using TP10Series.Models;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Series = BD.ObtenerSeries();
        return View();
    }

    public List<Temporadas> VerTemporadas(int IdSerie){
return BD.ObtenerTemporadasPorSerie(IdSerie);
    }
        public List<Actores> VerActores(int IdSerie){
return BD.ObtenerActoresPorSerie(IdSerie);
    }
 

}
// Crear en el controller la acción Index para que cargue las Series de la base de datos en un ViewBag.

// Crear las acciones necesarias en el controller para que sean llamadas desde la View con Ajax.
