using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public abstract class Universidad
    {
        List<Alumno> listaAlumnos;
        List<Beca> listaBecas;

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
            listaBecas = new List<Beca>();
        }

        public void agregarAlumno(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
        }
        public void eliminarAlumno(Alumno alumno)
        {
            //ELIMINAR ALUMNO
        }
    }
}
