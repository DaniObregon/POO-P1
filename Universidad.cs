using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial_POO_Obregon
{
    public class Universidad
    {
        public List<Beca> listaBecas { get; set; }
        public List<Alumno> listaAlumnos { get; set; }

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
            listaBecas = new List<Beca>();
        }

        public void agregarAlumnoAUniversidad(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }

        public void modificarAlumno(Alumno alumnoSeleccionado)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.Legajo == alumnoSeleccionado.Legajo)
                {
                    alumno.Legajo = alumnoSeleccionado.Legajo;
                    alumno.Nombre = alumnoSeleccionado.Nombre;
                    alumno.Apellido = alumnoSeleccionado.Apellido;
                    alumno.DNI = alumnoSeleccionado.DNI;
                    alumno.Grupo = alumnoSeleccionado.Grupo;
                    break;
                }
            }
        }

        public void agregarBeca(Beca beca)
        {
            listaBecas.Add(beca);
        }

        public List<Beca> retornaListaBecas()
        {
            return this.listaBecas;
        }

        public List<Alumno> retornarListaAlumnosUniversidad()
        {
            return this.listaAlumnos;
        }
        public void eliminarAlumnoDeUniversidad(Alumno alumno)
        {
            try
            {
                this.listaAlumnos.Remove(alumno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //DESARROLLAR ELIMINAR ALUMNO
        }
    }
}
