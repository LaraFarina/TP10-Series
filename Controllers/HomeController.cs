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

    public List<Temporadas> VerTemporadas(int idS){
return BD.ObtenerTemporadasPorSerie(idS);
    }
        public List<Actores> VerActores(int idS){
return BD.ObtenerActoresPorSerie(idS);
    }
 public string Verinfo(int idS){
    return BD.ObtenerSinopsisPorSerie(idS);
 }

}
// Crear en el controller la acción Index para que cargue las Series de la base de datos en un ViewBag.

// Crear las acciones necesarias en el controller para que sean llamadas desde la View con Ajax.
