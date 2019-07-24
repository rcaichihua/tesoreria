namespace GUI_Tesoreria.Gerencia
{
    partial class frmIngresoPorCajeroDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoPorCajeroDia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.cboPrograma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GBSolicitante = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.dgvIngresosxCajero = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTEING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MORAING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTOING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGVING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROPAGOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.GBSolicitante.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosxCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BtnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.cboPrograma);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.GBSolicitante);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.GBDatosRubros);
            this.splitContainer1.Size = new System.Drawing.Size(908, 521);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 28;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(328, 63);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(66, 36);
            this.BtnBuscar.TabIndex = 122;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // cboPrograma
            // 
            this.cboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrograma.FormattingEnabled = true;
            this.cboPrograma.Location = new System.Drawing.Point(88, 70);
            this.cboPrograma.Name = "cboPrograma";
            this.cboPrograma.Size = new System.Drawing.Size(234, 23);
            this.cboPrograma.TabIndex = 121;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(12, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 120;
            this.label8.Text = "Programa";
            // 
            // GBSolicitante
            // 
            this.GBSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.GBSolicitante.Controls.Add(this.dtpHasta);
            this.GBSolicitante.Controls.Add(this.dtpDesde);
            this.GBSolicitante.Controls.Add(this.label6);
            this.GBSolicitante.Controls.Add(this.label7);
            this.GBSolicitante.Controls.Add(this.Label2);
            this.GBSolicitante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSolicitante.ForeColor = System.Drawing.Color.Maroon;
            this.GBSolicitante.Location = new System.Drawing.Point(10, 11);
            this.GBSolicitante.Name = "GBSolicitante";
            this.GBSolicitante.Size = new System.Drawing.Size(892, 54);
            this.GBSolicitante.TabIndex = 3;
            this.GBSolicitante.TabStop = false;
            this.GBSolicitante.Text = "Filtro por fecha";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(229, 17);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(96, 21);
            this.dtpHasta.TabIndex = 28;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(75, 17);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(96, 21);
            this.dtpDesde.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 38);
            this.label6.TabIndex = 27;
            this.label6.Text = "INGRESOS POR CAJA - DIARIO\r\nSOCIEDAD DE BENEFICENCIA DE LIMA METROPOLITANA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(177, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Hasta :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(21, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Desde :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMora);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDscto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIgv);
            this.groupBox2.Controls.Add(this.LblTotal);
            this.groupBox2.Location = new System.Drawing.Point(212, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(586, 81);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.Color.White;
            this.txtImporte.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.Maroon;
            this.txtImporte.Location = new System.Drawing.Point(5, 34);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.ReadOnly = true;
            this.txtImporte.Size = new System.Drawing.Size(113, 22);
            this.txtImporte.TabIndex = 117;
            this.txtImporte.Text = "0.00";
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(545, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(436, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(145, 22);
            this.txtTotal.TabIndex = 117;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(392, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 118;
            this.label4.Text = "IGV";
            // 
            // txtMora
            // 
            this.txtMora.BackColor = System.Drawing.Color.White;
            this.txtMora.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMora.ForeColor = System.Drawing.Color.Maroon;
            this.txtMora.Location = new System.Drawing.Point(123, 34);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.Size = new System.Drawing.Size(92, 22);
            this.txtMora.TabIndex = 117;
            this.txtMora.Text = "0.00";
            this.txtMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(278, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Dscto";
            // 
            // txtDscto
            // 
            this.txtDscto.BackColor = System.Drawing.Color.White;
            this.txtDscto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscto.ForeColor = System.Drawing.Color.Maroon;
            this.txtDscto.Location = new System.Drawing.Point(221, 34);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.ReadOnly = true;
            this.txtDscto.Size = new System.Drawing.Size(93, 22);
            this.txtDscto.TabIndex = 117;
            this.txtDscto.Text = "0.00";
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(182, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 118;
            this.label1.Text = "Mora";
            // 
            // txtIgv
            // 
            this.txtIgv.BackColor = System.Drawing.Color.White;
            this.txtIgv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.Color.Maroon;
            this.txtIgv.Location = new System.Drawing.Point(320, 34);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(110, 22);
            this.txtIgv.TabIndex = 117;
            this.txtIgv.Text = "0.00";
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(68, 17);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(54, 13);
            this.LblTotal.TabIndex = 118;
            this.LblTotal.Text = "Importe";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(830, 328);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 58);
            this.btnSalir.TabIndex = 96;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnImprimir);
            this.groupBox1.Location = new System.Drawing.Point(9, 321);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(198, 81);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.Location = new System.Drawing.Point(22, 16);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(71, 48);
            this.BtnImprimir.TabIndex = 94;
            this.BtnImprimir.Text = "&Mandar 1";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvIngresosxCajero);
            this.GBDatosRubros.Location = new System.Drawing.Point(3, 3);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(902, 312);
            this.GBDatosRubros.TabIndex = 115;
            this.GBDatosRubros.TabStop = false;
            // 
            // dgvIngresosxCajero
            // 
            this.dgvIngresosxCajero.AllowUserToAddRows = false;
            this.dgvIngresosxCajero.AllowUserToDeleteRows = false;
            this.dgvIngresosxCajero.AllowUserToResizeColumns = false;
            this.dgvIngresosxCajero.AllowUserToResizeRows = false;
            this.dgvIngresosxCajero.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresosxCajero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvIngresosxCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosxCajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRECAJERO,
            this.FECHA,
            this.IMPORTEING,
            this.MORAING,
            this.DESCUENTOING,
            this.IGVING,
            this.TOTALING,
            this.NROPAGOS});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresosxCajero.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvIngresosxCajero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosxCajero.Location = new System.Drawing.Point(3, 16);
            this.dgvIngresosxCajero.Name = "dgvIngresosxCajero";
            this.dgvIngresosxCajero.ReadOnly = true;
            this.dgvIngresosxCajero.RowHeadersVisible = false;
            this.dgvIngresosxCajero.RowHeadersWidth = 10;
            this.dgvIngresosxCajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresosxCajero.Size = new System.Drawing.Size(896, 293);
            this.dgvIngresosxCajero.TabIndex = 4;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle24;
            this.CODIGO.HeaderText = "COD.";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CODIGO.Visible = false;
            this.CODIGO.Width = 70;
            // 
            // NOMBRECAJERO
            // 
            this.NOMBRECAJERO.DataPropertyName = "NOMBRES";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.NOMBRECAJERO.DefaultCellStyle = dataGridViewCellStyle25;
            this.NOMBRECAJERO.HeaderText = "PROGRAMA - NOMBRE DE CAJERO";
            this.NOMBRECAJERO.Name = "NOMBRECAJERO";
            this.NOMBRECAJERO.ReadOnly = true;
            this.NOMBRECAJERO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRECAJERO.Width = 260;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle26;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 80;
            // 
            // IMPORTEING
            // 
            this.IMPORTEING.DataPropertyName = "IMPORTEING";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.Format = "N2";
            this.IMPORTEING.DefaultCellStyle = dataGridViewCellStyle27;
            this.IMPORTEING.HeaderText = "IMPORTE";
            this.IMPORTEING.Name = "IMPORTEING";
            this.IMPORTEING.ReadOnly = true;
            this.IMPORTEING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MORAING
            // 
            this.MORAING.DataPropertyName = "MORA";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Format = "N2";
            this.MORAING.DefaultCellStyle = dataGridViewCellStyle28;
            this.MORAING.HeaderText = "MORA";
            this.MORAING.Name = "MORAING";
            this.MORAING.ReadOnly = true;
            this.MORAING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MORAING.Width = 80;
            // 
            // DESCUENTOING
            // 
            this.DESCUENTOING.DataPropertyName = "DESCUENTO";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.Format = "N2";
            this.DESCUENTOING.DefaultCellStyle = dataGridViewCellStyle29;
            this.DESCUENTOING.HeaderText = "DSCTO";
            this.DESCUENTOING.Name = "DESCUENTOING";
            this.DESCUENTOING.ReadOnly = true;
            this.DESCUENTOING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCUENTOING.Width = 80;
            // 
            // IGVING
            // 
            this.IGVING.DataPropertyName = "IGV";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle30.Format = "N2";
            this.IGVING.DefaultCellStyle = dataGridViewCellStyle30;
            this.IGVING.HeaderText = "IGV";
            this.IGVING.Name = "IGVING";
            this.IGVING.ReadOnly = true;
            this.IGVING.Width = 90;
            // 
            // TOTALING
            // 
            this.TOTALING.DataPropertyName = "TOTAL";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle31.Format = "N2";
            this.TOTALING.DefaultCellStyle = dataGridViewCellStyle31;
            this.TOTALING.HeaderText = "TOTAL";
            this.TOTALING.Name = "TOTALING";
            this.TOTALING.ReadOnly = true;
            // 
            // NROPAGOS
            // 
            this.NROPAGOS.DataPropertyName = "NROPAGOS";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NROPAGOS.DefaultCellStyle = dataGridViewCellStyle32;
            this.NROPAGOS.HeaderText = "Nº PAGOS";
            this.NROPAGOS.Name = "NROPAGOS";
            this.NROPAGOS.ReadOnly = true;
            this.NROPAGOS.Width = 70;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(101, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 48);
            this.button1.TabIndex = 94;
            this.button1.Text = "&Por día";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIngresoPorCajeroDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 521);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmIngresoPorCajeroDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Ingreso acumulado por Cajero - Dia";
            this.Load += new System.EventHandler(this.frmIngresoPorCajeroDia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.GBSolicitante.ResumeLayout(false);
            this.GBSolicitante.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosxCajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        internal System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.ComboBox cboPrograma;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.GroupBox GBSolicitante;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtImporte;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtMora;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtDscto;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtIgv;
        internal System.Windows.Forms.Label LblTotal;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button BtnImprimir;
        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView dgvIngresosxCajero;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECAJERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTEING;
        private System.Windows.Forms.DataGridViewTextBoxColumn MORAING;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTOING;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGVING;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALING;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROPAGOS;
        internal System.Windows.Forms.Button button1;
    }
}