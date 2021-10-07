using Microsoft.AspNetCore.Mvc;
using PracticaPresencialNETCORE2.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaPresencialNETCORE2.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsuariosViewModel usuariosViewModel)
        {
            if (ModelState.IsValid)
            {
                return View("Registro");
            }

            return View("Index", usuariosViewModel);
        }
    }
}
