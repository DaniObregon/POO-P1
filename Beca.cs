using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Beca
    {
        public string Codigo { get; set; }
        public DateTime Fecha_Otorgamiento { get; set; }
        public double ImporteBeca { get; set; }

        public Alumno Beneficiario;

        public Beca()
        {
        }

        public Beca(string codigo, DateTime fecha_Otorgamiento, double importeBeca, Alumno beneficiario)
        {
            Codigo = codigo;
            Fecha_Otorgamiento = fecha_Otorgamiento;
            ImporteBeca = importeBeca;
            Beneficiario = beneficiario;
        }
    }
}
