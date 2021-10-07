using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class IndemnizacionController : Controller
    {
        // GET: Indemnizacion
        public ActionResult Indemnizaciones()
        {
            return View();
        }
        public ActionResult Importe(String nombreEmpleado, String valorHora,
                                    String antiguedadYear, String horasTrabajadas)
        {
            Double valorH = Convert.ToDouble(valorHora);
            int year = Convert.ToInt32(antiguedadYear);
            Double horasT = Convert.ToDouble(horasTrabajadas);

            ViewBag.totalCobrar = "$" + CalculoTotalACobrar(valorH, horasT, year);
            ViewBag.descuento = "$" + CalculoDescuento(CalculoTotalACobrar(valorH, horasT, year));
            ViewBag.totalDescuento = "$" + TotalFinal(CalculoTotalACobrar(valorH, horasT, year), CalculoDescuento(CalculoTotalACobrar(valorH, horasT, year)));

            ViewBag.nombre = nombreEmpleado;
            ViewBag.antiguedad = antiguedadYear;
            ViewBag.valorHora = valorH;

            return View();
        }

        public Double CalculoTotalACobrar(Double valorH, Double horasT, int year)
        {
            return (valorH * horasT + year * 30);
        }
        public Double CalculoDescuento(Double total)
        {
            return (total* 0.13);
        }
        public Double TotalFinal(Double total, Double descuento)
        {
            return (total - descuento);
        }
    }
}