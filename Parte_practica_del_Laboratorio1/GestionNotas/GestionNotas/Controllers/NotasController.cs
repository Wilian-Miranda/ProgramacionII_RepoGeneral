using GestionNotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionNotas.Controllers
{
    public class NotasController : Controller
    {
        // GET: Notas
        public ActionResult index()
        {
            return View();
        }
        public ActionResult GestionNotas()
        {
            using (EstudianteEntities db = new EstudianteEntities())
            {
                var lista =  db.TblNotasEstudiante.ToList();
                return View(lista);
            }

        }

        [HttpPost]
        public ActionResult Save(String nombreEstudiante, String laboratorio1, String laboratorio2, String laboratorio3,
                                String Parcial1, String Parcial2, String Parcial3)
        {
            string url = "";
            try
            {
                //conversion
                decimal lab1 = Convert.ToDecimal(laboratorio1);
                decimal lab2 = Convert.ToDecimal(laboratorio2);
                decimal lab3 = Convert.ToDecimal(laboratorio3);

                decimal par1 = Convert.ToDecimal(Parcial1);
                decimal par2 = Convert.ToDecimal(Parcial2);
                decimal par3 = Convert.ToDecimal(Parcial3);

                
                //calculando los periodo individualmente
                decimal periodo1 = CalcularPeriodo(lab1, par1);
                decimal periodo2 = CalcularPeriodo(lab2, par2);
                decimal periodo3 = CalcularPeriodo(lab3, par3);

                //calculando nota final
                decimal notaGlobal = CalcularNotalFinal(periodo1, periodo2, periodo3);

                //invocando al metodo que guardara las notas
                GuardarNotas(nombreEstudiante, lab1, lab2, lab3, par1, par2, par3, notaGlobal);
                url = "/Notas/GestionNotas";
            }
            catch (Exception ex)
            {
                url = "/Notas/index";
            }
            return Redirect(url);
        }

        //Guardar las notas
        private void GuardarNotas(String estudiante, decimal lab1, decimal lab2, decimal lab3, decimal par1, decimal par2, decimal par3, decimal notaGlobal)
        {
            try
            {
                using (EstudianteEntities db= new EstudianteEntities())
                {
                    var notas = new TblNotasEstudiante();
                    notas.Nombre = estudiante;
                    notas.lab1 = lab1;
                    notas.lab2 = lab2;
                    notas.lab3 = lab3;
                    notas.par1 = par1;
                    notas.par2 = par2;
                    notas.par3 = par3;
                    notas.nota = notaGlobal;
                    db.TblNotasEstudiante.Add(notas);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        private decimal CalcularPeriodo(decimal lab, decimal par)
        {
            return (lab*Convert.ToDecimal(0.40) + par*Convert.ToDecimal(0.60));
        }

        private decimal CalcularNotalFinal(decimal per1, decimal per2, decimal per3)
        {
            return (per1+per2+per3)/3;
        }

        public ActionResult EliminarNota(String id)
        {
            using (EstudianteEntities db = new EstudianteEntities())
            {
                int ID = Convert.ToInt32(id);
                var eliminar = db.TblNotasEstudiante.Where(x => x.id == ID).FirstOrDefault();
                db.TblNotasEstudiante.Remove(eliminar);
                db.SaveChanges();
            }
            return Redirect("/Notas/GestionNotas");
        }
    }
}