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
    public class CartaController : Controller
    {
        public IActionResult Index()
        {
            return View(Repositorio.CartasRegistradas);
        }


        [HttpGet]
        public IActionResult FormAlta() => View();

        [HttpPost]
        public IActionResult FormAlta(Carta carta)
        {
            Repositorio.AgregarCartaNueva(carta);
            return View("Index", Repositorio.CartasRegistradas);
        }
        //public ViewResult ListaCartasRegistradas() => View(Repositorio.CartasRegistradas);

        [HttpGet]
        public IActionResult Eliminar() => View();

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var cartaid = Repositorio.GetCarta(id);
            if (cartaid is null)
            {
                return NotFound();
            }
            Repositorio.EliminarCarta(cartaid);
            return View("Index", Repositorio.CartasRegistradas);
        }

        [HttpGet]
        public IActionResult Modificar(int id)
        {
            var cartaid = Repositorio.GetCarta(id);
            if (cartaid is null)
            {
                return NotFound();
            }
            return View(cartaid);
        }

        [HttpPost]
        public IActionResult Modificar(Carta carta)
        {
            Repositorio.ActualizarCarta(carta);
            return View("Index", Repositorio.CartasRegistradas);
        }

        [HttpGet]
        public IActionResult CaracteristicaCarta(int id)
        {
            var caract = Repositorio.GetCarta(id);
            
            return View(caract );

        }

        //[HttpGet]
        //public IActionResult CaracteristicaCarta(int id)
        //{
        //    var cartaId = Repositorio.GetCarta(id);
        //    if (cartaId is null)
        //    {
        //        return NotFound();
        //    }
        //    return View(cartaId);
        //}

        //public ViewResult CartaCaracteristica() => View(Repositorio.carac.caracteristicaLista);
    }

    
}
