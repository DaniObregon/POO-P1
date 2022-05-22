using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class VistaBeca
    {
        public string Codigo { get; set; }
        public DateTime Fecha_Otorgamiento { get; set; }

        public double ImporteBeca { get; set; }

        public Alumno Beneficiario;

        private Beca _becaOriginal;

        public Beca retornaBecaOriginal()
        {
            return _becaOriginal;
        }


        public VistaBeca()
        {
        }

        public VistaBeca(string codigo, DateTime fecha_Otorgamiento, double importeBeca, Alumno beneficiario)
        {
            Codigo = codigo;
            Fecha_Otorgamiento = fecha_Otorgamiento;
            ImporteBeca = importeBeca;
            Beneficiario = beneficiario;
        }

        public List<VistaBeca> retornaListaBecasVista(List<Beca> listaBecas)
        {
            List<VistaBeca> vistaBecasLista = new List<VistaBeca>();

            foreach (Beca beca in listaBecas)
            {
                vistaBecasLista.Add(new VistaBeca(beca.Codigo,
                    beca.Fecha_Otorgamiento,
                    beca.ImporteBeca,
                    beca.Beneficiario));
            }
            return vistaBecasLista;
        }

    }
}
