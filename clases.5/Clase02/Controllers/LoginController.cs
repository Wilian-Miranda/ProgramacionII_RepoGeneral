using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clase02.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public static String mensaje="";
        public ActionResult InicioSesion()
        {
            ViewBag.info = mensaje;
            return View();
        }

        public static String form = "";
        //verificar inicio de sesion
        [HttpPost]
        public ActionResult VerificarInicioSesion(String nombreUsuario, String password)
        {
            if (Verificar(nombreUsuario, password).Equals(true))
            {
                mensaje = "";
                form = "/Home/Index";
            }
            else if (Verificar(nombreUsuario, password).Equals(false))
            {
                mensaje = "Error al iniciar sesion.";
                form = "/Login/InicioSesion";
            }
            return Redirect(form);

        }
        public Boolean acceso;
        //metodo para buscar en db si existe el empleado y el dui
        private Boolean Verificar(String nombreUsuario, String password)
        {
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {

                var consulta = (from a in db.Tbl_empleado
                                where (((a.Empl_nombre + " " + a.Empl_apellido).Equals(nombreUsuario)||a.Empl_nombre.Equals(nombreUsuario)||a.Empl_apellido.Equals(nombreUsuario))
                                && a.Empl_DUI.Equals(password))
                                select a).ToList();
                if (consulta.Count>0)
                {
                    acceso= true;
                }
            }

            return acceso;

        }

    }
}