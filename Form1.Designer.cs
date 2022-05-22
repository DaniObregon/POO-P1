namespace _1erParcial_POO_Obregon
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nUpDownGrupo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBeneficiario = new System.Windows.Forms.TextBox();
            this.dtpFechaDeOtorgamiento = new System.Windows.Forms.DateTimePicker();
            this.btnAsignarBecaAlumno = new System.Windows.Forms.Button();
            this.dgvAlumnoSeleccionado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaOtorgamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPagarCuota = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.dtpFechaDePago = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtImporteBeca = new System.Windows.Forms.TextBox();
            this.dgvCuotasPagas = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.btnAgregarBeca = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnQuitarBecaAlumno = new System.Windows.Forms.Button();
            this.btnEliminarBeca = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtValorCuota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoSeleccionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Location = new System.Drawing.Point(24, 70);
            this.dgvAlumno.MultiSelect = false;
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowHeadersWidth = 51;
            this.dgvAlumno.RowTemplate.Height = 24;
            this.dgvAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumno.Size = new System.Drawing.Size(460, 221);
            this.dgvAlumno.TabIndex = 38;
            this.dgvAlumno.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumno_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beneficiarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Becas";
            // 
            // dgvBecas
            // 
            this.dgvBecas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Location = new System.Drawing.Point(692, 70);
            this.dgvBecas.MultiSelect = false;
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.RowHeadersWidth = 51;
            this.dgvBecas.RowTemplate.Height = 24;
            this.dgvBecas.Size = new System.Drawing.Size(352, 221);
            this.dgvBecas.TabIndex = 66;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(515, 123);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // nUpDownGrupo
            // 
            this.nUpDownGrupo.Location = new System.Drawing.Point(515, 282);
            this.nUpDownGrupo.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUpDownGrupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownGrupo.Name = "nUpDownGrupo";
            this.nUpDownGrupo.Size = new System.Drawing.Size(100, 22);
            this.nUpDownGrupo.TabIndex = 4;
            this.nUpDownGrupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(515, 176);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(515, 229);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 22);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Legajo";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(515, 70);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 22);
            this.txtLegajo.TabIndex = 0;
            this.txtLegajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLegajo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(522, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Grupo*";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(39, 322);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(126, 39);
            this.btnAgregarAlumno.TabIndex = 6;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Location = new System.Drawing.Point(191, 322);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(126, 39);
            this.btnEliminarAlumno.TabIndex = 18;
            this.btnEliminarAlumno.Text = "Eliminar Alumno";
            this.btnEliminarAlumno.UseVisualStyleBackColor = true;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(31, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "*Grupo:  1 Ingresante  2 Grado  3 Posgrado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1069, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(1062, 70);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(191, 22);
            this.txtCodigo.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(966, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Beneficiario";
            // 
            // txtBeneficiario
            // 
            this.txtBeneficiario.Location = new System.Drawing.Point(959, 316);
            this.txtBeneficiario.Name = "txtBeneficiario";
            this.txtBeneficiario.Size = new System.Drawing.Size(100, 22);
            this.txtBeneficiario.TabIndex = 22;
            // 
            // dtpFechaDeOtorgamiento
            // 
            this.dtpFechaDeOtorgamiento.Location = new System.Drawing.Point(1062, 176);
            this.dtpFechaDeOtorgamiento.Name = "dtpFechaDeOtorgamiento";
            this.dtpFechaDeOtorgamiento.Size = new System.Drawing.Size(191, 22);
            this.dtpFechaDeOtorgamiento.TabIndex = 25;
            // 
            // btnAsignarBecaAlumno
            // 
            this.btnAsignarBecaAlumno.Location = new System.Drawing.Point(814, 297);
            this.btnAsignarBecaAlumno.Name = "btnAsignarBecaAlumno";
            this.btnAsignarBecaAlumno.Size = new System.Drawing.Size(104, 41);
            this.btnAsignarBecaAlumno.TabIndex = 26;
            this.btnAsignarBecaAlumno.Text = "Asignar beca";
            this.btnAsignarBecaAlumno.UseVisualStyleBackColor = true;
            this.btnAsignarBecaAlumno.Click += new System.EventHandler(this.btnAsignarBeca_Click);
            // 
            // dgvAlumnoSeleccionado
            // 
            this.dgvAlumnoSeleccionado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnoSeleccionado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoSeleccionado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.fechaOtorgamiento,
            this.importe});
            this.dgvAlumnoSeleccionado.Location = new System.Drawing.Point(36, 422);
            this.dgvAlumnoSeleccionado.MultiSelect = false;
            this.dgvAlumnoSeleccionado.Name = "dgvAlumnoSeleccionado";
            this.dgvAlumnoSeleccionado.RowHeadersWidth = 51;
            this.dgvAlumnoSeleccionado.RowTemplate.Height = 24;
            this.dgvAlumnoSeleccionado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoSeleccionado.Size = new System.Drawing.Size(331, 253);
            this.dgvAlumnoSeleccionado.TabIndex = 39;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            // 
            // fechaOtorgamiento
            // 
            this.fechaOtorgamiento.HeaderText = "Fecha de Otorgamiento";
            this.fechaOtorgamiento.MinimumWidth = 6;
            this.fechaOtorgamiento.Name = "fechaOtorgamiento";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(49, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 16);
            this.label11.TabIndex = 41;
            this.label11.Text = "Becas del beneficiario seleccionado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(459, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "Cuotas pagas del alumno seleccionado";
            // 
            // btnPagarCuota
            // 
            this.btnPagarCuota.Location = new System.Drawing.Point(742, 679);
            this.btnPagarCuota.Name = "btnPagarCuota";
            this.btnPagarCuota.Size = new System.Drawing.Size(126, 39);
            this.btnPagarCuota.TabIndex = 48;
            this.btnPagarCuota.Text = "Pagar cuota";
            this.btnPagarCuota.UseVisualStyleBackColor = true;
            this.btnPagarCuota.Click += new System.EventHandler(this.btnPagarCuota_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1194, 583);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 53;
            this.label13.Text = "Fechas de pago";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1194, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1187, 439);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1194, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 50;
            this.label16.Text = "Ano (4 digitos)";
            // 
            // txtAnho
            // 
            this.txtAnho.Location = new System.Drawing.Point(1187, 545);
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(100, 22);
            this.txtAnho.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1194, 473);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 49;
            this.label17.Text = "Mes (2 digitos)";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(1187, 492);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 45;
            // 
            // dtpFechaDePago
            // 
            this.dtpFechaDePago.Location = new System.Drawing.Point(1187, 602);
            this.dtpFechaDePago.Name = "dtpFechaDePago";
            this.dtpFechaDePago.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaDePago.TabIndex = 54;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1069, 104);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 56;
            this.label18.Text = "Importe";
            // 
            // txtImporteBeca
            // 
            this.txtImporteBeca.Location = new System.Drawing.Point(1062, 123);
            this.txtImporteBeca.Name = "txtImporteBeca";
            this.txtImporteBeca.Size = new System.Drawing.Size(191, 22);
            this.txtImporteBeca.TabIndex = 22;
            this.txtImporteBeca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporteBeca_KeyPress);
            // 
            // dgvCuotasPagas
            // 
            this.dgvCuotasPagas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuotasPagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotasPagas.Location = new System.Drawing.Point(430, 422);
            this.dgvCuotasPagas.MultiSelect = false;
            this.dgvCuotasPagas.Name = "dgvCuotasPagas";
            this.dgvCuotasPagas.RowHeadersWidth = 51;
            this.dgvCuotasPagas.RowTemplate.Height = 24;
            this.dgvCuotasPagas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuotasPagas.Size = new System.Drawing.Size(737, 251);
            this.dgvCuotasPagas.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(1059, 157);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 16);
            this.label19.TabIndex = 58;
            this.label19.Text = "Fecha de Otorgamiento";
            // 
            // btnAgregarBeca
            // 
            this.btnAgregarBeca.Location = new System.Drawing.Point(1072, 221);
            this.btnAgregarBeca.Name = "btnAgregarBeca";
            this.btnAgregarBeca.Size = new System.Drawing.Size(174, 30);
            this.btnAgregarBeca.TabIndex = 59;
            this.btnAgregarBeca.Text = "Registrar Beca";
            this.btnAgregarBeca.UseVisualStyleBackColor = true;
            this.btnAgregarBeca.Click += new System.EventHandler(this.btnAgregarBeca_Click);
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Location = new System.Drawing.Point(337, 322);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(126, 39);
            this.btnModificarAlumno.TabIndex = 67;
            this.btnModificarAlumno.Text = "Modificar Alumno";
            this.btnModificarAlumno.UseVisualStyleBackColor = true;
            this.btnModificarAlumno.Click += new System.EventHandler(this.btnModificarAlumno_Click);
            // 
            // btnQuitarBecaAlumno
            // 
            this.btnQuitarBecaAlumno.Location = new System.Drawing.Point(138, 681);
            this.btnQuitarBecaAlumno.Name = "btnQuitarBecaAlumno";
            this.btnQuitarBecaAlumno.Size = new System.Drawing.Size(115, 41);
            this.btnQuitarBecaAlumno.TabIndex = 68;
            this.btnQuitarBecaAlumno.Text = "Rescindir beca";
            this.btnQuitarBecaAlumno.UseVisualStyleBackColor = true;
            this.btnQuitarBecaAlumno.Click += new System.EventHandler(this.btnQuitarBecaAlumno_Click);
            // 
            // btnEliminarBeca
            // 
            this.btnEliminarBeca.Location = new System.Drawing.Point(1072, 265);
            this.btnEliminarBeca.Name = "btnEliminarBeca";
            this.btnEliminarBeca.Size = new System.Drawing.Size(174, 30);
            this.btnEliminarBeca.TabIndex = 69;
            this.btnEliminarBeca.Text = "Eliminar Beca";
            this.btnEliminarBeca.UseVisualStyleBackColor = true;
            this.btnEliminarBeca.Click += new System.EventHandler(this.btnEliminarBeca_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(522, 319);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 71;
            this.label20.Text = "Valor Cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(515, 338);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(100, 22);
            this.txtValorCuota.TabIndex = 70;
            this.txtValorCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCuota_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 745);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtValorCuota);
            this.Controls.Add(this.btnEliminarBeca);
            this.Controls.Add(this.btnQuitarBecaAlumno);
            this.Controls.Add(this.btnModificarAlumno);
            this.Controls.Add(this.btnAgregarBeca);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dgvCuotasPagas);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtImporteBeca);
            this.Controls.Add(this.dtpFechaDePago);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAnho);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnPagarCuota);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvAlumnoSeleccionado);
            this.Controls.Add(this.btnAsignarBecaAlumno);
            this.Controls.Add(this.dtpFechaDeOtorgamiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBeneficiario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarAlumno);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUpDownGrupo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoSeleccionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nUpDownGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBeneficiario;
        private System.Windows.Forms.DateTimePicker dtpFechaDeOtorgamiento;
        private System.Windows.Forms.Button btnAsignarBecaAlumno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPagarCuota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.DateTimePicker dtpFechaDePago;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtImporteBeca;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnAgregarBeca;
        public System.Windows.Forms.DataGridView dgvBecas;
        public System.Windows.Forms.DataGridView dgvAlumno;
        public System.Windows.Forms.DataGridView dgvAlumnoSeleccionado;
        public System.Windows.Forms.DataGridView dgvCuotasPagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaOtorgamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnQuitarBecaAlumno;
        private System.Windows.Forms.Button btnEliminarBeca;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtValorCuota;
    }
}

