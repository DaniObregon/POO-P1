using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Posgrado : Alumno
    {
        public Posgrado()
        {
        }

        public Posgrado(string legajo, string nombre, string apellido, string dNI, int grupo, double valorCuota) : base(legajo, nombre, apellido, dNI, grupo, valorCuota)
        {
        }
    }
}
