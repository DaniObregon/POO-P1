using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Grado : Alumno
    {
        public Grado()
        {
            AsociarBeneficio();
        }

        public Grado(string legajo, string nombre, string apellido, string dNI, double valorCuota) : base(legajo, nombre, apellido, dNI)
        {
            AsociarBeneficio();
        }

        protected override void AsociarBeneficio(Beneficio beneficio = null)//Quiere decir que si no le pasan parametro,por defecto sera null
        {
            beneficioOtorgado = beneficio == null ? new BeneficioB() : beneficio;
        }
    }
}
