using Escuela.Data;
using Escuela.Dominio;
using Escuela.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Repositorio
{
    public class CourseRepositorio : ICourse
    {
        private ApplicationDBContext app;

        public CourseRepositorio(ApplicationDBContext app)
        {
            this.app = app;
        }
        public void Insertar(Tbl_Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }
    }
}
