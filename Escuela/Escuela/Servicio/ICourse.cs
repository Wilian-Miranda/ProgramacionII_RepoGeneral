using Escuela.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Servicio
{
    public interface ICourse
    {
        //solo deben incluirse métodos a utilizar.Solo metodo y nada mas
        //Solo quienes implementen deben agregar la logica. En repositorio
        void Insertar(Tbl_Course c);
        

    }
}
