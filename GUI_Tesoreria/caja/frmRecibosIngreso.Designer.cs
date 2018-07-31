namespace GUI_Tesoreria.caja
{
    partial class frmRecibosIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecibosIngreso));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPorCajero = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrograma = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecibosGeneral = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHaber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVolverGenerar = new System.Windows.Forms.Button();
            this.btnListadoContable = new System.Windows.Forms.Button();
            this.BtnReciboIngreso = new System.Windows.Forms.Button();
            this.lblNroRecibos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnEliminarApertura = new System.Windows.Forms.Button();
            this.programaRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Caja_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAperturaCaja_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraAperturaCaja_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCierreCaja_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraCierreCaja_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroPliego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioEstacion_AperturaCierreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibosGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.chkPorCajero);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.cboPrograma);
            this.GroupBox1.Controls.Add(this.label4);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.dtpHasta);
            this.GroupBox1.Controls.Add(this.dtpDesde);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox1.Location = new System.Drawing.Point(12, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(672, 61);
            this.GroupBox1.TabIndex = 100;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Busqueda por :";
            // 
            // chkPorCajero
            // 
            this.chkPorCajero.AutoSize = true;
            this.chkPorCajero.Checked = true;
            this.chkPorCajero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPorCajero.Location = new System.Drawing.Point(510, 32);
            this.chkPorCajero.Name = "chkPorCajero";
            this.chkPorCajero.Size = new System.Drawing.Size(152, 17);
            this.chkPorCajero.TabIndex = 119;
            this.chkPorCajero.Text = "Detallado por cajero ?";
            this.chkPorCajero.UseVisualStyleBackColor = true;
            this.chkPorCajero.CheckedChanged += new System.EventHandler(this.chkPorPrograma_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(145, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 118;
            this.label1.Text = "Hasta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboPrograma
            // 
            this.cboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrograma.FormattingEnabled = true;
            this.cboPrograma.Location = new System.Drawing.Point(270, 29);
            this.cboPrograma.Name = "cboPrograma";
            this.cboPrograma.Size = new System.Drawing.Size(234, 23);
            this.cboPrograma.TabIndex = 119;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(267, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 118;
            this.label4.Text = "Programa";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(23, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Desde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(148, 32);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(116, 20);
            this.dtpHasta.TabIndex = 117;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(26, 32);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(116, 20);
            this.dtpDesde.TabIndex = 117;
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(987, 32);
            this.LblTitulo.TabIndex = 99;
            this.LblTitulo.Text = ":::   RECIBOS DE INGRESO  :::\r\n";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(690, 61);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(53, 39);
            this.BtnBuscar.TabIndex = 115;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.dgvRecibosGeneral);
            this.GroupBox2.Controls.Add(this.dgvRecibos);
            this.GroupBox2.Location = new System.Drawing.Point(12, 111);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(894, 353);
            this.GroupBox2.TabIndex = 117;
            this.GroupBox2.TabStop = false;
            // 
            // dgvRecibosGeneral
            // 
            this.dgvRecibosGeneral.AllowUserToAddRows = false;
            this.dgvRecibosGeneral.AllowUserToDeleteRows = false;
            this.dgvRecibosGeneral.AllowUserToResizeColumns = false;
            this.dgvRecibosGeneral.AllowUserToResizeRows = false;
            this.dgvRecibosGeneral.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibosGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibosGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibosGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.TotalHaber});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibosGeneral.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecibosGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibosGeneral.Location = new System.Drawing.Point(3, 16);
            this.dgvRecibosGeneral.Name = "dgvRecibosGeneral";
            this.dgvRecibosGeneral.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibosGeneral.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecibosGeneral.RowHeadersVisible = false;
            this.dgvRecibosGeneral.RowHeadersWidth = 10;
            this.dgvRecibosGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibosGeneral.Size = new System.Drawing.Size(888, 334);
            this.dgvRecibosGeneral.TabIndex = 84;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "programa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Programa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 280;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "totaldebe";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Format = "N2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Debe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // TotalHaber
            // 
            this.TotalHaber.DataPropertyName = "totalhaber";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            this.TotalHaber.DefaultCellStyle = dataGridViewCellStyle3;
            this.TotalHaber.HeaderText = "Total Haber";
            this.TotalHaber.Name = "TotalHaber";
            this.TotalHaber.ReadOnly = true;
            this.TotalHaber.Width = 150;
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.AllowUserToResizeColumns = false;
            this.dgvRecibos.AllowUserToResizeRows = false;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.programaRecibo,
            this.Id_AperturaCierreCaja,
            this.Id_Caja_Usuario,
            this.nombre_usuario,
            this.FechaAperturaCaja_AperturaCierreCaja,
            this.HoraAperturaCaja_AperturaCierreCaja,
            this.FechaCierreCaja_AperturaCierreCaja,
            this.HoraCierreCaja_AperturaCierreCaja,
            this.Observacion_AperturaCierreCaja,
            this.nroPliego,
            this.Total_Debe,
            this.Total_Haber,
            this.UsuarioEstacion_AperturaCierreCaja});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 16);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidth = 10;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(888, 334);
            this.dgvRecibos.TabIndex = 83;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.BtnEliminarApertura);
            this.GBOpciones.Controls.Add(this.btnSalir);
            this.GBOpciones.Controls.Add(this.btnVolverGenerar);
            this.GBOpciones.Controls.Add(this.btnListadoContable);
            this.GBOpciones.Controls.Add(this.BtnReciboIngreso);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(912, 111);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(87, 353);
            this.GBOpciones.TabIndex = 116;
            this.GBOpciones.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(6, 308);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 39);
            this.btnSalir.TabIndex = 58;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVolverGenerar
            // 
            this.btnVolverGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolverGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverGenerar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverGenerar.ForeColor = System.Drawing.Color.Navy;
            this.btnVolverGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnVolverGenerar.Image")));
            this.btnVolverGenerar.Location = new System.Drawing.Point(6, 101);
            this.btnVolverGenerar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVolverGenerar.Name = "btnVolverGenerar";
            this.btnVolverGenerar.Size = new System.Drawing.Size(74, 63);
            this.btnVolverGenerar.TabIndex = 93;
            this.btnVolverGenerar.Text = "&Volver a generar";
            this.btnVolverGenerar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolverGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolverGenerar.UseVisualStyleBackColor = false;
            this.btnVolverGenerar.Click += new System.EventHandler(this.btnVolverGenerar_Click);
            // 
            // btnListadoContable
            // 
            this.btnListadoContable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListadoContable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoContable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoContable.ForeColor = System.Drawing.Color.Navy;
            this.btnListadoContable.Image = ((System.Drawing.Image)(resources.GetObject("btnListadoContable.Image")));
            this.btnListadoContable.Location = new System.Drawing.Point(6, 56);
            this.btnListadoContable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListadoContable.Name = "btnListadoContable";
            this.btnListadoContable.Size = new System.Drawing.Size(74, 39);
            this.btnListadoContable.TabIndex = 93;
            this.btnListadoContable.Text = "&Ver LC";
            this.btnListadoContable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListadoContable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnListadoContable.UseVisualStyleBackColor = false;
            this.btnListadoContable.Click += new System.EventHandler(this.btnListadoContable_Click);
            // 
            // BtnReciboIngreso
            // 
            this.BtnReciboIngreso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReciboIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReciboIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReciboIngreso.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReciboIngreso.ForeColor = System.Drawing.Color.Navy;
            this.BtnReciboIngreso.Image = ((System.Drawing.Image)(resources.GetObject("BtnReciboIngreso.Image")));
            this.BtnReciboIngreso.Location = new System.Drawing.Point(6, 11);
            this.BtnReciboIngreso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnReciboIngreso.Name = "BtnReciboIngreso";
            this.BtnReciboIngreso.Size = new System.Drawing.Size(74, 39);
            this.BtnReciboIngreso.TabIndex = 93;
            this.BtnReciboIngreso.Text = "&Ver RI";
            this.BtnReciboIngreso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReciboIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnReciboIngreso.UseVisualStyleBackColor = false;
            this.BtnReciboIngreso.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // lblNroRecibos
            // 
            this.lblNroRecibos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRecibos.ForeColor = System.Drawing.Color.Navy;
            this.lblNroRecibos.Location = new System.Drawing.Point(152, 467);
            this.lblNroRecibos.Name = "lblNroRecibos";
            this.lblNroRecibos.Size = new System.Drawing.Size(67, 15);
            this.lblNroRecibos.TabIndex = 122;
            this.lblNroRecibos.Text = "0";
            this.lblNroRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 121;
            this.label7.Text = "Cantidad de recibos: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(720, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 124;
            this.label2.Text = "Total haber:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHaber
            // 
            this.txtHaber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHaber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtHaber.ForeColor = System.Drawing.Color.Maroon;
            this.txtHaber.Location = new System.Drawing.Point(809, 467);
            this.txtHaber.MaxLength = 4000;
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.ReadOnly = true;
            this.txtHaber.Size = new System.Drawing.Size(97, 21);
            this.txtHaber.TabIndex = 123;
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDebe
            // 
            this.txtDebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebe.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDebe.ForeColor = System.Drawing.Color.Maroon;
            this.txtDebe.Location = new System.Drawing.Point(617, 465);
            this.txtDebe.MaxLength = 4000;
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.ReadOnly = true;
            this.txtDebe.Size = new System.Drawing.Size(97, 21);
            this.txtDebe.TabIndex = 123;
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(506, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 124;
            this.label3.Text = "Total debe:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnEliminarApertura
            // 
            this.BtnEliminarApertura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminarApertura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminarApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarApertura.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarApertura.Image")));
            this.BtnEliminarApertura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarApertura.Location = new System.Drawing.Point(6, 170);
            this.BtnEliminarApertura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminarApertura.Name = "BtnEliminarApertura";
            this.BtnEliminarApertura.Size = new System.Drawing.Size(74, 67);
            this.BtnEliminarApertura.TabIndex = 94;
            this.BtnEliminarApertura.Text = "&Eliminar apertura duplicada";
            this.BtnEliminarApertura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarApertura.UseVisualStyleBackColor = false;
            this.BtnEliminarApertura.Click += new System.EventHandler(this.BtnEliminarApertura_Click);
            // 
            // programaRecibo
            // 
            this.programaRecibo.DataPropertyName = "programa";
            this.programaRecibo.HeaderText = "Programa";
            this.programaRecibo.Name = "programaRecibo";
            this.programaRecibo.ReadOnly = true;
            this.programaRecibo.Width = 130;
            // 
            // Id_AperturaCierreCaja
            // 
            this.Id_AperturaCierreCaja.DataPropertyName = "Id_AperturaCierreCaja";
            this.Id_AperturaCierreCaja.HeaderText = "Id_AperturaCierreCaja";
            this.Id_AperturaCierreCaja.Name = "Id_AperturaCierreCaja";
            this.Id_AperturaCierreCaja.ReadOnly = true;
            this.Id_AperturaCierreCaja.Visible = false;
            // 
            // Id_Caja_Usuario
            // 
            this.Id_Caja_Usuario.DataPropertyName = "Id_Caja_Usuario";
            this.Id_Caja_Usuario.HeaderText = "Id_Caja_Usuario";
            this.Id_Caja_Usuario.Name = "Id_Caja_Usuario";
            this.Id_Caja_Usuario.ReadOnly = true;
            this.Id_Caja_Usuario.Visible = false;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.DataPropertyName = "nombre_usuario";
            this.nombre_usuario.HeaderText = "Nombre Cajero";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            this.nombre_usuario.Width = 150;
            // 
            // FechaAperturaCaja_AperturaCierreCaja
            // 
            this.FechaAperturaCaja_AperturaCierreCaja.DataPropertyName = "FechaAperturaCaja_AperturaCierreCaja";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaAperturaCaja_AperturaCierreCaja.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaAperturaCaja_AperturaCierreCaja.HeaderText = "Fecha Aper.";
            this.FechaAperturaCaja_AperturaCierreCaja.Name = "FechaAperturaCaja_AperturaCierreCaja";
            this.FechaAperturaCaja_AperturaCierreCaja.ReadOnly = true;
            this.FechaAperturaCaja_AperturaCierreCaja.Width = 80;
            // 
            // HoraAperturaCaja_AperturaCierreCaja
            // 
            this.HoraAperturaCaja_AperturaCierreCaja.DataPropertyName = "HoraAperturaCaja_AperturaCierreCaja";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.HoraAperturaCaja_AperturaCierreCaja.DefaultCellStyle = dataGridViewCellStyle8;
            this.HoraAperturaCaja_AperturaCierreCaja.HeaderText = "Hora Aper.";
            this.HoraAperturaCaja_AperturaCierreCaja.Name = "HoraAperturaCaja_AperturaCierreCaja";
            this.HoraAperturaCaja_AperturaCierreCaja.ReadOnly = true;
            this.HoraAperturaCaja_AperturaCierreCaja.Width = 70;
            // 
            // FechaCierreCaja_AperturaCierreCaja
            // 
            this.FechaCierreCaja_AperturaCierreCaja.DataPropertyName = "FechaCierreCaja_AperturaCierreCaja";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaCierreCaja_AperturaCierreCaja.DefaultCellStyle = dataGridViewCellStyle9;
            this.FechaCierreCaja_AperturaCierreCaja.HeaderText = "Fecha Cierre";
            this.FechaCierreCaja_AperturaCierreCaja.Name = "FechaCierreCaja_AperturaCierreCaja";
            this.FechaCierreCaja_AperturaCierreCaja.ReadOnly = true;
            this.FechaCierreCaja_AperturaCierreCaja.Width = 80;
            // 
            // HoraCierreCaja_AperturaCierreCaja
            // 
            this.HoraCierreCaja_AperturaCierreCaja.DataPropertyName = "HoraCierreCaja_AperturaCierreCaja";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.HoraCierreCaja_AperturaCierreCaja.DefaultCellStyle = dataGridViewCellStyle10;
            this.HoraCierreCaja_AperturaCierreCaja.HeaderText = "Hora Cierre";
            this.HoraCierreCaja_AperturaCierreCaja.Name = "HoraCierreCaja_AperturaCierreCaja";
            this.HoraCierreCaja_AperturaCierreCaja.ReadOnly = true;
            this.HoraCierreCaja_AperturaCierreCaja.Width = 70;
            // 
            // Observacion_AperturaCierreCaja
            // 
            this.Observacion_AperturaCierreCaja.DataPropertyName = "Observacion_AperturaCierreCaja";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Observacion_AperturaCierreCaja.DefaultCellStyle = dataGridViewCellStyle11;
            this.Observacion_AperturaCierreCaja.HeaderText = "Estado";
            this.Observacion_AperturaCierreCaja.Name = "Observacion_AperturaCierreCaja";
            this.Observacion_AperturaCierreCaja.ReadOnly = true;
            this.Observacion_AperturaCierreCaja.Width = 80;
            // 
            // nroPliego
            // 
            this.nroPliego.DataPropertyName = "nroPliego";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nroPliego.DefaultCellStyle = dataGridViewCellStyle12;
            this.nroPliego.HeaderText = "Nro Pliego";
            this.nroPliego.Name = "nroPliego";
            this.nroPliego.ReadOnly = true;
            this.nroPliego.Width = 60;
            // 
            // Total_Debe
            // 
            this.Total_Debe.DataPropertyName = "Total_Debe";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle13.Format = "N2";
            this.Total_Debe.DefaultCellStyle = dataGridViewCellStyle13;
            this.Total_Debe.HeaderText = "Total_Debe";
            this.Total_Debe.Name = "Total_Debe";
            this.Total_Debe.ReadOnly = true;
            this.Total_Debe.Width = 80;
            // 
            // Total_Haber
            // 
            this.Total_Haber.DataPropertyName = "Total_Haber";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle14.Format = "N2";
            this.Total_Haber.DefaultCellStyle = dataGridViewCellStyle14;
            this.Total_Haber.HeaderText = "Total_Haber";
            this.Total_Haber.Name = "Total_Haber";
            this.Total_Haber.ReadOnly = true;
            this.Total_Haber.Width = 80;
            // 
            // UsuarioEstacion_AperturaCierreCaja
            // 
            this.UsuarioEstacion_AperturaCierreCaja.DataPropertyName = "UsuarioEstacion_AperturaCierreCaja";
            this.UsuarioEstacion_AperturaCierreCaja.HeaderText = "Usuario PC";
            this.UsuarioEstacion_AperturaCierreCaja.Name = "UsuarioEstacion_AperturaCierreCaja";
            this.UsuarioEstacion_AperturaCierreCaja.ReadOnly = true;
            this.UsuarioEstacion_AperturaCierreCaja.Width = 80;
            // 
            // frmRecibosIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 491);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.lblNroRecibos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.LblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRecibosIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Recibos de Ingreso:::...";
            this.Load += new System.EventHandler(this.frmRecibosIngreso_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibosGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvRecibos;
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button BtnReciboIngreso;
        internal System.Windows.Forms.Button btnListadoContable;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        internal System.Windows.Forms.DataGridView dgvRecibosGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHaber;
        internal System.Windows.Forms.Button btnVolverGenerar;
        private System.Windows.Forms.CheckBox chkPorCajero;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboPrograma;
        internal System.Windows.Forms.Label lblNroRecibos;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtHaber;
        internal System.Windows.Forms.TextBox txtDebe;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button BtnEliminarApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn programaRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Caja_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAperturaCaja_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraAperturaCaja_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCierreCaja_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraCierreCaja_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion_AperturaCierreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroPliego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioEstacion_AperturaCierreCaja;
    }
}