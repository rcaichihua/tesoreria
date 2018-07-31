namespace GUI_Tesoreria.cementerio
{
    partial class frmMantenimientoTituloNicho
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
            this.rdbPerpetuo = new System.Windows.Forms.RadioButton();
            this.rdbTemporal = new System.Windows.Forms.RadioButton();
            this.gbMotivo = new System.Windows.Forms.GroupBox();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.mtbFechaConcesion = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechaInhumacion = new System.Windows.Forms.MaskedTextBox();
            this.cboEsatado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDifuntos = new System.Windows.Forms.DataGridView();
            this.NOMBRERESTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAINHUMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAFALLECIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodCuartel = new System.Windows.Forms.TextBox();
            this.txtCodCementerio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtCuartel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCementerio = new System.Windows.Forms.TextBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAniosTemporal = new System.Windows.Forms.TextBox();
            this.txtNroTitulo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbRecogio = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.chkGeneroNicho = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.gbMotivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDifuntos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbRecogio.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbPerpetuo);
            this.groupBox2.Controls.Add(this.rdbTemporal);
            this.groupBox2.Controls.Add(this.gbMotivo);
            this.groupBox2.Controls.Add(this.mtbFechaConcesion);
            this.groupBox2.Controls.Add(this.mtbFechaInhumacion);
            this.groupBox2.Controls.Add(this.cboEsatado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dgvDifuntos);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtResponsable);
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtAniosTemporal);
            this.groupBox2.Controls.Add(this.txtNroTitulo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 445);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // rdbPerpetuo
            // 
            this.rdbPerpetuo.AutoSize = true;
            this.rdbPerpetuo.Checked = true;
            this.rdbPerpetuo.Location = new System.Drawing.Point(122, 203);
            this.rdbPerpetuo.Name = "rdbPerpetuo";
            this.rdbPerpetuo.Size = new System.Drawing.Size(84, 17);
            this.rdbPerpetuo.TabIndex = 132;
            this.rdbPerpetuo.TabStop = true;
            this.rdbPerpetuo.Text = "PERPETUO";
            this.rdbPerpetuo.UseVisualStyleBackColor = true;
            this.rdbPerpetuo.CheckedChanged += new System.EventHandler(this.drbPerpetuo_CheckedChanged);
            // 
            // rdbTemporal
            // 
            this.rdbTemporal.AutoSize = true;
            this.rdbTemporal.Location = new System.Drawing.Point(212, 203);
            this.rdbTemporal.Name = "rdbTemporal";
            this.rdbTemporal.Size = new System.Drawing.Size(84, 17);
            this.rdbTemporal.TabIndex = 132;
            this.rdbTemporal.Text = "TEMPORAL";
            this.rdbTemporal.UseVisualStyleBackColor = true;
            this.rdbTemporal.CheckedChanged += new System.EventHandler(this.rdbTemporal_CheckedChanged);
            // 
            // gbMotivo
            // 
            this.gbMotivo.Controls.Add(this.cboMotivo);
            this.gbMotivo.Controls.Add(this.txtObservacion);
            this.gbMotivo.Controls.Add(this.label16);
            this.gbMotivo.Controls.Add(this.label17);
            this.gbMotivo.Enabled = false;
            this.gbMotivo.Location = new System.Drawing.Point(15, 350);
            this.gbMotivo.Name = "gbMotivo";
            this.gbMotivo.Size = new System.Drawing.Size(635, 85);
            this.gbMotivo.TabIndex = 131;
            this.gbMotivo.TabStop = false;
            // 
            // cboMotivo
            // 
            this.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Location = new System.Drawing.Point(9, 32);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(255, 23);
            this.cboMotivo.TabIndex = 127;
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.White;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtObservacion.Location = new System.Drawing.Point(290, 32);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(330, 41);
            this.txtObservacion.TabIndex = 129;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 128;
            this.label16.Text = "MOTIVO";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(287, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 130;
            this.label17.Text = "OBSERVACION";
            // 
            // mtbFechaConcesion
            // 
            this.mtbFechaConcesion.Location = new System.Drawing.Point(430, 324);
            this.mtbFechaConcesion.Mask = "00/00/0000";
            this.mtbFechaConcesion.Name = "mtbFechaConcesion";
            this.mtbFechaConcesion.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaConcesion.TabIndex = 123;
            this.mtbFechaConcesion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbFechaConcesion.ValidatingType = typeof(System.DateTime);
            // 
            // mtbFechaInhumacion
            // 
            this.mtbFechaInhumacion.Location = new System.Drawing.Point(174, 324);
            this.mtbFechaInhumacion.Mask = "00/00/0000";
            this.mtbFechaInhumacion.Name = "mtbFechaInhumacion";
            this.mtbFechaInhumacion.Size = new System.Drawing.Size(100, 20);
            this.mtbFechaInhumacion.TabIndex = 123;
            this.mtbFechaInhumacion.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtbFechaInhumacion.ValidatingType = typeof(System.DateTime);
            // 
            // cboEsatado
            // 
            this.cboEsatado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEsatado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEsatado.FormattingEnabled = true;
            this.cboEsatado.Items.AddRange(new object[] {
            "[SELECCIONE]",
            "INHUMADO",
            "RESERVADO EN VIDA",
            "ANULADO"});
            this.cboEsatado.Location = new System.Drawing.Point(33, 27);
            this.cboEsatado.Name = "cboEsatado";
            this.cboEsatado.Size = new System.Drawing.Size(195, 23);
            this.cboEsatado.TabIndex = 41;
            this.cboEsatado.SelectedIndexChanged += new System.EventHandler(this.cboEsatado_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "ESTADO TITULO";
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
            this.NOMBRERESTOS,
            this.NOMBRES,
            this.APELLIDOS,
            this.FECHAINHUMACION,
            this.FECHAFALLECIMIENTO,
            this.GENERO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDifuntos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDifuntos.Location = new System.Drawing.Point(15, 223);
            this.dgvDifuntos.Name = "dgvDifuntos";
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
            this.dgvDifuntos.Size = new System.Drawing.Size(626, 95);
            this.dgvDifuntos.TabIndex = 30;
            this.dgvDifuntos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDifuntos_MouseClick);
            // 
            // NOMBRERESTOS
            // 
            this.NOMBRERESTOS.DataPropertyName = "NOMBRERESTOS";
            this.NOMBRERESTOS.HeaderText = "TIPO RESTOS";
            this.NOMBRERESTOS.Name = "NOMBRERESTOS";
            this.NOMBRERESTOS.ReadOnly = true;
            this.NOMBRERESTOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NOMBRERESTOS.Width = 130;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.Width = 160;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.DataPropertyName = "APELLIDOS";
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.ReadOnly = true;
            this.APELLIDOS.Width = 170;
            // 
            // FECHAINHUMACION
            // 
            this.FECHAINHUMACION.DataPropertyName = "FECHAINHUMACION";
            this.FECHAINHUMACION.HeaderText = "FECHA INHUMACION";
            this.FECHAINHUMACION.Name = "FECHAINHUMACION";
            this.FECHAINHUMACION.ReadOnly = true;
            this.FECHAINHUMACION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FECHAINHUMACION.Width = 90;
            // 
            // FECHAFALLECIMIENTO
            // 
            this.FECHAFALLECIMIENTO.DataPropertyName = "FECHAFALLECIMIENTO";
            this.FECHAFALLECIMIENTO.HeaderText = "FECHAFALLECIMIENTO";
            this.FECHAFALLECIMIENTO.Name = "FECHAFALLECIMIENTO";
            this.FECHAFALLECIMIENTO.Visible = false;
            // 
            // GENERO
            // 
            this.GENERO.DataPropertyName = "GENERO";
            this.GENERO.HeaderText = "GENERO";
            this.GENERO.Name = "GENERO";
            this.GENERO.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodCuartel);
            this.groupBox1.Controls.Add(this.txtCodCementerio);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Controls.Add(this.txtCuartel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCementerio);
            this.groupBox1.Controls.Add(this.txtLetra);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(248, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 132);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtCodCuartel
            // 
            this.txtCodCuartel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCuartel.Location = new System.Drawing.Point(110, 44);
            this.txtCodCuartel.Name = "txtCodCuartel";
            this.txtCodCuartel.ReadOnly = true;
            this.txtCodCuartel.Size = new System.Drawing.Size(44, 20);
            this.txtCodCuartel.TabIndex = 23;
            // 
            // txtCodCementerio
            // 
            this.txtCodCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCementerio.Location = new System.Drawing.Point(110, 18);
            this.txtCodCementerio.Name = "txtCodCementerio";
            this.txtCodCementerio.ReadOnly = true;
            this.txtCodCementerio.Size = new System.Drawing.Size(44, 20);
            this.txtCodCementerio.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "NICHO DE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "CUARTEL";
            // 
            // txtMaterial
            // 
            this.txtMaterial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaterial.Location = new System.Drawing.Point(160, 70);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(214, 20);
            this.txtMaterial.TabIndex = 6;
            // 
            // txtCuartel
            // 
            this.txtCuartel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuartel.Location = new System.Drawing.Point(160, 44);
            this.txtCuartel.Name = "txtCuartel";
            this.txtCuartel.ReadOnly = true;
            this.txtCuartel.Size = new System.Drawing.Size(214, 20);
            this.txtCuartel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "CEMENTERIO";
            // 
            // txtCementerio
            // 
            this.txtCementerio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCementerio.Location = new System.Drawing.Point(160, 18);
            this.txtCementerio.Name = "txtCementerio";
            this.txtCementerio.ReadOnly = true;
            this.txtCementerio.Size = new System.Drawing.Size(214, 20);
            this.txtCementerio.TabIndex = 6;
            // 
            // txtLetra
            // 
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Location = new System.Drawing.Point(310, 96);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.ReadOnly = true;
            this.txtLetra.Size = new System.Drawing.Size(64, 20);
            this.txtLetra.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "LETRA";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Location = new System.Drawing.Point(160, 96);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(64, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NUMERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "REGISTRO DE INHUMACIONES";
            // 
            // txtResponsable
            // 
            this.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtResponsable.Location = new System.Drawing.Point(122, 177);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(519, 20);
            this.txtResponsable.TabIndex = 6;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroDocumento.Location = new System.Drawing.Point(33, 139);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(209, 20);
            this.txtNroDocumento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "FACTURA / BOLETA DE VENTA / RECIBO  N°";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 327);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "FECHA DE CONCESION";
            // 
            // txtAniosTemporal
            // 
            this.txtAniosTemporal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAniosTemporal.Enabled = false;
            this.txtAniosTemporal.Location = new System.Drawing.Point(305, 202);
            this.txtAniosTemporal.Name = "txtAniosTemporal";
            this.txtAniosTemporal.Size = new System.Drawing.Size(54, 20);
            this.txtAniosTemporal.TabIndex = 6;
            this.txtAniosTemporal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAniosTemporal_KeyPress);
            // 
            // txtNroTitulo
            // 
            this.txtNroTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroTitulo.Location = new System.Drawing.Point(116, 75);
            this.txtNroTitulo.Name = "txtNroTitulo";
            this.txtNroTitulo.Size = new System.Drawing.Size(126, 20);
            this.txtNroTitulo.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 327);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "FECHA DE INHUMACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RESPONSABLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "TITUTLO     N°";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(6, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 42);
            this.btnSalir.TabIndex = 110;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 42);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 123);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 42);
            this.btnCancelar.TabIndex = 107;
            this.btnCancelar.Text = "&CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 42);
            this.btnEliminar.TabIndex = 108;
            this.btnEliminar.Text = "&ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gbRecogio);
            this.groupBox4.Controls.Add(this.chkGeneroNicho);
            this.groupBox4.Controls.Add(this.btnGuardar);
            this.groupBox4.Controls.Add(this.btnSalir);
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnCancelar);
            this.groupBox4.Location = new System.Drawing.Point(674, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 445);
            this.groupBox4.TabIndex = 111;
            this.groupBox4.TabStop = false;
            // 
            // gbRecogio
            // 
            this.gbRecogio.Controls.Add(this.rdbNo);
            this.gbRecogio.Controls.Add(this.rdbSi);
            this.gbRecogio.Enabled = false;
            this.gbRecogio.Location = new System.Drawing.Point(6, 330);
            this.gbRecogio.Name = "gbRecogio";
            this.gbRecogio.Size = new System.Drawing.Size(90, 105);
            this.gbRecogio.TabIndex = 113;
            this.gbRecogio.TabStop = false;
            this.gbRecogio.Text = "RECOGIO?";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(19, 60);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(41, 17);
            this.rdbNo.TabIndex = 111;
            this.rdbNo.Text = "NO";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Checked = true;
            this.rdbSi.Location = new System.Drawing.Point(19, 34);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(35, 17);
            this.rdbSi.TabIndex = 111;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "SI";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // chkGeneroNicho
            // 
            this.chkGeneroNicho.Location = new System.Drawing.Point(6, 291);
            this.chkGeneroNicho.Name = "chkGeneroNicho";
            this.chkGeneroNicho.Size = new System.Drawing.Size(90, 33);
            this.chkGeneroNicho.TabIndex = 112;
            this.chkGeneroNicho.Text = "SE GENERO TITULO";
            this.chkGeneroNicho.UseVisualStyleBackColor = true;
            this.chkGeneroNicho.CheckedChanged += new System.EventHandler(this.chkGeneroNicho_CheckedChanged);
            // 
            // frmMantenimientoTituloNicho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 465);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMantenimientoTituloNicho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMantenimientoTituloNicho";
            this.Load += new System.EventHandler(this.frmMantenimientoTituloNicho_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbMotivo.ResumeLayout(false);
            this.gbMotivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDifuntos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbRecogio.ResumeLayout(false);
            this.gbRecogio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtCuartel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCementerio;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DataGridView dgvDifuntos;
        private System.Windows.Forms.MaskedTextBox mtbFechaConcesion;
        private System.Windows.Forms.MaskedTextBox mtbFechaInhumacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.ComboBox cboEsatado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbMotivo;
        internal System.Windows.Forms.ComboBox cboMotivo;
        internal System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.GroupBox gbRecogio;
        private System.Windows.Forms.CheckBox chkGeneroNicho;
        private System.Windows.Forms.TextBox txtCodCuartel;
        private System.Windows.Forms.TextBox txtCodCementerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRERESTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAINHUMACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAFALLECIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENERO;
        private System.Windows.Forms.RadioButton rdbPerpetuo;
        private System.Windows.Forms.RadioButton rdbTemporal;
        private System.Windows.Forms.TextBox txtAniosTemporal;
    }
}