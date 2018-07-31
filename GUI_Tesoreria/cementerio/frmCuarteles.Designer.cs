namespace GUI_Tesoreria.cementerio
{
    partial class frmCuarteles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTipoCuartel = new System.Windows.Forms.ComboBox();
            this.txtNombreCuartel = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPuerta = new System.Windows.Forms.ComboBox();
            this.nuColumnas = new System.Windows.Forms.NumericUpDown();
            this.nuFila = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCementerio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCuarteles = new System.Windows.Forms.DataGridView();
            this.CODCUARTEL_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LETRAFILANICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPabellon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.CODCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPOCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROFILACUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROCOLUMNACUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuColumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFila)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuarteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoCuartel);
            this.groupBox1.Controls.Add(this.txtNombreCuartel);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboTipoCuartel
            // 
            this.cboTipoCuartel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoCuartel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoCuartel.FormattingEnabled = true;
            this.cboTipoCuartel.Location = new System.Drawing.Point(91, 14);
            this.cboTipoCuartel.Name = "cboTipoCuartel";
            this.cboTipoCuartel.Size = new System.Drawing.Size(180, 23);
            this.cboTipoCuartel.TabIndex = 0;
            // 
            // txtNombreCuartel
            // 
            this.txtNombreCuartel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCuartel.Location = new System.Drawing.Point(91, 43);
            this.txtNombreCuartel.Name = "txtNombreCuartel";
            this.txtNombreCuartel.Size = new System.Drawing.Size(312, 20);
            this.txtNombreCuartel.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(330, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(73, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre cuartel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cuartel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPuerta);
            this.groupBox2.Controls.Add(this.nuColumnas);
            this.groupBox2.Controls.Add(this.nuFila);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // cboPuerta
            // 
            this.cboPuerta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPuerta.FormattingEnabled = true;
            this.cboPuerta.Items.AddRange(new object[] {
            "NINGUNA",
            "1RA PUERTA",
            "2DA PUERTA",
            "3RA PUERTA",
            "4TA PUERTA",
            "5TA PUERTA",
            "6TA PUERTA"});
            this.cboPuerta.Location = new System.Drawing.Point(416, 11);
            this.cboPuerta.Name = "cboPuerta";
            this.cboPuerta.Size = new System.Drawing.Size(118, 23);
            this.cboPuerta.TabIndex = 2;
            // 
            // nuColumnas
            // 
            this.nuColumnas.Location = new System.Drawing.Point(295, 14);
            this.nuColumnas.Name = "nuColumnas";
            this.nuColumnas.Size = new System.Drawing.Size(71, 20);
            this.nuColumnas.TabIndex = 1;
            // 
            // nuFila
            // 
            this.nuFila.Location = new System.Drawing.Point(95, 14);
            this.nuFila.Name = "nuFila";
            this.nuFila.Size = new System.Drawing.Size(71, 20);
            this.nuFila.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(372, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Puerta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Número de Columnas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de Filas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cementerio";
            // 
            // cboCementerio
            // 
            this.cboCementerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCementerio.FormattingEnabled = true;
            this.cboCementerio.Location = new System.Drawing.Point(103, 147);
            this.cboCementerio.Name = "cboCementerio";
            this.cboCementerio.Size = new System.Drawing.Size(180, 23);
            this.cboCementerio.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(12, 191);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(540, 46);
            this.txtObservacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Material";
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(351, 147);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(201, 23);
            this.cboMaterial.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(446, 18);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 31);
            this.btnGenerar.TabIndex = 12;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCuarteles);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 196);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // dgvCuarteles
            // 
            this.dgvCuarteles.AllowUserToAddRows = false;
            this.dgvCuarteles.AllowUserToDeleteRows = false;
            this.dgvCuarteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCuarteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuarteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCUARTEL_,
            this.LETRAFILANICHO,
            this.Columna,
            this.Material,
            this.TipoPabellon,
            this.Estado,
            this.Observaciones});
            this.dgvCuarteles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuarteles.Location = new System.Drawing.Point(3, 16);
            this.dgvCuarteles.Name = "dgvCuarteles";
            this.dgvCuarteles.ReadOnly = true;
            this.dgvCuarteles.RowHeadersWidth = 25;
            this.dgvCuarteles.Size = new System.Drawing.Size(534, 177);
            this.dgvCuarteles.TabIndex = 0;
            // 
            // CODCUARTEL_
            // 
            this.CODCUARTEL_.DataPropertyName = "CODCUARTEL";
            this.CODCUARTEL_.HeaderText = "CODCUARTEL";
            this.CODCUARTEL_.Name = "CODCUARTEL_";
            this.CODCUARTEL_.ReadOnly = true;
            this.CODCUARTEL_.Visible = false;
            // 
            // LETRAFILANICHO
            // 
            this.LETRAFILANICHO.DataPropertyName = "LETRAFILANICHO";
            this.LETRAFILANICHO.HeaderText = "Fila";
            this.LETRAFILANICHO.Name = "LETRAFILANICHO";
            this.LETRAFILANICHO.ReadOnly = true;
            // 
            // Columna
            // 
            this.Columna.DataPropertyName = "NUMEROCOLNICHO";
            this.Columna.HeaderText = "Columna";
            this.Columna.Name = "Columna";
            this.Columna.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.DataPropertyName = "NOMBREMATERIAL";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // TipoPabellon
            // 
            this.TipoPabellon.DataPropertyName = "DESCRIPTIPOCUARTEL";
            this.TipoPabellon.HeaderText = "Tipo Cuartel";
            this.TipoPabellon.Name = "TipoPabellon";
            this.TipoPabellon.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "DESCRIPESTADO";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.DataPropertyName = "OBSERVACIONNICHO";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(195, 443);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(282, 443);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(456, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 31);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(446, 52);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 31);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(20, 443);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 31);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(108, 443);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 31);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODCUARTEL,
            this.CODTIPOCUARTEL,
            this.CODMATERIAL,
            this.NOMBRECUARTEL,
            this.NROFILACUARTEL,
            this.NROCOLUMNACUARTEL,
            this.CODCEMENTERIO,
            this.NOMBRECEMENTERIO,
            this.PUERTA,
            this.OBSCUARTEL});
            this.dgvResultado.Location = new System.Drawing.Point(103, 74);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(312, 173);
            this.dgvResultado.TabIndex = 38;
            this.dgvResultado.Visible = false;
            this.dgvResultado.DoubleClick += new System.EventHandler(this.dgvResultado_DoubleClick);
            this.dgvResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvResultado_KeyDown);
            this.dgvResultado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvResultado_KeyPress);
            // 
            // CODCUARTEL
            // 
            this.CODCUARTEL.DataPropertyName = "CODCUARTEL";
            this.CODCUARTEL.HeaderText = "CODCUARTEL";
            this.CODCUARTEL.Name = "CODCUARTEL";
            this.CODCUARTEL.ReadOnly = true;
            this.CODCUARTEL.Visible = false;
            this.CODCUARTEL.Width = 60;
            // 
            // CODTIPOCUARTEL
            // 
            this.CODTIPOCUARTEL.DataPropertyName = "CODTIPOCUARTEL";
            this.CODTIPOCUARTEL.HeaderText = "CODTIPOCUARTEL";
            this.CODTIPOCUARTEL.Name = "CODTIPOCUARTEL";
            this.CODTIPOCUARTEL.ReadOnly = true;
            this.CODTIPOCUARTEL.Visible = false;
            // 
            // CODMATERIAL
            // 
            this.CODMATERIAL.DataPropertyName = "CODMATERIAL";
            this.CODMATERIAL.HeaderText = "CODMATERIAL";
            this.CODMATERIAL.Name = "CODMATERIAL";
            this.CODMATERIAL.ReadOnly = true;
            this.CODMATERIAL.Visible = false;
            // 
            // NOMBRECUARTEL
            // 
            this.NOMBRECUARTEL.DataPropertyName = "NOMBRECUARTEL";
            this.NOMBRECUARTEL.HeaderText = "NOMBRECUARTEL";
            this.NOMBRECUARTEL.Name = "NOMBRECUARTEL";
            this.NOMBRECUARTEL.ReadOnly = true;
            // 
            // NROFILACUARTEL
            // 
            this.NROFILACUARTEL.DataPropertyName = "NROFILACUARTEL";
            this.NROFILACUARTEL.HeaderText = "NROFILACUARTEL";
            this.NROFILACUARTEL.Name = "NROFILACUARTEL";
            this.NROFILACUARTEL.ReadOnly = true;
            this.NROFILACUARTEL.Visible = false;
            // 
            // NROCOLUMNACUARTEL
            // 
            this.NROCOLUMNACUARTEL.DataPropertyName = "NROCOLUMNACUARTEL";
            this.NROCOLUMNACUARTEL.HeaderText = "NROCOLUMNACUARTEL";
            this.NROCOLUMNACUARTEL.Name = "NROCOLUMNACUARTEL";
            this.NROCOLUMNACUARTEL.ReadOnly = true;
            this.NROCOLUMNACUARTEL.Visible = false;
            // 
            // CODCEMENTERIO
            // 
            this.CODCEMENTERIO.DataPropertyName = "CODCEMENTERIO";
            this.CODCEMENTERIO.HeaderText = "CODCEMENTERIO";
            this.CODCEMENTERIO.Name = "CODCEMENTERIO";
            this.CODCEMENTERIO.ReadOnly = true;
            this.CODCEMENTERIO.Visible = false;
            // 
            // NOMBRECEMENTERIO
            // 
            this.NOMBRECEMENTERIO.DataPropertyName = "NOMBRECEMENTERIO";
            this.NOMBRECEMENTERIO.HeaderText = "NOMBRECEMENTERIO";
            this.NOMBRECEMENTERIO.Name = "NOMBRECEMENTERIO";
            this.NOMBRECEMENTERIO.ReadOnly = true;
            // 
            // PUERTA
            // 
            this.PUERTA.DataPropertyName = "PUERTA";
            this.PUERTA.HeaderText = "PUERTA";
            this.PUERTA.Name = "PUERTA";
            this.PUERTA.ReadOnly = true;
            // 
            // OBSCUARTEL
            // 
            this.OBSCUARTEL.DataPropertyName = "OBSCUARTEL";
            this.OBSCUARTEL.HeaderText = "OBSCUARTEL";
            this.OBSCUARTEL.Name = "OBSCUARTEL";
            this.OBSCUARTEL.ReadOnly = true;
            this.OBSCUARTEL.Visible = false;
            // 
            // frmCuarteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 485);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.cboCementerio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCuarteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::: INGRESO DE CUARTELES :::...";
            this.Load += new System.EventHandler(this.frmCuarteles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuColumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFila)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuarteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cboTipoCuartel;
        private System.Windows.Forms.TextBox txtNombreCuartel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nuColumnas;
        private System.Windows.Forms.NumericUpDown nuFila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox cboCementerio;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCuarteles;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnbuscar;
        internal System.Windows.Forms.ComboBox cboPuerta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPOCUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROFILACUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROCOLUMNACUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSCUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCUARTEL_;
        private System.Windows.Forms.DataGridViewTextBoxColumn LETRAFILANICHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPabellon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}