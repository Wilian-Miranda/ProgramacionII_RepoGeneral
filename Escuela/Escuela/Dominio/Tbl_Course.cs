using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Tbl_Course
    {
        //notacion para indicar llave primaria
        [Key]
        //Autoincrementable
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int courseId { get; set; }

        public string title { get; set; }

        public int credits { get; set; }

        //coleccion generica para ser la FK_ de Enrollement
        //se indica que hay relacion entre el course y enrollment
        public ICollection<Tbl_Enrollment> FK_IdCourse { get; set; }
    }
}
