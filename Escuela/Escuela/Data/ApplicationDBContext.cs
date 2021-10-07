using Escuela.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }

        ////Ayuda a crear las tablas
        public DbSet<Tbl_Student> Tbl_Student { get; set; }
        public DbSet<Tbl_Enrollment> Tbl_Enrollment { get; set; }
        public DbSet<Tbl_Course> Tbl_Course { get; set; }


        ////crea las tablas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
