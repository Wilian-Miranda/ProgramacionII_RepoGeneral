using Clase02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clase02.Repositorios
{
    public class PersonaRepository
    { 
        public List<ClsPersona> ObtenerPersona()
        {
            return new List<ClsPersona>() { 
                new ClsPersona{Id=1,Nombre="María"},
                new ClsPersona{Id=2, Nombre="Rodrigo"},
                new ClsPersona{Id=3, Nombre="Wilian"},
                new ClsPersona{Id=4,Nombre="Marta"},
                new ClsPersona{Id=5, Nombre="Rosa"},
                new ClsPersona{Id=6, Nombre="Walter"}
            };
        }
    }
}