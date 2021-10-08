using Escuela.Dominio;
using Escuela.Models;
using Escuela.Models.ViewModels;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICourse icourse;

        public HomeController(ILogger<HomeController> logger, ICourse icourse)
        {
            this.icourse = icourse;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Tbl_Course course = new Tbl_Course();
            //course.title = "Poo";
            //course.credits = 100;
            //icourse.Insertar(course);
            //return View();
            var dandoFormatoJson = icourse.ListarCursos();
            return Json(new { datos = dandoFormatoJson });
        }

        public IActionResult Curso()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Curso(Tbl_CourseViewModel course)
        {

            if (ModelState.IsValid)
            {
                Tbl_Course courses = new Tbl_Course();
                courses.title = course.title;
                courses.credits = course.credits;
                icourse.Insertar(courses);
                return View("Index");
                
            }
            else
            {
                return View("Curso", course);
            }
        }

        //incluir colleccion de datos

        public IActionResult GetAll()
        {
            var dandoFormatoJson = icourse.ListarCursos();

            return Json(new { datos = dandoFormatoJson });
        }


            public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
