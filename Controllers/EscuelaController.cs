using System;
using asp_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_mvc.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.AñoDeCreación=2005;
            escuela.UniqueId=Guid.NewGuid().ToString();
            escuela.Nombre="Platzi School";
            escuela.Dirección="En algun lugar del mundo";
            escuela.Pais="Colombia";
            escuela.Ciudad="Bogotá";
            escuela.TipoEscuela=TiposEscuela.Secundaria;
            return View(escuela);
        }
    }
}