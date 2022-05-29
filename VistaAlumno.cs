using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class VistaAlumno
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }

        private Alumno _retornaAlumnoOriginal;

        public Alumno retornaAlumnoOriginal()
        {
            return _retornaAlumnoOriginal;
        }

        public VistaAlumno() { }

        public VistaAlumno(string legajo, string nombre, string apellido, string dNI, Alumno alumno)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            _retornaAlumnoOriginal = alumno;
        }

        public List<VistaAlumno> retornaListaAlumnosVista(List<Alumno> listaAlumnos)
        {
            List<VistaAlumno> vistaAlumnoLista = new List<VistaAlumno>();
            
            foreach (Alumno alumno in listaAlumnos)
            {
                vistaAlumnoLista.Add(new VistaAlumno(alumno.Legajo, 
                    alumno.Nombre, 
                    alumno.Apellido, 
                    alumno.DNI, 
                    alumno));
            }
            return vistaAlumnoLista;
        }
    }
}
