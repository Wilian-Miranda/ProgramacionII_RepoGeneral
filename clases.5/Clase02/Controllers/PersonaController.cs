using Clase02.Models;
using Clase02.Models.ViewModels;
using Clase02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class PersonaController : Controller
    {
        //sin usar view model
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

        //usando view model
        [HttpPost]
        public ActionResult DescripcionViewModel(PersonaViewModels persona)
        {
            if (!ModelState.IsValid)
            {
                return View("PersonaViewModel", persona);
            }
            return PersonaViewModel(persona);
        }

        public ActionResult PersonaViewModel(PersonaViewModels persona)
        {
            return View(persona);
        }


    } 


}
