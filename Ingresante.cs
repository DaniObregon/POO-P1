using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Ingresante : Alumno
    {
        public Ingresante()
        {
        }

        public Ingresante(string legajo, string nombre, string apellido, string dNI, int grupo, double valorCuota) : base(legajo, nombre, apellido, dNI, grupo, valorCuota)
        {
        }
    }
}
