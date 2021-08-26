using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult PruebaVista()
        {
            //invocación a clase
            var prueba = new ClsPrueba
            {
                Id = 1,
                Nombre = "Prueba"
            };
            return View(prueba);
        }
    }
}