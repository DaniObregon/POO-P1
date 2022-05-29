using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class VistaCuota
    {
        public string Id { get; set; }
        public string MesAnho { get; set; }
        public DateTime FechaPago { get; set; }
        public double Importe { get; set; }
        public double ImporteBeca { get; set; }
        public string Beneficio { get; set; }
        public double NetoPagar { get; set; }
        

        private Cuota _cuotaOriginal;

        public Cuota retornaCuotaOriginal()
        {
            return _cuotaOriginal;
        }

        public VistaCuota(string id, string mesAnho, DateTime fechaPago, double importe, double importeBeca, string beneficio, double netoPagar)
        {
            Id = id;
            MesAnho = mesAnho;
            FechaPago = fechaPago;
            Importe = importe;
            ImporteBeca = importeBeca;
            Beneficio = beneficio;
            NetoPagar = netoPagar;
            
        }

        public VistaCuota()
        {
        }

        /*public List<VistaCuota> retornaListaCuotasVista(List<Cuota> listaCuotas)
        {
            List<VistaCuota> vistaCuotaLista = new List<VistaCuota>();

            foreach (Cuota cuota in listaCuotas)
            {
                vistaCuotaLista.Add(new VistaCuota(cuota.Id,
                    $"{cuota.Mes}/{cuota.Anho}",
                    cuota.FechaPago,
                    cuota.Importe,
                    cuota.Alumno.sumatoriaBecas(),
                    cuota.Alumno.devuelveBeneficio(),
                    cuota.calcularCuota()));
            }
            return vistaCuotaLista;
        }*/
    }
}
