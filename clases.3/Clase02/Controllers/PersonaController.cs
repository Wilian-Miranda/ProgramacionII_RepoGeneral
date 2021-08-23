using Clase02.Models;
using Clase02.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class PersonaController : Controller
    {
        public ActionResult Descripcion(String Nombre_V)
        {
            //var per = new ClsPersona { Nombre = "Wilian" };
            //return View(per);
            ViewBag.VariableVista = Nombre_V;

            PersonaRepository personaRepository = new PersonaRepository();

            return View(personaRepository.ObtenerPersona());
        }

        //[HttpPost]
        //public ActionResult Descripcion(String Nombre_V)
        //{
        //    //var per = new ClsPersona { Nombre = "Wilian" };
        //    //return View(per);
        //    ViewBag.VariableVista = Nombre_V;

        //    PersonaRepository personaRepository = new PersonaRepository();

        //    return View(personaRepository.ObtenerPersona());
        //}

    } 
}
