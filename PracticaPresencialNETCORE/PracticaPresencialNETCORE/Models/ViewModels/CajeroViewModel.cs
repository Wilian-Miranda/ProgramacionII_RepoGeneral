using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaPresencialNETCORE.Models.ViewModels
{
    public class CajeroViewModel
    {
        [Display(Name = "Monto")]
        [Required(ErrorMessage = "Error. Este campo es requerido")]
        public int monto { get; set; }

        public CajeroViewModel(Cajero cajero)
        {
            this.monto = cajero.monto;
        }

        public CajeroViewModel()
        {

        }
    }
}
