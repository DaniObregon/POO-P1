using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1erParcial_POO_Obregon
{
    public class Universidad
    {
        List<Alumno> listaAlumnos;
        List<Beca> listaBecas;

        public Universidad()
        {
            listaAlumnos = new List<Alumno>();
            listaBecas = new List<Beca>();
        }

        public void agregarAlumnoAUniversidad(Alumno alumno)
        {
            listaAlumnos.Add(alumno);
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
            //DESARROLLAR ELIMINAR ALUMNO
        }
    }
}
