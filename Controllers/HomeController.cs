using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP10.Models;

namespace TP10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

   public IActionResult Index()
    {   
        ViewBag.Series = BD.ObtenerSeriesFull();
        return View();
    }
    [HttpPost] public List<Temporadas> cargarTemporadas(int IdSerie)
    {
        List<Temporadas> listaTemporadas= BD.ObtenerTemporadas(IdSerie);
        return listaTemporadas;
    }
    [HttpPost] public List<Actores> cargarActores(int IdSerie)
    {
        List<Actores> listaActores = BD.ObtenerActores(IdSerie);
        return listaActores;
    }
    [HttpPost] public Series VerDetalleSerie(int IdSerie)
    {
        Series unaSerie = BD.obtenerSeries(IdSerie);
        return unaSerie;
    }
}
