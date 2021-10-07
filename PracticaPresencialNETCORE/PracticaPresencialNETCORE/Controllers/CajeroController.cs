using Microsoft.AspNetCore.Mvc;
using PracticaPresencialNETCORE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaPresencialNETCORE.Controllers
{
    public class CajeroController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult index(CajeroViewModel cajeroViewModel)
        {
            if (ModelState.IsValid)
            {
                if (cajeroViewModel.monto % 5 == 0)
                {
                    return View("RetiroSatisfactorio");
                }
                else
                {
                    return View("RetiroError");
                }

            }
            else
            {
                return View("index", cajeroViewModel);
            }
        }

        public IActionResult RetiroSatisfactorio()
        {
            return View();
        }

        public IActionResult RetiroError()
        {
            return View();
        }
    }
}
