using Jose_Wilian_Leiva_Miranda.Models;
using Jose_Wilian_Leiva_Miranda.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jose_Wilian_Leiva_Miranda.Controllers
{
    public class CajeroAutomaticoController : Controller
    {
        // GET: CajeroAutomatico
        public ActionResult index() 
        {
          

            Cajero monto = new Cajero();
            monto.monto = 100000;
            CajeroViewModel cajero = new CajeroViewModel(monto);

            return View(cajero);
        }
        public static double monto = 0;
        public ActionResult RetirarMonto(CajeroViewModel retiro)
        {
            String url = "";

            if(retiro.montoRetiro == 0)
            {
                url = "/CajeroAutomatico/index";
            }
            else if (retiro.montoRetiro % 5 == 0)
            {
                monto = retiro.montoRetiro;
                url = "/CajeroAutomatico/Retiro";
            }
            else
            {
                url = "/CajeroAutomatico/Error";
            }
            return Redirect(url);

        }

        public ActionResult Error()
        {
            ViewBag.mensaje = "No se puede completar este retiro";
            return View();
        }

        public ActionResult Retiro()
        {
            ViewBag.montoRetiro = monto;
            ViewBag.mensaje = "Puede retirar su dinero";
            return View();
        }

    }
}