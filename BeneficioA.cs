using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class BeneficioA:Beneficio
    {
        public override decimal CalcularBeneficio(decimal monto)
        {
            return monto *= 0.1m;
        }
    }
}
