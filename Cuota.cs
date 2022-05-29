using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Cuota
    {
        public string Id { get; set; }
        public double Importe { get; set; }
        public string Mes { get; set; }
        public string Anho { get; set; }
        public DateTime FechaPago { get; set; }

        public Cuota()
        {
        }

        public Cuota(string id, double importe, string mes, string anho, DateTime fechaPago)
        {
            Id = id;
            Importe = importe;
            Mes = mes;
            Anho = anho;
            FechaPago = fechaPago;
        }

        /*public double calcularCuota()
        {
            double netoPagar = this.Importe;
            netoPagar -= Alumno.sumatoriaBecas();
            netoPagar -= netoPagar * Alumno.beneficio();

            return netoPagar;
        }*/
    }
}
