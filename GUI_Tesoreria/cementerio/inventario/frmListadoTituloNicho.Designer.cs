namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmListadoTituloNicho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTitulos = new System.Windows.Forms.DataGridView();
            this.IDTITULONICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROTITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERODOCUMENTOVENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRERESPONSABLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LETRAFILANICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROCOLNICHO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINHUMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHACONCESION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerTitulo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtNombreCuartel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPOCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMATERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROFILACUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROCOLUMNACUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSCUARTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoCuartel = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dgvTitulos);
            this.groupBox3.Location = new System.Drawing.Point(12, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(815, 409);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // dgvTitulos
            // 
            this.dgvTitulos.AllowUserToAddRows = false;
            this.dgvTitulos.AllowUserToDeleteRows = false;
            this.dgvTitulos.AllowUserToResizeColumns = false;
            this.dgvTitulos.AllowUserToResizeRows = false;
            this.dgvTitulos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTitulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTITULONICHO,
            this.NUMEROTITULO,
            this.NUMERODOCUMENTOVENTA,
            this.NOMBRERESPONSABLE,
            this.CEMENTERIO,
            this.CODCUARTEL,
            this.NOMBRECUARTEL,
            this.LETRAFILANICHO,
            this.NUMEROCOLNICHO,
            this.FECHAINHUMACION,
            this.FECHACONCESION});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTitulos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTitulos.Location = new System.Drawing.Point(3, 16);
            this.dgvTitulos.Name = "dgvTitulos";
            this.dgvTitulos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTitulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTitulos.RowHeadersVisible = false;
            this.dgvTitulos.RowHeadersWidth = 10;
            this.dgvTitulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTitulos.Size = new System.Drawing.Size(809, 390);
            this.dgvTitulos.TabIndex = 0;
            // 
            // IDTITULONICHO
            // 
            this.IDTITULONICHO.DataPropertyName = "IDTITULONICHO";
            this.IDTITULONICHO.HeaderText = "IDTITULONICHO";
            this.IDTITULONICHO.Name = "IDTITULONICHO";
            this.IDTITULONICHO.ReadOnly = true;
            this.IDTITULONICHO.Visible = false;
            // 
            // NUMEROTITULO
            // 
            this.NUMEROTITULO.DataPropertyName = "NUMEROTITULO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NUMEROTITULO.DefaultCellStyle = dataGridViewCellStyle2;
            this.NUMEROTITULO.HeaderText = "NRO TITULO";
            this.NUMEROTITULO.Name = "NUMEROTITULO";
            this.NUMEROTITULO.ReadOnly = true;
            this.NUMEROTITULO.Width = 80;
            // 
            // NUMERODOCUMENTOVENTA
            // 
            this.NUMERODOCUMENTOVENTA.DataPropertyName = "NUMERODOCUMENTOVENTA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NUMERODOCUMENTOVENTA.DefaultCellStyle = dataGridViewCellStyle3;
            this.NUMERODOCUMENTOVENTA.HeaderText = "NRO DOC VENTA";
            this.NUMERODOCUMENTOVENTA.Name = "NUMERODOCUMENTOVENTA";
            this.NUMERODOCUMENTOVENTA.ReadOnly = true;
            this.NUMERODOCUMENTOVENTA.Width = 80;
            // 
            // NOMBRERESPONSABLE
            // 
            this.NOMBRERESPONSABLE.DataPropertyName = "NOMBRERESPONSABLE";
            this.NOMBRERESPONSABLE.HeaderText = "NOMBRE RESPONSABLE";
            this.NOMBRERESPONSABLE.Name = "NOMBRERESPONSABLE";
            this.NOMBRERESPONSABLE.ReadOnly = true;
            this.NOMBRERESPONSABLE.Width = 250;
            // 
            // CEMENTERIO
            // 
            this.CEMENTERIO.DataPropertyName = "CEMENTERIO";
            this.CEMENTERIO.HeaderText = "CEMENTERIO";
            this.CEMENTERIO.Name = "CEMENTERIO";
            this.CEMENTERIO.ReadOnly = true;
            this.CEMENTERIO.Width = 150;
            // 
            // CODCUARTEL
            // 
            this.CODCUARTEL.DataPropertyName = "CODCUARTEL";
            this.CODCUARTEL.HeaderText = "CODCUARTEL";
            this.CODCUARTEL.Name = "CODCUARTEL";
            this.CODCUARTEL.ReadOnly = true;
            this.CODCUARTEL.Visible = false;
            // 
            // NOMBRECUARTEL
            // 
            this.NOMBRECUARTEL.DataPropertyName = "NOMBRECUARTEL";
            this.NOMBRECUARTEL.HeaderText = "NOMBRE CUARTEL";
            this.NOMBRECUARTEL.Name = "NOMBRECUARTEL";
            this.NOMBRECUARTEL.ReadOnly = true;
            this.NOMBRECUARTEL.Width = 180;
            // 
            // LETRAFILANICHO
            // 
            this.LETRAFILANICHO.DataPropertyName = "LETRAFILANICHO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.LETRAFILANICHO.DefaultCellStyle = dataGridViewCellStyle4;
            this.LETRAFILANICHO.HeaderText = "FILA";
            this.LETRAFILANICHO.Name = "LETRAFILANICHO";
            this.LETRAFILANICHO.ReadOnly = true;
            this.LETRAFILANICHO.Width = 80;
            // 
            // NUMEROCOLNICHO
            // 
            this.NUMEROCOLNICHO.DataPropertyName = "NUMEROCOLNICHO";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NUMEROCOLNICHO.DefaultCellStyle = dataGridViewCellStyle5;
            this.NUMEROCOLNICHO.HeaderText = "COLUM";
            this.NUMEROCOLNICHO.Name = "NUMEROCOLNICHO";
            this.NUMEROCOLNICHO.ReadOnly = true;
            this.NUMEROCOLNICHO.Width = 80;
            // 
            // FECHAINHUMACION
            // 
            this.FECHAINHUMACION.DataPropertyName = "FECHAINHUMACION";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.FECHAINHUMACION.DefaultCellStyle = dataGridViewCellStyle6;
            this.FECHAINHUMACION.HeaderText = "FECHA INHUMACION";
            this.FECHAINHUMACION.Name = "FECHAINHUMACION";
            this.FECHAINHUMACION.ReadOnly = true;
            this.FECHAINHUMACION.Width = 80;
            // 
            // FECHACONCESION
            // 
            this.FECHACONCESION.DataPropertyName = "FECHACONCESION";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.FECHACONCESION.DefaultCellStyle = dataGridViewCellStyle7;
            this.FECHACONCESION.HeaderText = "FECHA CONCESION";
            this.FECHACONCESION.Name = "FECHACONCESION";
            this.FECHACONCESION.ReadOnly = true;
            this.FECHACONCESION.Width = 80;
            // 
            // btnVerTitulo
            // 
            this.btnVerTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerTitulo.BackColor = System.Drawing.Color.White;
            this.btnVerTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTitulo.ForeColor = System.Drawing.Color.Navy;
            this.btnVerTitulo.Image = global::GUI_Tesoreria.Properties.Resources.ver;
            this.btnVerTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTitulo.Location = new System.Drawing.Point(12, 492);
            this.btnVerTitulo.Name = "btnVerTitulo";
            this.btnVerTitulo.Size = new System.Drawing.Size(98, 34);
            this.btnVerTitulo.TabIndex = 44;
            this.btnVerTitulo.Text = "&Ver titulo";
            this.btnVerTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerTitulo.UseVisualStyleBackColor = false;
            this.btnVerTitulo.Click += new System.EventHandler(this.btnVerTitulo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(734, 492);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 34);
            this.btnSalir.TabIndex = 127;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(319, 30);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 24);
            this.btnbuscar.TabIndex = 129;
            this.btnbuscar.Text = "&BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtNombreCuartel
            // 
            this.txtNombreCuartel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCuartel.Location = new System.Drawing.Point(6, 33);
            this.txtNombreCuartel.Name = "txtNombreCuartel";
            this.txtNombreCuartel.Size = new System.Drawing.Size(193, 20);
            this.txtNombreCuartel.TabIndex = 128;
            this.txtNombreCuartel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreCuartel_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 130;
            this.label6.Text = "CUARTEL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoCuartel);
            this.groupBox1.Controls.Add(this.txtColumna);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFila);
            this.groupBox1.Controls.Add(this.lblLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreCuartel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 59);
            this.groupBox1.TabIndex = 131;
            this.groupBox1.TabStop = false;
            // 
            // txtColumna
            // 
            this.txtColumna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColumna.Location = new System.Drawing.Point(243, 30);
            this.txtColumna.Multiline = true;
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(57, 23);
            this.txtColumna.TabIndex = 134;
            this.txtColumna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColumna_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 131;
            this.label2.Text = "COLUMNA";
            // 
            // txtFila
            // 
            this.txtFila.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFila.Location = new System.Drawing.Point(205, 30);
            this.txtFila.MaxLength = 1;
            this.txtFila.Multiline = true;
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(32, 23);
            this.txtFila.TabIndex = 133;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(202, 11);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(29, 13);
            this.lblLabel.TabIndex = 132;
            this.lblLabel.Text = "FILA";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.ColumnHeadersVisible = false;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.CODTIPOCUARTEL,
            this.CODMATERIAL,
            this.dataGridViewTextBoxColumn2,
            this.NROFILACUARTEL,
            this.NROCOLUMNACUARTEL,
            this.CODCEMENTERIO,
            this.NOMBRECEMENTERIO,
            this.PUERTA,
            this.OBSCUARTEL});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResultado.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvResultado.Location = new System.Drawing.Point(18, 70);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.RowTemplate.Height = 24;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(346, 142);
            this.dgvResultado.TabIndex = 135;
            this.dgvResultado.Visible = false;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CODCUARTEL";
            this.dataGridViewTextBoxColumn1.HeaderText = "CODCUARTEL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 60;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRECUARTEL";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRECUARTEL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // txtCodigoCuartel
            // 
            this.txtCodigoCuartel.Location = new System.Drawing.Point(492, 0);
            this.txtCodigoCuartel.Name = "txtCodigoCuartel";
            this.txtCodigoCuartel.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoCuartel.TabIndex = 136;
            this.txtCodigoCuartel.Visible = false;
            // 
            // frmListadoTituloNicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 538);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerTitulo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmListadoTituloNicho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoTituloNicho";
            this.Load += new System.EventHandler(this.frmListadoTituloNicho_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvTitulos;
        internal System.Windows.Forms.Button btnVerTitulo;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTITULONICHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROTITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERODOCUMENTOVENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRERESPONSABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LETRAFILANICHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROCOLNICHO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINHUMACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACONCESION;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtNombreCuartel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label lblLabel;
        internal System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPOCUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMATERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROFILACUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROCOLUMNACUARTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSCUARTEL;
        private System.Windows.Forms.TextBox txtCodigoCuartel;
    }
}