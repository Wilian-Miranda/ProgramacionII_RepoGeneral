using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    //lista de datos constantes
    public enum grades { A,B,C,D}
    public class Tbl_Enrollment
    {
        //definiendo el campo como llave primaria
        [Key]
        //para dar identacion
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int enrollmentId { get; set; }

        //Foranea del curso
        public int courseId { get; set; }
        public int studendId { get; set; }

        public grades? grade { get; set; }

        public Tbl_Course FK_IdCourse { get; set; }
        public Tbl_Student FK_IdStudent { get; set; }
    }
}
