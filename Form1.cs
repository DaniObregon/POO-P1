﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1erParcial_POO_Obregon
{
    public partial class Form1 : Form
    {

        List<Cuota> listaCuotas;
        List<Beca> listaBecas;

        VistaAlumno vistaAlumno;
        VistaCuota vistaCuota;
        VistaBeca vistaBeca;

        Universidad universidad;
        Alumno alumno;
        Cuota cuota;
        Beca beca;


        public Form1()
        {
            InitializeComponent();

            vistaBeca = new VistaBeca();
            vistaAlumno = new VistaAlumno();
            vistaCuota = new VistaCuota();

            listaCuotas = new List<Cuota>();
            listaBecas = new List<Beca>();
            universidad = new Universidad();

        }

        private void dgvAlumno_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            //dgvAlumnoSeleccionado.Rows.Clear();

            List<Alumno> listaAlumnosAux = universidad.retornarListaAlumnosUniversidad();
            Alumno alumno = devuelveAlumnoSeleccionado();

            if (listaAlumnosAux.Count != 0)
            {
                if (listaAlumnosAux.Exists(x => x.Legajo == alumno.Legajo))
                {
                    txtLegajo.Text = alumno.Legajo;
                    txtNombre.Text = alumno.Nombre;
                    txtApellido.Text = alumno.Apellido;
                    txtDNI.Text = alumno.DNI;
                    if (alumno is Ingresante)
                    {
                        rbIngresante.Checked = true;
                    }
                    if (alumno is Grado)
                    {
                        rbGrado.Checked = true;
                    }
                    if (alumno is Posgrado)
                    {
                        rbPosgrado.Checked = true;
                    }
                }
            }

            /*foreach (Alumno alumno in listaAlumnos)
            {
                if (dgvAlumno.CurrentRow.Cells[0].Value == alumno.Legajo)
                {
                    txtLegajo.Text = alumno.Legajo;
                    txtNombre.Text = alumno.Nombre;
                    txtApellido.Text = alumno.Apellido;
                    txtDNI.Text = alumno.DNI;
                    nUpDownGrupo.Value = alumno.Grupo;

                    txtBeneficiario.Text = alumno.Apellido;

                    //agregar becas del alumno seleccionado
                    foreach (Beca beca in alumno.retornaBecasAlumno())
                    {
                        dgvAlumnoSeleccionado.Rows.Add(beca.Codigo, beca.Fecha_Otorgamiento, beca.ImporteBeca);
                    }
                }
            }*/
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            agregarAlumnoNuevo();//Hay un camppo global Alumno donde se carga el alumno que se va a agregar

            if (alumno != null)
            {
                universidad.agregarAlumnoAUniversidad(alumno);
                agregarListaAlumnoaDGV(universidad.retornarListaAlumnosUniversidad());
            }
        }

        private Alumno devuelveAlumnoSeleccionado()
        {
            return dgvAlumno.SelectedRows[0].DataBoundItem as Alumno;
        }


        public Alumno agregarAlumnoNuevo()
        {
            try
            {
                if (verificarCamposAlumno())
                {
                    if (legajoExistente())
                    {
                        alumno = null;
                        //MessageBox.Show("Legajo existente en la lista de alumnos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        throw new Exception("Legajo existente en la lista de alumnos.");
                    }
                    else
                    {
                        if (rbIngresante.Checked)
                        {
                            alumno = new Ingresante();
                            alumno.Grupo = 1;
                        }
                        if (rbGrado.Checked)
                        {
                            alumno = new Grado();
                            alumno.Grupo = 2;
                        }
                        if (rbPosgrado.Checked)
                        {
                            alumno = new Posgrado();
                            alumno.Grupo = 3;
                        }

                        alumno.Legajo = txtLegajo.Text;
                        alumno.Nombre = txtNombre.Text;
                        alumno.Apellido = txtApellido.Text;
                        alumno.DNI = txtDNI.Text;
                    }
                }
                else
                {
                    alumno = null;
                    //MessageBox.Show("Todos los campos son obligatorios para agregar un alumno", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw new Exception("Todos los campos son obligatorios para agregar un alumno");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return alumno;
        }

        /*
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                universidad.eliminarAlumnoDeUniversidad(dgvAlumno.SelectedRows[0].DataBoundItem as Alumno);
                agregarAlumnoaDGV(universidad.retornarListaAlumnosUniversidad());
            }
            catch (Exception)
            {

                throw;
            }




            if (dgvAlumno.CurrentRow == null)
            {
                //VERIFICAR QUE HAYA UN ALUMNO SELECCIONADO
                MessageBox.Show("Debes seleccionar un alumno!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Alumno alumno in listaAlumnos)
                {
                    if (alumno.Legajo == Convert.ToString(this.dgvAlumno.CurrentRow.Cells[0].Value))
                    {
                        DialogResult result = MessageBox.Show("Realmente desea eliminar el alumno seleccionado?",
                            "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            listaAlumnos.Remove(alumno);
                            agregarAlumnoaDGV();
                            break;
                        }
                    }
                }
            }
        }*/

        /*private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            if (!verificarCamposCuota())
            {
                MessageBox.Show("Todos los campos son obligatorios para pagar una cuota", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (verificarIdCuota())
                {
                    MessageBox.Show("Id de cuota existente en la lista de cuotas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dgvAlumno.CurrentRow == null)
                    {
                        //VERIFICAR QUE HAYA UN ALUMNO SELECCIONADO
                        MessageBox.Show("Debes seleccionar un alumno!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        foreach (Alumno alumno in listaAlumnos)
                        {
                            if (alumno.Legajo == Convert.ToString(this.dgvAlumno.CurrentRow.Cells[0].Value))
                            {
                                cuota = new Cuota();
                                cuota.Id = txtId.Text;

                                try
                                {
                                    DateTime resultado = DateTime.ParseExact(txtMes.Text, "MM", CultureInfo.InvariantCulture);
                                    cuota.Mes = resultado.ToString("MM");
                                }
                                catch (FormatException ex)
                                {
                                    MessageBox.Show(ex.Message, "ERROR");
                                    throw;
                                }

                                try
                                {
                                    DateTime resultado = DateTime.ParseExact(txtAnho.Text, "yyyy", CultureInfo.InvariantCulture);
                                    cuota.Anho = resultado.ToString("yyyy");
                                }
                                catch (FormatException ex)
                                {
                                    MessageBox.Show(ex.Message, "ERROR");
                                    throw;
                                }

                                cuota.Importe = alumno.ValorCuota;
                                cuota.FechaPago = dtpFechaDePago.Value.Date;
                                cuota.Alumno = alumno;
                                break;
                            }
                        }
                        listaCuotas.Add(cuota);
                        agregarCuotaaDGV();
                    }
                }
            }
        }*/


        private void btnAgregarBeca_Click(object sender, EventArgs e)
        {
            if (verificarCamposBeca())
            {
                if (verificarCodigo())
                {
                    MessageBox.Show("Codigo existente en la lista de becas.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (verificarCodigoAlfanumerico())
                    {
                        //por fin
                        beca = new Beca();
                        beca.Codigo = txtCodigo.Text;
                        beca.ImporteBeca = Convert.ToDouble(txtImporteBeca.Text);
                        beca.Fecha_Otorgamiento = dtpFechaDeOtorgamiento.Value.Date;

                        listaBecas.Add(beca);
                        agregarBecaaDGV();
                        txtImporteBeca.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("El codigo debe tener 6 caracteres alfanumericos: \n" +
                            "los primeros 4, deben ser numeros, y los siguientes 2, deben ser letras.",
                            "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios para agregar una beca", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarBeca_Click(object sender, EventArgs e)
        {
            if (dgvBecas.CurrentRow == null)
            {
                //VERIFICAR QUE HAYA UN ALUMNO SELECCIONADO
                MessageBox.Show("Debes seleccionar una beca!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Beca beca in listaBecas)
                {
                    if (beca.Codigo == Convert.ToString(this.dgvBecas.CurrentRow.Cells[0].Value))
                    {
                        DialogResult result = MessageBox.Show("Realmente desea eliminar la beca seleccionada?",
                            "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            listaBecas.Remove(beca);
                            agregarBecaaDGV();
                            break;
                        }
                    }
                }
            }
        }

        /*private void btnAsignarBeca_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.Legajo == Convert.ToString(this.dgvAlumno.CurrentRow.Cells[0].Value))
                {
                    foreach (Beca beca in listaBecas)
                    {
                        if (beca.Codigo == Convert.ToString(this.dgvBecas.CurrentRow.Cells[0].Value))
                        {
                            DialogResult result = MessageBox.Show("Realmente desea asignar la beca al alumno?",
                            "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                            if (alumno.sumatoriaBecas() != 0)
                            {
                                if (beca.ImporteBeca <= (alumno.ValorCuota - alumno.sumatoriaBecas()))
                                {
                                    if (result == DialogResult.Yes)
                                    {
                                        alumno.asignarBeca(beca);
                                        txtImporteBeca.Text = "";
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La sumatoria de las becas no puede ser mayor al valor de la cuota");
                                }
                            }
                            else
                            {
                                if (beca.ImporteBeca <= alumno.ValorCuota)
                                {
                                    if (result == DialogResult.Yes)
                                    {
                                        alumno.asignarBeca(beca);
                                        txtImporteBeca.Text = "";
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La sumatoria de las becas no puede ser mayor al valor de la cuota");
                                }
                            }
                        }
                    }
                }
            }
        }*/

        /*private void btnQuitarBecaAlumno_Click(object sender, EventArgs e)
        {
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.Legajo == Convert.ToString(this.dgvAlumno.CurrentRow.Cells[0].Value))
                {
                    foreach (Beca beca in alumno.retornaBecasAlumno())
                    {
                        if (beca.Codigo == this.dgvAlumnoSeleccionado.CurrentRow.Cells[0].Value)
                        {

                            DialogResult result = MessageBox.Show("Realmente desea rescindir la beca al alumno " + alumno.Apellido,
                            "Rescindir beca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (result == DialogResult.Yes)
                            {
                                alumno.rescindirBeca(beca);
                                MessageBox.Show("Has rescindido la beca de " + alumno.Apellido,
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                                //La funcion break esta porque una vez que se modifica un elemento de una lista no se puede seguir recorriendo
                            }
                        }
                    }
                }
            }
        }*/

        //DEVUELVE GRUPO ALUMNO
        public int devuelveGrupo()
        {
            if (rbIngresante.Checked)
            {
                return 1;
            }
            if (rbGrado.Checked)
            {
                return 2;
            }
            if (rbPosgrado.Checked)
            {
                return 3;
            }
            else return 0;
        }

        //CONSTRUCCION DE DGV
        private void construirDGVAlumno()
        {
            string[] columnas = { "Legajo", "Nombre", "Apellido", "DNI", "Grupo" };
            int nColumna = 0;

            foreach (DataGridViewColumn columna in dgvAlumno.Columns)
            {
                columna.HeaderText = columnas[nColumna];
                nColumna++;
            }
        }
        private void construirDGVBecas()
        {
            string[] columnas = { "Codigo", "Fecha de otorgamiento", "Importe" };
            int nColumna = 0;

            foreach (DataGridViewColumn columna in dgvBecas.Columns)
            {
                columna.HeaderText = columnas[nColumna];
                nColumna++;
            }
        }
        private void construirDGVCuotasPagas()
        {
            string[] columnas = { "Id", "Cuota", "Fecha de pago", "Importe cuota", "Importe Beca", "Beneficio", "Neto a pagar" };
            int nColumna = 0;

            foreach (DataGridViewColumn columna in dgvCuotasPagas.Columns)
            {
                columna.HeaderText = columnas[nColumna];
                nColumna++;
            }
        }
        private void construirDGVBecasAlumnoSeleccionado()
        {
            string[] columnas = { "Codigo", "Fecha otorgamiento", "Importe" };
            int nColumna = 0;

            foreach (DataGridViewColumn columna in dgvAlumnoSeleccionado.Columns)
            {
                columna.HeaderText = columnas[nColumna];
                nColumna++;
            }
        }

        //AGREGAR A DGV
        public void agregarListaAlumnoaDGV(List<Alumno> alumnos)
        {
            dgvAlumno.DataSource = null;
            dgvAlumno.DataSource = alumnos;
        }
        public void agregarBecaaDGV()
        {
            dgvBecas.DataSource = null;
            dgvBecas.DataSource = vistaBeca.retornaListaBecasVista(listaBecas);
            construirDGVBecas();
        }
        private void agregarCuotaaDGV()
        {
            dgvCuotasPagas.DataSource = null;
            //dgvCuotasPagas.DataSource = vistaCuota.retornaListaCuotasVista(listaCuotas);
            construirDGVCuotasPagas();
        }

        //VERIFICACIONES
        private bool verificarCamposAlumno()
        {
            bool camposCompletos = true;

            if (String.IsNullOrEmpty(txtLegajo.Text) ||
                String.IsNullOrEmpty(txtNombre.Text) ||
                String.IsNullOrEmpty(txtApellido.Text) ||
                String.IsNullOrEmpty(txtDNI.Text) ||
                (!rbIngresante.Checked && !rbGrado.Checked && !rbPosgrado.Checked))
            {
                camposCompletos = false;
            }
            return camposCompletos;
        }

        private bool verificarCamposBeca()
        {
            bool camposCompletos = true;

            if (String.IsNullOrEmpty(txtCodigo.Text) ||
                String.IsNullOrEmpty(txtImporteBeca.Text))
            {
                camposCompletos = false;
            }
            return camposCompletos;
        }

        private bool verificarCamposCuota()
        {
            bool camposCompletos = true;

            if (String.IsNullOrEmpty(txtId.Text) ||
                String.IsNullOrEmpty(txtMes.Text) ||
                String.IsNullOrEmpty(txtAnho.Text))
            {
                camposCompletos = false;
            }
            return camposCompletos;
        }

        private bool legajoExistente()
        {
            bool legajoExistente = false;

            List<Alumno> listaAlumnosAux = universidad.retornarListaAlumnosUniversidad();

            if (listaAlumnosAux.Count != 0)
            {
                if (listaAlumnosAux.Exists(x => x.Legajo == txtLegajo.Text))
                {
                    legajoExistente = true;
                }
            }
            return legajoExistente;
        }

        private bool verificarIdCuota()
        {
            bool idCuotaExistente = false;

            foreach (Cuota cuota in listaCuotas)
            {
                if (String.Equals(cuota.Id, txtId.Text))
                {
                    idCuotaExistente = true;
                }
            }
            return idCuotaExistente;
        }
        private bool verificarCodigo()
        {
            bool codigoExistente = false;

            foreach (Beca beca in listaBecas)
            {
                if (String.Equals(beca.Codigo, txtCodigo.Text))
                {
                    codigoExistente = true;
                }
            }
            return codigoExistente;
        }
        private bool verificarCodigoAlfanumerico()  //VERIFICACION CON Regex.IsMatch();
        {
            bool codigoOk = false;
            string codigo = txtCodigo.Text;
            codigoOk = Regex.IsMatch(codigo, @"^\d{4}[a-zA-Z]{2}$");
            return codigoOk;
        }

        //LIMITACION CAMPOS
        private void txtLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(e);
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
        private void txtImporteBeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosDecimales(e);
        }
        private void txtValorCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosDecimales(e);
        }
        public void soloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                            (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite letras", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        public void soloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }
        public void soloNumerosDecimales(KeyPressEventArgs e)
        {
            //Verificar solo numeros -- admite (,)
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) ||
                (e.KeyChar >= 45 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Este campo solo admite numeros enteros o de punto flotante", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void rbIngresante_MouseClick(object sender, MouseEventArgs e)
        {
            lblNumeroGrupo.Text = "1";
        }

        private void rbGrado_CheckedChanged(object sender, EventArgs e)
        {
            lblNumeroGrupo.Text = "2";
        }

        private void rbPosgrado_CheckedChanged(object sender, EventArgs e)
        {
            lblNumeroGrupo.Text = "3";
        }

        public void modificarAlumno(Alumno alumnoSeleccionado)
        {
            DialogResult result = MessageBox.Show("Realmente desea modificar el alumno seleccionado?",
                                "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                alumnoSeleccionado.Legajo = txtLegajo.Text;
                alumnoSeleccionado.Nombre = txtNombre.Text;
                alumnoSeleccionado.Apellido = txtApellido.Text;
                alumnoSeleccionado.DNI = txtDNI.Text;
                alumnoSeleccionado.Grupo = Convert.ToInt32(lblNumeroGrupo.Text);

                universidad.modificarAlumno(alumnoSeleccionado);
                agregarListaAlumnoaDGV(universidad.retornarListaAlumnosUniversidad());
            }
        }

        private void btnModificarAlumno_Click_1(object sender, EventArgs e)
        {
            List<Alumno> listaAlumnosAux = universidad.retornarListaAlumnosUniversidad();
            Alumno alumnoSeleccionado = devuelveAlumnoSeleccionado();

            if (listaAlumnosAux.Count != 0)
            {
                if (listaAlumnosAux.Exists(x => x.Legajo == alumnoSeleccionado.Legajo))
                {
                    if (alumnoSeleccionado.Legajo != txtLegajo.Text ||
                        alumnoSeleccionado.Nombre != txtNombre.Text ||
                        alumnoSeleccionado.Apellido != txtApellido.Text ||
                        alumnoSeleccionado.DNI != txtDNI.Text ||
                        alumnoSeleccionado.Grupo.ToString() != lblNumeroGrupo.Text)
                    {
                        modificarAlumno(alumnoSeleccionado);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente desea eliminar el alumno seleccionado?",
                                "titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                universidad.eliminarAlumnoDeUniversidad(devuelveAlumnoSeleccionado());
                agregarListaAlumnoaDGV(universidad.retornarListaAlumnosUniversidad());
            }
        }
    }
}
