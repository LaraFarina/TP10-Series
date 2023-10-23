using Microsoft.AspNetCore.Mvc;

namespace TP10-Series.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
// Crear en el controller la acción Index para que cargue las Series de la base de datos en un ViewBag.
// Crear las acciones necesarias en el controller para que sean llamadas desde la View con Ajax.
