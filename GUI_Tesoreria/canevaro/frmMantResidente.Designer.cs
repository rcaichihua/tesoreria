namespace GUI_Tesoreria.canevaro
{
    partial class frmMantResidente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvResidente = new System.Windows.Forms.DataGridView();
            this.IDResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagoResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAnulado = new System.Windows.Forms.RadioButton();
            this.rdbEgreso = new System.Windows.Forms.RadioButton();
            this.rdbFallecio = new System.Windows.Forms.RadioButton();
            this.txtFechaBaja = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaIngreso = new System.Windows.Forms.MaskedTextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNroPabellon = new System.Windows.Forms.ComboBox();
            this.cboPabellon = new System.Windows.Forms.ComboBox();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.cboDireccion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCentroGerontologico = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApeMat = new System.Windows.Forms.TextBox();
            this.txtApePat = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnGenerarCtaCte = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidente)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(280, 431);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 497);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(120, 431);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(120, 497);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(200, 431);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(280, 497);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvResidente);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(359, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 464);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            // 
            // dgvResidente
            // 
            this.dgvResidente.AllowUserToAddRows = false;
            this.dgvResidente.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResidente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResidente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDResidente,
            this.DniResidente,
            this.ApellidosResidente,
            this.NombresResidente,
            this.FechaIngresoResidente,
            this.TipoPagoResidente,
            this.DireccionResidente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResidente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResidente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResidente.EnableHeadersVisualStyles = false;
            this.dgvResidente.Location = new System.Drawing.Point(3, 16);
            this.dgvResidente.Name = "dgvResidente";
            this.dgvResidente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResidente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResidente.RowHeadersWidth = 21;
            this.dgvResidente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResidente.Size = new System.Drawing.Size(615, 445);
            this.dgvResidente.TabIndex = 0;
            this.dgvResidente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResidente_CellEnter);
            this.dgvResidente.CurrentCellChanged += new System.EventHandler(this.dgvResidente_CurrentCellChanged);
            this.dgvResidente.Click += new System.EventHandler(this.dgvResidente_Click);
            // 
            // IDResidente
            // 
            this.IDResidente.DataPropertyName = "residenteId";
            this.IDResidente.HeaderText = "ID";
            this.IDResidente.Name = "IDResidente";
            this.IDResidente.ReadOnly = true;
            this.IDResidente.Visible = false;
            // 
            // DniResidente
            // 
            this.DniResidente.DataPropertyName = "dniResidente";
            this.DniResidente.HeaderText = "DNI";
            this.DniResidente.Name = "DniResidente";
            this.DniResidente.ReadOnly = true;
            this.DniResidente.Width = 80;
            // 
            // ApellidosResidente
            // 
            this.ApellidosResidente.DataPropertyName = "apellidosResidente";
            this.ApellidosResidente.HeaderText = "Apellidos";
            this.ApellidosResidente.Name = "ApellidosResidente";
            this.ApellidosResidente.ReadOnly = true;
            this.ApellidosResidente.Width = 200;
            // 
            // NombresResidente
            // 
            this.NombresResidente.DataPropertyName = "NombreResidente";
            this.NombresResidente.HeaderText = "Nombres";
            this.NombresResidente.Name = "NombresResidente";
            this.NombresResidente.ReadOnly = true;
            this.NombresResidente.Width = 120;
            // 
            // FechaIngresoResidente
            // 
            this.FechaIngresoResidente.DataPropertyName = "FechaIngresoResidente";
            this.FechaIngresoResidente.HeaderText = "F. Ingreso";
            this.FechaIngresoResidente.Name = "FechaIngresoResidente";
            this.FechaIngresoResidente.ReadOnly = true;
            this.FechaIngresoResidente.Width = 90;
            // 
            // TipoPagoResidente
            // 
            this.TipoPagoResidente.DataPropertyName = "descripcionTipoPagoResidenteID";
            this.TipoPagoResidente.HeaderText = "Tipo Pago";
            this.TipoPagoResidente.Name = "TipoPagoResidente";
            this.TipoPagoResidente.ReadOnly = true;
            this.TipoPagoResidente.Width = 120;
            // 
            // DireccionResidente
            // 
            this.DireccionResidente.DataPropertyName = "NombreDireccion";
            this.DireccionResidente.HeaderText = "Centro";
            this.DireccionResidente.Name = "DireccionResidente";
            this.DireccionResidente.ReadOnly = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.rdbAnulado);
            this.GroupBox1.Controls.Add(this.rdbEgreso);
            this.GroupBox1.Controls.Add(this.rdbFallecio);
            this.GroupBox1.Controls.Add(this.txtFechaBaja);
            this.GroupBox1.Controls.Add(this.txtFechaIngreso);
            this.GroupBox1.Controls.Add(this.chkEstado);
            this.GroupBox1.Controls.Add(this.label13);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.cboNroPabellon);
            this.GroupBox1.Controls.Add(this.cboPabellon);
            this.GroupBox1.Controls.Add(this.cboTipoPago);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.txtNombres);
            this.GroupBox1.Controls.Add(this.cboDireccion);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.cboCentroGerontologico);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.lbl12);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.txtApeMat);
            this.GroupBox1.Controls.Add(this.txtApePat);
            this.GroupBox1.Controls.Add(this.txtDni);
            this.GroupBox1.Controls.Add(this.txtHabitacion);
            this.GroupBox1.Controls.Add(this.txtId);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Navy;
            this.GroupBox1.Location = new System.Drawing.Point(10, 65);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(342, 359);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // rdbAnulado
            // 
            this.rdbAnulado.AutoSize = true;
            this.rdbAnulado.Checked = true;
            this.rdbAnulado.Enabled = false;
            this.rdbAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnulado.Location = new System.Drawing.Point(270, 269);
            this.rdbAnulado.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAnulado.Name = "rdbAnulado";
            this.rdbAnulado.Size = new System.Drawing.Size(71, 17);
            this.rdbAnulado.TabIndex = 15;
            this.rdbAnulado.TabStop = true;
            this.rdbAnulado.Text = "Anulado";
            this.rdbAnulado.UseVisualStyleBackColor = true;
            // 
            // rdbEgreso
            // 
            this.rdbEgreso.AutoSize = true;
            this.rdbEgreso.Enabled = false;
            this.rdbEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEgreso.Location = new System.Drawing.Point(270, 251);
            this.rdbEgreso.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEgreso.Name = "rdbEgreso";
            this.rdbEgreso.Size = new System.Drawing.Size(64, 17);
            this.rdbEgreso.TabIndex = 15;
            this.rdbEgreso.Text = "Egresó";
            this.rdbEgreso.UseVisualStyleBackColor = true;
            // 
            // rdbFallecio
            // 
            this.rdbFallecio.AutoSize = true;
            this.rdbFallecio.Enabled = false;
            this.rdbFallecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFallecio.Location = new System.Drawing.Point(270, 233);
            this.rdbFallecio.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFallecio.Name = "rdbFallecio";
            this.rdbFallecio.Size = new System.Drawing.Size(71, 17);
            this.rdbFallecio.TabIndex = 15;
            this.rdbFallecio.Text = "Fallecío";
            this.rdbFallecio.UseVisualStyleBackColor = true;
            // 
            // txtFechaBaja
            // 
            this.txtFechaBaja.Enabled = false;
            this.txtFechaBaja.Location = new System.Drawing.Point(188, 263);
            this.txtFechaBaja.Mask = "00/00/0000";
            this.txtFechaBaja.Name = "txtFechaBaja";
            this.txtFechaBaja.Size = new System.Drawing.Size(75, 21);
            this.txtFechaBaja.TabIndex = 14;
            this.txtFechaBaja.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaIngreso
            // 
            this.txtFechaIngreso.Location = new System.Drawing.Point(134, 151);
            this.txtFechaIngreso.Mask = "00/00/0000";
            this.txtFechaIngreso.Name = "txtFechaIngreso";
            this.txtFechaIngreso.Size = new System.Drawing.Size(100, 21);
            this.txtFechaIngreso.TabIndex = 13;
            this.txtFechaIngreso.ValidatingType = typeof(System.DateTime);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkEstado.Location = new System.Drawing.Point(190, 239);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(73, 19);
            this.chkEstado.TabIndex = 11;
            this.chkEstado.Text = "ACTIVO";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(64, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 6;
            this.label13.Text = "Pabellon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(56, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(30, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(44, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ap. Materno";
            // 
            // cboNroPabellon
            // 
            this.cboNroPabellon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNroPabellon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNroPabellon.FormattingEnabled = true;
            this.cboNroPabellon.Items.AddRange(new object[] {
            "[seleccione]",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboNroPabellon.Location = new System.Drawing.Point(134, 237);
            this.cboNroPabellon.Name = "cboNroPabellon";
            this.cboNroPabellon.Size = new System.Drawing.Size(49, 23);
            this.cboNroPabellon.TabIndex = 7;
            // 
            // cboPabellon
            // 
            this.cboPabellon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPabellon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPabellon.FormattingEnabled = true;
            this.cboPabellon.Location = new System.Drawing.Point(134, 208);
            this.cboPabellon.Name = "cboPabellon";
            this.cboPabellon.Size = new System.Drawing.Size(184, 23);
            this.cboPabellon.TabIndex = 6;
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(134, 179);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(184, 23);
            this.cboTipoPago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(47, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ap. Paterno";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(14, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "C. Gerontológico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(97, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "DNI";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(134, 125);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(184, 21);
            this.txtNombres.TabIndex = 1;
            // 
            // cboDireccion
            // 
            this.cboDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDireccion.FormattingEnabled = true;
            this.cboDireccion.Location = new System.Drawing.Point(134, 291);
            this.cboDireccion.Name = "cboDireccion";
            this.cboDireccion.Size = new System.Drawing.Size(184, 23);
            this.cboDireccion.TabIndex = 9;
            this.cboDireccion.SelectedIndexChanged += new System.EventHandler(this.cboDireccion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(45, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nº Pabellón";
            // 
            // cboCentroGerontologico
            // 
            this.cboCentroGerontologico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCentroGerontologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCentroGerontologico.FormattingEnabled = true;
            this.cboCentroGerontologico.Items.AddRange(new object[] {
            "[seleccione]"});
            this.cboCentroGerontologico.Location = new System.Drawing.Point(134, 318);
            this.cboCentroGerontologico.Name = "cboCentroGerontologico";
            this.cboCentroGerontologico.Size = new System.Drawing.Size(184, 23);
            this.cboCentroGerontologico.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(52, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Habitación";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl12.Location = new System.Drawing.Point(107, 20);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(21, 15);
            this.lbl12.TabIndex = 2;
            this.lbl12.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(60, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Dirección";
            // 
            // txtApeMat
            // 
            this.txtApeMat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApeMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeMat.Location = new System.Drawing.Point(134, 98);
            this.txtApeMat.Name = "txtApeMat";
            this.txtApeMat.Size = new System.Drawing.Size(184, 21);
            this.txtApeMat.TabIndex = 3;
            // 
            // txtApePat
            // 
            this.txtApePat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApePat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePat.Location = new System.Drawing.Point(134, 71);
            this.txtApePat.Name = "txtApePat";
            this.txtApePat.Size = new System.Drawing.Size(184, 21);
            this.txtApePat.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(134, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(184, 21);
            this.txtDni.TabIndex = 0;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabitacion.Location = new System.Drawing.Point(134, 264);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(49, 21);
            this.txtHabitacion.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(134, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 21);
            this.txtId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(412, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 108;
            this.label2.Text = "Filtro por Apellido Paterno";
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(593, 67);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(134, 21);
            this.txtFiltro.TabIndex = 107;
            // 
            // btnGenerarCtaCte
            // 
            this.btnGenerarCtaCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerarCtaCte.ForeColor = System.Drawing.Color.Navy;
            this.btnGenerarCtaCte.Location = new System.Drawing.Point(10, 431);
            this.btnGenerarCtaCte.Name = "btnGenerarCtaCte";
            this.btnGenerarCtaCte.Size = new System.Drawing.Size(106, 58);
            this.btnGenerarCtaCte.TabIndex = 1;
            this.btnGenerarCtaCte.Text = "&Generar Cuenta Corriente";
            this.btnGenerarCtaCte.UseVisualStyleBackColor = true;
            this.btnGenerarCtaCte.Click += new System.EventHandler(this.btnGenerarCtaCte_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.Navy;
            this.btnAplicar.Location = new System.Drawing.Point(834, 58);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(47, 38);
            this.btnAplicar.TabIndex = 109;
            this.btnAplicar.Text = "OK";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Visible = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Navy;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-1, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(993, 42);
            this.label12.TabIndex = 110;
            this.label12.Text = "MANTENIMIENTO DE RESIDENTES";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistros.Location = new System.Drawing.Point(914, 65);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(59, 15);
            this.lblRegistros.TabIndex = 111;
            this.lblRegistros.Text = "1 de 100";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Navy;
            this.btnFiltrar.Location = new System.Drawing.Point(733, 58);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(65, 38);
            this.btnFiltrar.TabIndex = 109;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmMantResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 569);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnGenerarCtaCte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMantResidente";
            this.Text = "...Mantenimiento Residente:::...";
            this.Load += new System.EventHandler(this.frmMantResidente_Load);
            this.Controls.SetChildIndex(this.GroupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.txtFiltro, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnGenerarCtaCte, 0);
            this.Controls.SetChildIndex(this.btnAplicar, 0);
            this.Controls.SetChildIndex(this.btnFiltrar, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidente)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResidente;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lbl12;
        internal System.Windows.Forms.TextBox txtApeMat;
        internal System.Windows.Forms.TextBox txtApePat;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.TextBox txtDni;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox cboTipoPago;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cboDireccion;
        internal System.Windows.Forms.ComboBox cboCentroGerontologico;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtHabitacion;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnGenerarCtaCte;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.ComboBox cboPabellon;
        internal System.Windows.Forms.ComboBox cboNroPabellon;
        internal System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.MaskedTextBox txtFechaBaja;
        private System.Windows.Forms.MaskedTextBox txtFechaIngreso;
        private System.Windows.Forms.RadioButton rdbEgreso;
        private System.Windows.Forms.RadioButton rdbFallecio;
        private System.Windows.Forms.RadioButton rdbAnulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagoResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionResidente;
    }
}