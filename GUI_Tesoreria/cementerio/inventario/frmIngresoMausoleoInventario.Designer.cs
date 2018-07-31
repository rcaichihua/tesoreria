namespace GUI_Tesoreria.cementerio.inventario
{
    partial class frmIngresoMausoleoInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoMausoleoInventario));
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDifuntos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvMausoleo = new System.Windows.Forms.DataGridView();
            this.IDMAUSOLEOINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECEMENTERIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTIPOMAUSOLEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIAPROPIETARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRESECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPSUBSECTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JARDIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMEROBOBEDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUERTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REFERENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPESTADOMAUSOLEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAGGABINETE_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTAIMAGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboPuerta = new System.Windows.Forms.ComboBox();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCementerio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEstadoFisico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoMausoleo = new System.Windows.Forms.TextBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBobedas = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtJardin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSubSector = new System.Windows.Forms.ComboBox();
            this.cboSector = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoMausoleo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.IDDIFUNTOTUMBAINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFALLECIMIENTO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSDIFUNTOINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLAGGABINETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAMILIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDifuntos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMausoleo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 394);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDifuntos);
            this.groupBox1.Location = new System.Drawing.Point(386, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvDifuntos
            // 
            this.dgvDifuntos.AllowUserToAddRows = false;
            this.dgvDifuntos.AllowUserToDeleteRows = false;
            this.dgvDifuntos.AllowUserToResizeColumns = false;
            this.dgvDifuntos.AllowUserToResizeRows = false;
            this.dgvDifuntos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDifuntos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDifuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDifuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDIFUNTOTUMBAINV,
            this.NOMBRES,
            this.APELLIDOS,
            this.FECHAFALLECIMIENTO_,
            this.OBSDIFUNTOINV,
            this.FLAGGABINETE,
            this.FAMILIA,
            this.GENERO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDifuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDifuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDifuntos.Location = new System.Drawing.Point(3, 16);
            this.dgvDifuntos.Name = "dgvDifuntos";
            this.dgvDifuntos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDifuntos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDifuntos.RowHeadersVisible = false;
            this.dgvDifuntos.RowHeadersWidth = 10;
            this.dgvDifuntos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDifuntos.Size = new System.Drawing.Size(502, 132);
            this.dgvDifuntos.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 394);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvMausoleo);
            this.groupBox3.Location = new System.Drawing.Point(383, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 290);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // dgvMausoleo
            // 
            this.dgvMausoleo.AllowUserToAddRows = false;
            this.dgvMausoleo.AllowUserToDeleteRows = false;
            this.dgvMausoleo.AllowUserToResizeColumns = false;
            this.dgvMausoleo.AllowUserToResizeRows = false;
            this.dgvMausoleo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMausoleo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMausoleo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMausoleo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMAUSOLEOINV,
            this.NOMBRECEMENTERIO,
            this.DESCRIPTIPOMAUSOLEO,
            this.FAMILIAPROPIETARIO,
            this.NOMBRESECTOR,
            this.DESCRIPSUBSECTOR,
            this.JARDIN,
            this.LOTE,
            this.NUMEROBOBEDAS,
            this.PUERTA,
            this.REFERENCIA,
            this.DESCRIPESTADOMAUSOLEO,
            this.OBSERVACION,
            this.FLAGGABINETE_,
            this.RUTAIMAGEN});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMausoleo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMausoleo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMausoleo.Location = new System.Drawing.Point(3, 16);
            this.dgvMausoleo.Name = "dgvMausoleo";
            this.dgvMausoleo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMausoleo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMausoleo.RowHeadersVisible = false;
            this.dgvMausoleo.RowHeadersWidth = 10;
            this.dgvMausoleo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMausoleo.Size = new System.Drawing.Size(502, 271);
            this.dgvMausoleo.TabIndex = 1;
            this.dgvMausoleo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMausoleo_CellClick);
            this.dgvMausoleo.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMausoleo_CellEnter);
            // 
            // IDMAUSOLEOINV
            // 
            this.IDMAUSOLEOINV.DataPropertyName = "IDMAUSOLEOINV";
            this.IDMAUSOLEOINV.HeaderText = "IDMAUSOLEOINV";
            this.IDMAUSOLEOINV.Name = "IDMAUSOLEOINV";
            this.IDMAUSOLEOINV.ReadOnly = true;
            this.IDMAUSOLEOINV.Visible = false;
            // 
            // NOMBRECEMENTERIO
            // 
            this.NOMBRECEMENTERIO.DataPropertyName = "NOMBRECEMENTERIO";
            this.NOMBRECEMENTERIO.HeaderText = "CEMENTERIO";
            this.NOMBRECEMENTERIO.Name = "NOMBRECEMENTERIO";
            this.NOMBRECEMENTERIO.ReadOnly = true;
            this.NOMBRECEMENTERIO.Width = 80;
            // 
            // DESCRIPTIPOMAUSOLEO
            // 
            this.DESCRIPTIPOMAUSOLEO.DataPropertyName = "DESCRIPTIPOMAUSOLEO";
            this.DESCRIPTIPOMAUSOLEO.HeaderText = "TIPO MAUSOLEO";
            this.DESCRIPTIPOMAUSOLEO.Name = "DESCRIPTIPOMAUSOLEO";
            this.DESCRIPTIPOMAUSOLEO.ReadOnly = true;
            this.DESCRIPTIPOMAUSOLEO.Width = 80;
            // 
            // FAMILIAPROPIETARIO
            // 
            this.FAMILIAPROPIETARIO.DataPropertyName = "FAMILIAPROPIETARIO";
            this.FAMILIAPROPIETARIO.HeaderText = "FAMILIA";
            this.FAMILIAPROPIETARIO.Name = "FAMILIAPROPIETARIO";
            this.FAMILIAPROPIETARIO.ReadOnly = true;
            // 
            // NOMBRESECTOR
            // 
            this.NOMBRESECTOR.DataPropertyName = "NOMBRESECTOR";
            this.NOMBRESECTOR.HeaderText = "SECTOR";
            this.NOMBRESECTOR.Name = "NOMBRESECTOR";
            this.NOMBRESECTOR.ReadOnly = true;
            this.NOMBRESECTOR.Width = 80;
            // 
            // DESCRIPSUBSECTOR
            // 
            this.DESCRIPSUBSECTOR.DataPropertyName = "DESCRIPSUBSECTOR";
            this.DESCRIPSUBSECTOR.HeaderText = "SUB SECTOR";
            this.DESCRIPSUBSECTOR.Name = "DESCRIPSUBSECTOR";
            this.DESCRIPSUBSECTOR.ReadOnly = true;
            this.DESCRIPSUBSECTOR.Width = 80;
            // 
            // JARDIN
            // 
            this.JARDIN.DataPropertyName = "JARDIN";
            this.JARDIN.HeaderText = "JARDIN";
            this.JARDIN.Name = "JARDIN";
            this.JARDIN.ReadOnly = true;
            this.JARDIN.Width = 60;
            // 
            // LOTE
            // 
            this.LOTE.DataPropertyName = "LOTE";
            this.LOTE.HeaderText = "LOTE";
            this.LOTE.Name = "LOTE";
            this.LOTE.ReadOnly = true;
            this.LOTE.Width = 60;
            // 
            // NUMEROBOBEDAS
            // 
            this.NUMEROBOBEDAS.DataPropertyName = "NUMEROBOBEDAS";
            this.NUMEROBOBEDAS.HeaderText = "NRO BOBEDAS";
            this.NUMEROBOBEDAS.Name = "NUMEROBOBEDAS";
            this.NUMEROBOBEDAS.ReadOnly = true;
            this.NUMEROBOBEDAS.Width = 60;
            // 
            // PUERTA
            // 
            this.PUERTA.DataPropertyName = "PUERTA";
            this.PUERTA.HeaderText = "PUERTA";
            this.PUERTA.Name = "PUERTA";
            this.PUERTA.ReadOnly = true;
            this.PUERTA.Width = 70;
            // 
            // REFERENCIA
            // 
            this.REFERENCIA.DataPropertyName = "REFERENCIA";
            this.REFERENCIA.HeaderText = "REFERENCIA";
            this.REFERENCIA.Name = "REFERENCIA";
            this.REFERENCIA.ReadOnly = true;
            // 
            // DESCRIPESTADOMAUSOLEO
            // 
            this.DESCRIPESTADOMAUSOLEO.DataPropertyName = "DESCRIPESTADOMAUSOLEO";
            this.DESCRIPESTADOMAUSOLEO.HeaderText = "ESTADO MAUSOLEO";
            this.DESCRIPESTADOMAUSOLEO.Name = "DESCRIPESTADOMAUSOLEO";
            this.DESCRIPESTADOMAUSOLEO.ReadOnly = true;
            // 
            // OBSERVACION
            // 
            this.OBSERVACION.DataPropertyName = "OBSERVACION";
            this.OBSERVACION.HeaderText = "OBSERVACION";
            this.OBSERVACION.Name = "OBSERVACION";
            this.OBSERVACION.ReadOnly = true;
            // 
            // FLAGGABINETE_
            // 
            this.FLAGGABINETE_.DataPropertyName = "FLAGGABINETE";
            this.FLAGGABINETE_.HeaderText = "FLAGGABINETE";
            this.FLAGGABINETE_.Name = "FLAGGABINETE_";
            this.FLAGGABINETE_.ReadOnly = true;
            this.FLAGGABINETE_.Visible = false;
            // 
            // RUTAIMAGEN
            // 
            this.RUTAIMAGEN.DataPropertyName = "RUTAIMAGEN";
            this.RUTAIMAGEN.HeaderText = "RUTAIMAGEN";
            this.RUTAIMAGEN.Name = "RUTAIMAGEN";
            this.RUTAIMAGEN.ReadOnly = true;
            this.RUTAIMAGEN.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboPuerta);
            this.groupBox2.Controls.Add(this.txtFamilia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboCementerio);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboEstadoFisico);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigoMausoleo);
            this.groupBox2.Controls.Add(this.txtLote);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBobedas);
            this.groupBox2.Controls.Add(this.txtReferencia);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtJardin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboSubSector);
            this.groupBox2.Controls.Add(this.cboSector);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboTipoMausoleo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 376);
            this.groupBox2.TabIndex = 0;
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
            this.cboPuerta.Location = new System.Drawing.Point(108, 211);
            this.cboPuerta.Name = "cboPuerta";
            this.cboPuerta.Size = new System.Drawing.Size(118, 23);
            this.cboPuerta.TabIndex = 8;
            // 
            // txtFamilia
            // 
            this.txtFamilia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFamilia.Location = new System.Drawing.Point(108, 76);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(243, 20);
            this.txtFamilia.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "FAMILIA";
            // 
            // cboCementerio
            // 
            this.cboCementerio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCementerio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCementerio.FormattingEnabled = true;
            this.cboCementerio.Location = new System.Drawing.Point(108, 19);
            this.cboCementerio.Name = "cboCementerio";
            this.cboCementerio.Size = new System.Drawing.Size(201, 23);
            this.cboCementerio.TabIndex = 0;
            this.cboCementerio.SelectedIndexChanged += new System.EventHandler(this.cboCementerio_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CEMENTERIO";
            // 
            // cboEstadoFisico
            // 
            this.cboEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoFisico.FormattingEnabled = true;
            this.cboEstadoFisico.Location = new System.Drawing.Point(108, 264);
            this.cboEstadoFisico.Name = "cboEstadoFisico";
            this.cboEstadoFisico.Size = new System.Drawing.Size(158, 23);
            this.cboEstadoFisico.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "ESTADO";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(108, 293);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(195, 72);
            this.txtObservacion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "OBSERVACION";
            // 
            // txtCodigoMausoleo
            // 
            this.txtCodigoMausoleo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoMausoleo.Location = new System.Drawing.Point(287, 50);
            this.txtCodigoMausoleo.Name = "txtCodigoMausoleo";
            this.txtCodigoMausoleo.ReadOnly = true;
            this.txtCodigoMausoleo.Size = new System.Drawing.Size(64, 20);
            this.txtCodigoMausoleo.TabIndex = 6;
            // 
            // txtLote
            // 
            this.txtLote.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLote.Location = new System.Drawing.Point(235, 160);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(64, 20);
            this.txtLote.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "LOTE";
            // 
            // txtBobedas
            // 
            this.txtBobedas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBobedas.Location = new System.Drawing.Point(108, 186);
            this.txtBobedas.Name = "txtBobedas";
            this.txtBobedas.Size = new System.Drawing.Size(83, 20);
            this.txtBobedas.TabIndex = 7;
            // 
            // txtReferencia
            // 
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Location = new System.Drawing.Point(108, 238);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(243, 20);
            this.txtReferencia.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "PUERTA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "BOBEDAS";
            // 
            // txtJardin
            // 
            this.txtJardin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtJardin.Location = new System.Drawing.Point(108, 160);
            this.txtJardin.Name = "txtJardin";
            this.txtJardin.Size = new System.Drawing.Size(64, 20);
            this.txtJardin.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "REFERENCIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "JARDIN ";
            // 
            // cboSubSector
            // 
            this.cboSubSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubSector.FormattingEnabled = true;
            this.cboSubSector.Location = new System.Drawing.Point(108, 131);
            this.cboSubSector.Name = "cboSubSector";
            this.cboSubSector.Size = new System.Drawing.Size(149, 23);
            this.cboSubSector.TabIndex = 4;
            // 
            // cboSector
            // 
            this.cboSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSector.FormattingEnabled = true;
            this.cboSector.Items.AddRange(new object[] {
            "NINGUNA",
            "1RA PUERTA",
            "2DA PUERTA",
            "3RA PUERTA",
            "4TA PUERTA",
            "5TA PUERTA",
            "6TA PUERTA"});
            this.cboSector.Location = new System.Drawing.Point(108, 102);
            this.cboSector.Name = "cboSector";
            this.cboSector.Size = new System.Drawing.Size(149, 23);
            this.cboSector.TabIndex = 3;
            this.cboSector.SelectedIndexChanged += new System.EventHandler(this.cboSector_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "SUB SECTOR";
            // 
            // cboTipoMausoleo
            // 
            this.cboTipoMausoleo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMausoleo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMausoleo.FormattingEnabled = true;
            this.cboTipoMausoleo.Location = new System.Drawing.Point(108, 48);
            this.cboTipoMausoleo.Name = "cboTipoMausoleo";
            this.cboTipoMausoleo.Size = new System.Drawing.Size(118, 23);
            this.cboTipoMausoleo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECTOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "TIPO MAUSOLEO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(122, 446);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(35, 13);
            this.lblRuta.TabIndex = 47;
            this.lblRuta.Text = "label1";
            this.lblRuta.Visible = false;
            // 
            // IDDIFUNTOTUMBAINV
            // 
            this.IDDIFUNTOTUMBAINV.DataPropertyName = "IDDIFUNTOMAUINV";
            this.IDDIFUNTOTUMBAINV.HeaderText = "IDDIFUNTONICHOINV";
            this.IDDIFUNTOTUMBAINV.Name = "IDDIFUNTOTUMBAINV";
            this.IDDIFUNTOTUMBAINV.ReadOnly = true;
            this.IDDIFUNTOTUMBAINV.Visible = false;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 140;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.DataPropertyName = "APELLIDOS";
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.ReadOnly = true;
            this.APELLIDOS.Width = 140;
            // 
            // FECHAFALLECIMIENTO_
            // 
            this.FECHAFALLECIMIENTO_.DataPropertyName = "FECHAFALLECIMIENTO";
            this.FECHAFALLECIMIENTO_.HeaderText = "FECHA FALLECIMIENTO";
            this.FECHAFALLECIMIENTO_.Name = "FECHAFALLECIMIENTO_";
            this.FECHAFALLECIMIENTO_.ReadOnly = true;
            this.FECHAFALLECIMIENTO_.Width = 80;
            // 
            // OBSDIFUNTOINV
            // 
            this.OBSDIFUNTOINV.DataPropertyName = "OBSDIFUNTOINV";
            this.OBSDIFUNTOINV.HeaderText = "OBSDIFUNTOINV";
            this.OBSDIFUNTOINV.Name = "OBSDIFUNTOINV";
            this.OBSDIFUNTOINV.ReadOnly = true;
            // 
            // FLAGGABINETE
            // 
            this.FLAGGABINETE.DataPropertyName = "FLAGGABINETE";
            this.FLAGGABINETE.HeaderText = "FLAGGABINETE";
            this.FLAGGABINETE.Name = "FLAGGABINETE";
            this.FLAGGABINETE.ReadOnly = true;
            this.FLAGGABINETE.Visible = false;
            // 
            // FAMILIA
            // 
            this.FAMILIA.DataPropertyName = "FAMILIA";
            this.FAMILIA.HeaderText = "FAMILIA";
            this.FAMILIA.Name = "FAMILIA";
            this.FAMILIA.ReadOnly = true;
            this.FAMILIA.Visible = false;
            // 
            // GENERO
            // 
            this.GENERO.DataPropertyName = "GENERO";
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.ReadOnly = true;
            this.GENERO.Visible = false;
            // 
            // frmIngresoMausoleoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 505);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmIngresoMausoleoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::: INGRESO DE MAUSOLEOS :::...";
            this.Load += new System.EventHandler(this.frmIngresoMausoleoInventario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmIngresoMausoleoInventario_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDifuntos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMausoleo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvDifuntos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvMausoleo;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox cboEstadoFisico;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoMausoleo;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJardin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboSector;
        internal System.Windows.Forms.ComboBox cboTipoMausoleo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.ComboBox cboCementerio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBobedas;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.ComboBox cboSubSector;
        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox cboPuerta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMAUSOLEOINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECEMENTERIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTIPOMAUSOLEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIAPROPIETARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRESECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPSUBSECTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn JARDIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMEROBOBEDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUERTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFERENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPESTADOMAUSOLEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAGGABINETE_;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTAIMAGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDIFUNTOTUMBAINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFALLECIMIENTO_;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSDIFUNTOINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLAGGABINETE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAMILIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERO;
    }
}