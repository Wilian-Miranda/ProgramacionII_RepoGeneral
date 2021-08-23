using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                var lista = db.Tbl_empleado.ToList();
                return View(lista);
            }
        }
    }
}