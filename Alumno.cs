using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial_POO_Obregon
{
    public class Alumno
    {
        private List<Beca> ListaBecas = new List<Beca>();
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public int Grupo { get; set; }
        public double ValorCuota { get; set; }

        public Alumno() { }

        public Alumno(string legajo, string nombre, string apellido, string dNI, int grupo, double valorCuota) : this()//, List<Beca> listaBecas
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Grupo = grupo;
            ValorCuota = valorCuota;
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
            //TRYCATCH
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

        public string devuelveBeneficio()
        {
            string devuelve = "";
            switch (this.Grupo)
            {
                case 1:
                    devuelve = "Ingresante -10%";
                    break;
                case 2:
                    devuelve = "Grado -5%";
                    break;
                case 3:
                    devuelve = "Posgrado -1%";
                    break;
            }
            return devuelve;
        }

        public double beneficio()
        {
            double descuento = 0;

            switch (this.Grupo)
            {
                case 1:
                    descuento = 0.1;
                    break;
                case 2:
                    descuento = 0.05;
                    break;
                case 3:
                    descuento = 0.01;
                    break;
            }
            return descuento;
        }
    }
}
