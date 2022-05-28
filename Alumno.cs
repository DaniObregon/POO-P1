using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial_POO_Obregon
{
    public abstract class Alumno
    {
        private List<Beca> ListaBecas;
        private List<Cuota> ListaCuotas;
        protected Beneficio beneficioOtorgado;

        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        

        public Alumno()
        {
            ListaBecas = new List<Beca>();
            ListaCuotas = new List<Cuota>();
        }

        public Alumno(string legajo, string nombre, string apellido, string dNI) : this()
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
        }

        public void asignarBeca(Beca beca)
        {
            if (ListaBecas.Count < 2)
            {
                this.ListaBecas.Add(beca);
            }
            else
            {
                MessageBox.Show("No es posible asignar mas becas al alumno.",
                            "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        public void rescindirBeca(Beca beca)
        {
            this.ListaBecas.Remove(beca);
        }

        public List<Beca> retornaBecas()
        {
            return ListaBecas;
        }

        public double sumatoriaBecas()
        {
            double sum = 0;

            foreach (Beca beca in this.ListaBecas)
            {
                sum += beca.ImporteBeca;
            }
            return sum;
        }

        public void agregarCuota(Cuota cuota)
        {
            this.ListaCuotas.Add(cuota);
        }

        protected abstract void AsociarBeneficio(Beneficio beneficio);

        public Beneficio retornaBeneficio()
        {
            return beneficioOtorgado;
        }
    }
}
