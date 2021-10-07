using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase02.Models.ViewModels
{
    public class Tbl_empleadoViewModel
    {
        public int Id_empleado { get; set; }

        [Required]
        public string Empl_nombre { get; set; }

        [Required]
        public string Empl_apellido { get; set; }
        public string Empl_DUI { get; set; }

        [Required]
        public string Empl_direccion { get; set; }
        public string Empl_tel { get; set; }

        [Required(ErrorMessage ="Ingrese un correo válido")]
        public string Empl_email { get; set; }
        public string Empl_cargo { get; set; }

        public Tbl_empleadoViewModel(Tbl_empleado empleado)
        {
            Id_empleado = empleado.Id_empleado;
            Empl_nombre = empleado.Empl_nombre;
            Empl_apellido = empleado.Empl_apellido;
            Empl_DUI = empleado.Empl_DUI;
            Empl_direccion = empleado.Empl_direccion;
            Empl_tel = empleado.Empl_tel;
            Empl_email = empleado.Empl_email;
            Empl_cargo = empleado.Empl_cargo;
        }

        public Tbl_empleadoViewModel()
        {

        }
    }
}