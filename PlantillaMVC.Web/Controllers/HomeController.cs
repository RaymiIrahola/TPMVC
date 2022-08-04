using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlantillaMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PlantillaMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult AgregarCartaForm() => View();



        //[HttpPost]
        //public IActionResult AgregarCartaForm(AgregarCarta agregarcarta)
        //{
        //    Repositorio.AgregarCartaNueva(agregarcarta);
        //    return View("Genial", agregarcarta);
        //}

        //[HttpPost]
        //public IActionResult Eliminar(AgregarCarta agregarcarta)
        //{
        //    //var carta = Repositorio.EliminarCarta(AgregarCarta agregarcarta);
        //    //if (carta is null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    Repositorio.EliminarCarta(agregarcarta);
        //    return View("Genial", agregarcarta);
        //}

        //[HttpGet]
        //public IActionResult ModificarCarta()
        //{
        //    var carta = Repositorio.Where(c => c.Nomnre == unNombre);
        //    if (carta is null)
        //    {
        //        return NotFound();
        //    }
        //}

        //public ViewResult CartaCaracteristica() => View(Repositorio.caracteristicaLista);
        public ViewResult ListaCartasRegistradas() => View(Repositorio.CartasRegistradas);

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        //public ViewResult Index() => View("PantallPrincipal");
    }
}
