using System;
using asp_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace asp_mvc.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura();
            asignatura.UniqueId=Guid.NewGuid().ToString();
            asignatura.Nombre="Mates";
    
            return View(asignatura);
        }
    }
}