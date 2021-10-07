using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Dominio
{
    public class Tbl_Student
    {
        //definiendo el campo como llave primaria
        [Key]
        //para dar identacion
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int studendId { get; set; }

        public string lastName { get; set; }

        public string firstMidName { get; set; }

        public DateTime enrollmentsDate { get; set; }

        //llave foranea para la tabla de enrollment
        public ICollection<Tbl_Enrollment> FK_IdStudent { get; set; }
    }
}
