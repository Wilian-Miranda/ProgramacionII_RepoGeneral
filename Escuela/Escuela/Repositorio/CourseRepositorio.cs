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

        public void Buscar(Tbl_Course c)
        {
            app.Tbl_Course.Find(c);
        }

        public void Delete(Tbl_Course c)
        {
            app.Tbl_Course.Remove(c);
        }

        public void Insertar(Tbl_Course c)
        {
            app.Add(c);
            app.SaveChanges();
        }

        public ICollection<Tbl_Course> ListarCursos()
        {
            return app.Tbl_Course.ToList();
        }
    }
}
