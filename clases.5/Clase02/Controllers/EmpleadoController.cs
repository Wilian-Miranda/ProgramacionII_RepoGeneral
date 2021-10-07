using Clase02.Models;
using Clase02.Models.ViewModels;
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
        //===============================SIN VIEWMODEL===============================
        //public ActionResult EliminarEmpleado(String id)
        //{
        //    using (EMPLEADOEntities db = new EMPLEADOEntities())
        //    {
        //        int Id = Convert.ToInt32(id);
        //        Tbl_empleado eliminar = db.Tbl_empleado.Where(x=>x.Id_empleado==Id).FirstOrDefault();
        //        db.Tbl_empleado.Remove(eliminar);
        //        db.SaveChanges();
        //    }
        //    return Redirect("/Empleado/Empleado");
        //}

        //public ActionResult GestionEmpleado(String id, Boolean interruptor)
        //{
        //    /*Si el valor de la variable id es diferente de 0 y el interruptor es verdadero, entonces se procede a hacer una consulta a la 
        //     db para traer los datos del empleado que corresponden a ese id*/
        //    if (interruptor==true && !Convert.ToInt32(id).Equals(0))
        //    {
        //        int ID = Convert.ToInt32(id);

        //        using(EMPLEADOEntities db = new EMPLEADOEntities())
        //        {
        //            //lamda
        //            var empleado = db.Tbl_empleado.Where(x => x.Id_empleado == ID).FirstOrDefault();
        //            //se guarda cada dato en variables dinamicas que serán enviadas a la vista
        //            ViewBag.id = id;
        //            ViewBag.nombres = empleado.Empl_nombre;
        //            ViewBag.apellidos = empleado.Empl_apellido;
        //            ViewBag.email = empleado.Empl_email;
        //            ViewBag.telefono = empleado.Empl_tel;
        //            ViewBag.dui = empleado.Empl_DUI;
        //            ViewBag.direccion = empleado.Empl_direccion;
        //        }

        //    }
        //    else
        //    {
        //        //si el id es 0, en una variable dinamica se manda el valor "Automático" que se mostrará como valor por defecto en el espacio de id indicando que no es necesario introducir un id
        //        ViewBag.id = "Automático";
        //    }

        //    //si las variables especiales estan vacias se activaran los placeholder, sino se cargaran los datos para actualizar
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Guardar(String id, String nombresEmpleado, String apellidosEmpleado, String emailEmpleado,
        //                                    String telefonoEmpleado, String duiEmpleado, String direccionEmpleado)
        //{
        //    //Si (id==0,iterruptor==false--> se envia a la vista <<ViewBag.id = "Automático">>, significa que se guardarán datos
        //    //Si (id!=0,iterruptor==true--> se envia a la vista <<ViewBag.id = id;>> con el id de la fila a actualizar,
        //    // significa que se Actualizarán datos

        //    /*Si el valor almacenado en id es distinto de <<Automático>>, se toman los datos y con el id se busca con un lamda el registro
        //     * a actualizar y se guardan los datos actualizados*/
        //    if (!id.Equals("Automático"))
        //    {
        //        using (EMPLEADOEntities db = new EMPLEADOEntities())
        //        {
        //            if (direccionEmpleado.Trim().Equals(""))
        //            {
        //                direccionEmpleado = "-";
        //            }
        //            int ID = Convert.ToInt32(id);
        //            var actualizar = db.Tbl_empleado.Where(x => x.Id_empleado == ID).Select(x => x).FirstOrDefault();
        //            actualizar.Empl_nombre = nombresEmpleado;
        //            actualizar.Empl_apellido = apellidosEmpleado;
        //            actualizar.Empl_email = emailEmpleado;
        //            actualizar.Empl_tel = telefonoEmpleado;
        //            actualizar.Empl_DUI = duiEmpleado;
        //            actualizar.Empl_direccion = direccionEmpleado;
        //            db.SaveChanges();
        //        }
        //    }
        //    else
        //    {
        //     /*Si el valor almacenado en id es <<Automático>>, se toman los datos y se ignora el id, luego se guardan los datos*/
        //        using (EMPLEADOEntities db = new EMPLEADOEntities())
        //        {
        //            if (direccionEmpleado.Trim().Equals(""))
        //            {
        //                direccionEmpleado = "-";
        //            }
        //            var guardarEmpleado = new Tbl_empleado();
        //            guardarEmpleado.Empl_nombre = nombresEmpleado;
        //            guardarEmpleado.Empl_apellido = apellidosEmpleado;
        //            guardarEmpleado.Empl_email = emailEmpleado;
        //            guardarEmpleado.Empl_tel = telefonoEmpleado;
        //            guardarEmpleado.Empl_DUI = duiEmpleado;
        //            guardarEmpleado.Empl_direccion = direccionEmpleado;

        //            db.Tbl_empleado.Add(guardarEmpleado);
        //            db.SaveChanges();

        //        }
        //    }
        //    //se redirecciona al controlador (1)Empleado y se envia la vista (2)Empleado
        //    return Redirect("/Empleado/Empleado");
        //}

        //=========================IMPLEMENTANDO LOS VIEWMODEL==============================
        public ActionResult EliminarEmpleado(String id)
        {
            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                int Id = Convert.ToInt32(id);
                Tbl_empleado eliminar = db.Tbl_empleado.Where(x => x.Id_empleado == Id).FirstOrDefault();
                db.Tbl_empleado.Remove(eliminar);
                db.SaveChanges();
            }
            return Redirect("/Empleado/Empleado");
        }

        public ActionResult GestionEmpleado(String id, Boolean interruptor)
        {
            /*Si el valor de la variable id es diferente de 0 y el interruptor es verdadero, entonces se procede a hacer una consulta a la 
             db para traer los datos del empleado que corresponden a ese id*/
            if (interruptor == true && !Convert.ToInt32(id).Equals(0))
            {
                int ID = Convert.ToInt32(id);

                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {
                    //lamda
                    var empleado = db.Tbl_empleado.Where(x => x.Id_empleado == ID).FirstOrDefault();
                    //se guarda cada dato en variables dinamicas que serán enviadas a la vista
                    Tbl_empleado empleados = new Tbl_empleado();
                    empleados.Id_empleado = Convert.ToInt32(id);
                    empleados.Empl_nombre = empleado.Empl_nombre;
                    empleados.Empl_apellido = empleado.Empl_apellido;
                    empleados.Empl_email = empleado.Empl_email;
                    empleados.Empl_tel = empleado.Empl_tel;
                    empleados.Empl_DUI = empleado.Empl_DUI;
                    empleados.Empl_direccion = empleado.Empl_direccion;
                    //se envian en el view model
                    Tbl_empleadoViewModel empleadoss = new Tbl_empleadoViewModel(empleados);
                    return View(empleadoss);

                }

            }
            else
            {
                //si el id es 0, en una variable dinamica se manda el valor "Automático" que se mostrará como valor por defecto en el espacio de id indicando que no es necesario introducir un id
                Tbl_empleado empleados = new Tbl_empleado();
                empleados.Id_empleado = 0;
                //se envian en el view model
                Tbl_empleadoViewModel empleadoss = new Tbl_empleadoViewModel(empleados);
                return View(empleadoss);
            }

            //si las variables especiales estan vacias se activaran los placeholder, sino se cargaran los datos para actualizar
            //return View();
        }

        [HttpPost]
        public ActionResult Guardar(Tbl_empleadoViewModel empleado)
        {
            //Si (id==0,iterruptor==false--> se envia a la vista <<ViewBag.id = "Automático">>, significa que se guardarán datos
            //Si (id!=0,iterruptor==true--> se envia a la vista <<ViewBag.id = id;>> con el id de la fila a actualizar,
            // significa que se Actualizarán datos

            /*Si el valor almacenado en id es distinto de <<Automático>>, se toman los datos y con el id se busca con un lamda el registro
             * a actualizar y se guardan los datos actualizados*/
            String url = "";
            if (!empleado.Id_empleado.Equals(0))
            {
                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {
                    if (ModelState.IsValid)
                    {
                        var actualizar = db.Tbl_empleado.Where(x => x.Id_empleado == empleado.Id_empleado).FirstOrDefault();
                        actualizar.Empl_nombre = empleado.Empl_nombre;
                        actualizar.Empl_apellido = empleado.Empl_apellido;
                        actualizar.Empl_email = empleado.Empl_email;
                        actualizar.Empl_tel = empleado.Empl_tel;
                        actualizar.Empl_DUI = empleado.Empl_DUI;
                        actualizar.Empl_direccion = empleado.Empl_direccion;
                        db.SaveChanges();
                        url="/Empleado/Empleado";
                    }
                    else
                    {
                        return View("GestionEmpleado", empleado);
                    }

                }
            }
            else
            {
                /*Si el valor almacenado en id es <<Automático>>, se toman los datos y se ignora el id, luego se guardan los datos*/
                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {
                    if (ModelState.IsValid)
                    {
                        Tbl_empleado guardarEmpleado = new Tbl_empleado();
                        guardarEmpleado.Empl_nombre = empleado.Empl_nombre;
                        guardarEmpleado.Empl_apellido = empleado.Empl_apellido;
                        guardarEmpleado.Empl_email = empleado.Empl_email;
                        guardarEmpleado.Empl_tel = empleado.Empl_tel;
                        guardarEmpleado.Empl_DUI = empleado.Empl_DUI;
                        guardarEmpleado.Empl_direccion = empleado.Empl_direccion;

                        db.Tbl_empleado.Add(guardarEmpleado);
                        db.SaveChanges();
                        url="/Empleado/Empleado";
                    }
                    else
                    {
                        return View("GestionEmpleado", empleado);
                    }
                }
            }
            //se redirecciona al controlador (1)Empleado y se envia la vista (2)Empleado
            return Redirect(url);
        }

    }
}