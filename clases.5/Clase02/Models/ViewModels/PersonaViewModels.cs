using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Clase02.Models.ViewModels
{
    public class PersonaViewModels
    {
        [Display (Name ="ID: ")]
        [Range(0,int.MaxValue, ErrorMessage="No valido")]
        public int Id_empleado { get; set; }

        [Display(Name = "NOMBRES: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Empl_nombre { get; set; }

        [Display(Name = "APELLIDOS: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Empl_apellido { get; set; }

        [Display(Name = "DUI: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Empl_DUI { get; set; }

        public string Empl_direccion { get; set; }

        [Display(Name = "TELÉFONO: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Empl_tel { get; set; }

        [Display(Name = "EMAIL: ")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Empl_email { get; set; }

        public string Empl_cargo { get; set; }
    }
}