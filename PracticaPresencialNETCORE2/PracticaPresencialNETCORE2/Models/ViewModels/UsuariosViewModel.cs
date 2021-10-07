using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaPresencialNETCORE2.Models.ViewModels
{
    public class UsuariosViewModel
    {
        [Display(Name = "Nombre:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string nombre { get; set; }

        [Display(Name = "Edad:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        [Range(0, 120, ErrorMessage = "Edad no válida")]
        public int edad { get; set; }

        [Display(Name = "Sexo:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string sexo { get; set; }

        [Display(Name = "Tipo de estudio:")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string tipoEstudio { get; set; }

        public UsuariosViewModel(Usuarios usuario)
        {
            this.nombre = usuario.nombre;
            this.edad = usuario.edad;
            this.sexo = usuario.sexo;
            this.tipoEstudio = usuario.tipoEstudio;
        }

        public UsuariosViewModel()
        {

        }
    }
}
