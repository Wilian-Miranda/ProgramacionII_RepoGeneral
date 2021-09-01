using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase02.Repositories
{
    public class PersonaRepository
    {
        public List<ClsPersona> ObtenerPersona()
        {
            return new List<ClsPersona>
            {
                new ClsPersona{Id=1, Nombre="Sandra"},
                new ClsPersona{Id=2, Nombre="Manuel"},
                new ClsPersona{Id=3, Nombre="José"}
            };
        }
    }
}