using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Ingresante : Alumno
    {
        public Ingresante() : base()
        {
            AsociarBeneficio();
        }

        public Ingresante(string legajo, string nombre, string apellido, string dNI, double valorCuota) : base(legajo, nombre, apellido, dNI)
        {
            AsociarBeneficio();
        }

        protected override void AsociarBeneficio(Beneficio beneficio = null)//Quiere decir que si no le pasan parametro,por defecto sera null
        {
            beneficioOtorgado = beneficio == null ? new BeneficioA() : beneficio;
        }
    }
}
