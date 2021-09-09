using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jose_Wilian_Leiva_Miranda.Models.ViewModels
{
    public class CajeroViewModel
    {

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "No valido")]
        public int montoRetiro { get; set; }
        public double monto  { get; set; }


        public CajeroViewModel()
        {

        }

        public CajeroViewModel(Cajero retiro)
        {
            this.montoRetiro = retiro.montoRetiro;
            this.monto = retiro.monto;
        }

    }


}