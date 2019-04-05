namespace GUI_Tesoreria.DGAI
{
    partial class frmGeneraLiquidacionDGAI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBSolicitante = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnListLiquidaciones = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.btnGenerarDoscIngreso = new System.Windows.Forms.Button();
            this.dgvIngresosxCajero = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDifDep = new System.Windows.Forms.TextBox();
            this.txtDscto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.txtRetencion = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNro = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnListDoc = new System.Windows.Forms.Button();
            this.btnResumen = new System.Windows.Forms.Button();
            this.btnGeneraLiquidacion = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECAJERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPORTEING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MORAING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCUENTOING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGVING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NROPAGOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHACANCELACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALDEPOSITADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIFDEPOSITOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDLIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdLiquidacion = new System.Windows.Forms.Label();
            this.GBSolicitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosxCajero)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBSolicitante
            // 
            this.GBSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.GBSolicitante.Controls.Add(this.dtpHasta);
            this.GBSolicitante.Controls.Add(this.dtpFechaDesde);
            this.GBSolicitante.Controls.Add(this.label1);
            this.GBSolicitante.Controls.Add(this.Label2);
            this.GBSolicitante.Controls.Add(this.btnAsignar);
            this.GBSolicitante.Controls.Add(this.btnListLiquidaciones);
            this.GBSolicitante.Controls.Add(this.BtnBuscar);
            this.GBSolicitante.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSolicitante.ForeColor = System.Drawing.Color.Maroon;
            this.GBSolicitante.Location = new System.Drawing.Point(10, 11);
            this.GBSolicitante.Name = "GBSolicitante";
            this.GBSolicitante.Size = new System.Drawing.Size(652, 81);
            this.GBSolicitante.TabIndex = 1;
            this.GBSolicitante.TabStop = false;
            this.GBSolicitante.Text = "Ingreso Fecha de caja a liquidar";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(218, 31);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(102, 21);
            this.dtpHasta.TabIndex = 0;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Enabled = false;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(63, 31);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(102, 21);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(167, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hasta :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(10, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Desde :";
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.White;
            this.btnAsignar.Enabled = false;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.ForeColor = System.Drawing.Color.Navy;
            this.btnAsignar.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnAsignar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignar.Location = new System.Drawing.Point(462, 15);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(184, 29);
            this.btnAsignar.TabIndex = 1;
            this.btnAsignar.Text = "&Asignar vouchers";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnListLiquidaciones
            // 
            this.btnListLiquidaciones.BackColor = System.Drawing.Color.White;
            this.btnListLiquidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLiquidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLiquidaciones.ForeColor = System.Drawing.Color.Navy;
            this.btnListLiquidaciones.Image = global::GUI_Tesoreria.Properties.Resources.listar;
            this.btnListLiquidaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListLiquidaciones.Location = new System.Drawing.Point(462, 46);
            this.btnListLiquidaciones.Name = "btnListLiquidaciones";
            this.btnListLiquidaciones.Size = new System.Drawing.Size(184, 29);
            this.btnListLiquidaciones.TabIndex = 1;
            this.btnListLiquidaciones.Text = "&Listado liquidaciones";
            this.btnListLiquidaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListLiquidaciones.UseVisualStyleBackColor = false;
            this.btnListLiquidaciones.Click += new System.EventHandler(this.btnListLiquidaciones_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = global::GUI_Tesoreria.Properties.Resources.buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(325, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(80, 34);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnGenerarDoscIngreso
            // 
            this.btnGenerarDoscIngreso.BackColor = System.Drawing.Color.White;
            this.btnGenerarDoscIngreso.Enabled = false;
            this.btnGenerarDoscIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarDoscIngreso.ForeColor = System.Drawing.Color.Navy;
            this.btnGenerarDoscIngreso.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnGenerarDoscIngreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarDoscIngreso.Location = new System.Drawing.Point(668, 87);
            this.btnGenerarDoscIngreso.Name = "btnGenerarDoscIngreso";
            this.btnGenerarDoscIngreso.Size = new System.Drawing.Size(33, 29);
            this.btnGenerarDoscIngreso.TabIndex = 1;
            this.btnGenerarDoscIngreso.Text = "&Generar Docs. de Ingresos";
            this.btnGenerarDoscIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarDoscIngreso.UseVisualStyleBackColor = false;
            this.btnGenerarDoscIngreso.Visible = false;
            this.btnGenerarDoscIngreso.Click += new System.EventHandler(this.btnIngresosPorRubro_Click);
            // 
            // dgvIngresosxCajero
            // 
            this.dgvIngresosxCajero.AllowUserToAddRows = false;
            this.dgvIngresosxCajero.AllowUserToDeleteRows = false;
            this.dgvIngresosxCajero.AllowUserToResizeColumns = false;
            this.dgvIngresosxCajero.AllowUserToResizeRows = false;
            this.dgvIngresosxCajero.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresosxCajero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvIngresosxCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresosxCajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRECAJERO,
            this.IMPORTEING,
            this.MORAING,
            this.DESCUENTOING,
            this.IGVING,
            this.TOTALING,
            this.NROPAGOS,
            this.FECHACANCELACION,
            this.TOTALDEPOSITADO,
            this.DIFDEPOSITOS,
            this.IDLIQUIDACION});
            dataGridViewCellStyle60.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle60.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle60.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresosxCajero.DefaultCellStyle = dataGridViewCellStyle60;
            this.dgvIngresosxCajero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngresosxCajero.Location = new System.Drawing.Point(3, 17);
            this.dgvIngresosxCajero.Name = "dgvIngresosxCajero";
            this.dgvIngresosxCajero.ReadOnly = true;
            this.dgvIngresosxCajero.RowHeadersVisible = false;
            this.dgvIngresosxCajero.RowHeadersWidth = 10;
            this.dgvIngresosxCajero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvIngresosxCajero.Size = new System.Drawing.Size(862, 254);
            this.dgvIngresosxCajero.TabIndex = 5;
            this.dgvIngresosxCajero.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIngresosxCajero_CellFormatting);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMora);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDifDep);
            this.groupBox2.Controls.Add(this.txtDscto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIgv);
            this.groupBox2.Controls.Add(this.LblTotal);
            this.groupBox2.Location = new System.Drawing.Point(170, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(618, 71);
            this.groupBox2.TabIndex = 123;
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
            this.label5.Location = new System.Drawing.Point(482, 17);
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
            this.txtTotal.Location = new System.Drawing.Point(399, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(119, 22);
            this.txtTotal.TabIndex = 117;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(355, 17);
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(560, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 118;
            this.label16.Text = "Dif. Dep.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(241, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Dscto";
            // 
            // txtDifDep
            // 
            this.txtDifDep.BackColor = System.Drawing.Color.White;
            this.txtDifDep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDifDep.ForeColor = System.Drawing.Color.Maroon;
            this.txtDifDep.Location = new System.Drawing.Point(524, 34);
            this.txtDifDep.Name = "txtDifDep";
            this.txtDifDep.ReadOnly = true;
            this.txtDifDep.Size = new System.Drawing.Size(89, 22);
            this.txtDifDep.TabIndex = 117;
            this.txtDifDep.Text = "0.00";
            this.txtDifDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDscto
            // 
            this.txtDscto.BackColor = System.Drawing.Color.White;
            this.txtDscto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDscto.ForeColor = System.Drawing.Color.Maroon;
            this.txtDscto.Location = new System.Drawing.Point(221, 34);
            this.txtDscto.Name = "txtDscto";
            this.txtDscto.ReadOnly = true;
            this.txtDscto.Size = new System.Drawing.Size(59, 22);
            this.txtDscto.TabIndex = 117;
            this.txtDscto.Text = "0.00";
            this.txtDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(182, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 118;
            this.label6.Text = "Mora";
            // 
            // txtIgv
            // 
            this.txtIgv.BackColor = System.Drawing.Color.White;
            this.txtIgv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.Color.Maroon;
            this.txtIgv.Location = new System.Drawing.Point(283, 34);
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
            // txtRetencion
            // 
            this.txtRetencion.BackColor = System.Drawing.Color.White;
            this.txtRetencion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRetencion.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetencion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRetencion.Location = new System.Drawing.Point(668, 42);
            this.txtRetencion.Name = "txtRetencion";
            this.txtRetencion.ReadOnly = true;
            this.txtRetencion.Size = new System.Drawing.Size(205, 22);
            this.txtRetencion.TabIndex = 125;
            this.txtRetencion.Text = "0.00";
            this.txtRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Navy;
            this.label30.Location = new System.Drawing.Point(665, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(208, 13);
            this.label30.TabIndex = 124;
            this.label30.Text = "Total Retenciones, embargos otros.";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.NavajoWhite;
            this.label13.Location = new System.Drawing.Point(109, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 21);
            this.label13.TabIndex = 128;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(129, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 129;
            this.label11.Text = "Asignado Parcial";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.YellowGreen;
            this.label8.Location = new System.Drawing.Point(237, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 21);
            this.label8.TabIndex = 126;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(257, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 131;
            this.label10.Text = "Asignado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(32, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 130;
            this.label9.Text = "Sin Asignar";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(12, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 21);
            this.label7.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(342, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(208, 13);
            this.label12.TabIndex = 131;
            this.label12.Text = "Sin número de liquidación asignado";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(322, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 21);
            this.label14.TabIndex = 126;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(748, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 24);
            this.label15.TabIndex = 132;
            this.label15.Text = "N°";
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNro.ForeColor = System.Drawing.Color.Navy;
            this.lblNro.Location = new System.Drawing.Point(786, 68);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(87, 24);
            this.lblNro.TabIndex = 132;
            this.lblNro.Text = "0000000";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownHeight = 200;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.IntegralHeight = false;
            this.cboTipo.Items.AddRange(new object[] {
            "DETRACCION",
            "JUDICIAL",
            "GARANTIA",
            "OTROS"});
            this.cboTipo.Location = new System.Drawing.Point(10, 439);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(91, 21);
            this.cboTipo.TabIndex = 133;
            // 
            // btnListDoc
            // 
            this.btnListDoc.BackColor = System.Drawing.Color.White;
            this.btnListDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDoc.ForeColor = System.Drawing.Color.Navy;
            this.btnListDoc.Image = global::GUI_Tesoreria.Properties.Resources.listar;
            this.btnListDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListDoc.Location = new System.Drawing.Point(707, 87);
            this.btnListDoc.Name = "btnListDoc";
            this.btnListDoc.Size = new System.Drawing.Size(26, 29);
            this.btnListDoc.TabIndex = 1;
            this.btnListDoc.Text = "&Listado Doc. Ing.";
            this.btnListDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListDoc.UseVisualStyleBackColor = false;
            this.btnListDoc.Visible = false;
            this.btnListDoc.Click += new System.EventHandler(this.btnListDoc_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.BackColor = System.Drawing.Color.White;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.ForeColor = System.Drawing.Color.Navy;
            this.btnResumen.Image = global::GUI_Tesoreria.Properties.Resources.ver;
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.Location = new System.Drawing.Point(107, 439);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(58, 34);
            this.btnResumen.TabIndex = 1;
            this.btnResumen.Text = "&Ver";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // btnGeneraLiquidacion
            // 
            this.btnGeneraLiquidacion.BackColor = System.Drawing.Color.White;
            this.btnGeneraLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraLiquidacion.ForeColor = System.Drawing.Color.Navy;
            this.btnGeneraLiquidacion.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnGeneraLiquidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneraLiquidacion.Location = new System.Drawing.Point(10, 399);
            this.btnGeneraLiquidacion.Name = "btnGeneraLiquidacion";
            this.btnGeneraLiquidacion.Size = new System.Drawing.Size(155, 34);
            this.btnGeneraLiquidacion.TabIndex = 1;
            this.btnGeneraLiquidacion.Text = "&Generar Liquidación";
            this.btnGeneraLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneraLiquidacion.UseVisualStyleBackColor = false;
            this.btnGeneraLiquidacion.Click += new System.EventHandler(this.btnGeneraLiquidacion_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvIngresosxCajero);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(10, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(868, 274);
            this.groupBox3.TabIndex = 146;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de ingresos por cobrador";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(809, 402);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 71);
            this.btnCancelar.TabIndex = 147;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CODIGO.DefaultCellStyle = dataGridViewCellStyle50;
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
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
            this.NOMBRECAJERO.DefaultCellStyle = dataGridViewCellStyle51;
            this.NOMBRECAJERO.HeaderText = "NOMBRE COBRADOR";
            this.NOMBRECAJERO.Name = "NOMBRECAJERO";
            this.NOMBRECAJERO.ReadOnly = true;
            this.NOMBRECAJERO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NOMBRECAJERO.Width = 245;
            // 
            // IMPORTEING
            // 
            this.IMPORTEING.DataPropertyName = "IMPORTEING";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle52.Format = "N2";
            this.IMPORTEING.DefaultCellStyle = dataGridViewCellStyle52;
            this.IMPORTEING.HeaderText = "IMPORTE";
            this.IMPORTEING.Name = "IMPORTEING";
            this.IMPORTEING.ReadOnly = true;
            this.IMPORTEING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IMPORTEING.Width = 80;
            // 
            // MORAING
            // 
            this.MORAING.DataPropertyName = "MORA";
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle53.Format = "N2";
            this.MORAING.DefaultCellStyle = dataGridViewCellStyle53;
            this.MORAING.HeaderText = "MORA";
            this.MORAING.Name = "MORAING";
            this.MORAING.ReadOnly = true;
            this.MORAING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MORAING.Width = 70;
            // 
            // DESCUENTOING
            // 
            this.DESCUENTOING.DataPropertyName = "DESCUENTO";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.Format = "N2";
            this.DESCUENTOING.DefaultCellStyle = dataGridViewCellStyle54;
            this.DESCUENTOING.HeaderText = "DSCTO";
            this.DESCUENTOING.Name = "DESCUENTOING";
            this.DESCUENTOING.ReadOnly = true;
            this.DESCUENTOING.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCUENTOING.Width = 50;
            // 
            // IGVING
            // 
            this.IGVING.DataPropertyName = "IGV";
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle55.Format = "N2";
            this.IGVING.DefaultCellStyle = dataGridViewCellStyle55;
            this.IGVING.HeaderText = "IGV";
            this.IGVING.Name = "IGVING";
            this.IGVING.ReadOnly = true;
            this.IGVING.Width = 75;
            // 
            // TOTALING
            // 
            this.TOTALING.DataPropertyName = "TOTAL";
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle56.Format = "N2";
            this.TOTALING.DefaultCellStyle = dataGridViewCellStyle56;
            this.TOTALING.HeaderText = "TOTAL";
            this.TOTALING.Name = "TOTALING";
            this.TOTALING.ReadOnly = true;
            this.TOTALING.Width = 90;
            // 
            // NROPAGOS
            // 
            this.NROPAGOS.DataPropertyName = "NROPAGOS";
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NROPAGOS.DefaultCellStyle = dataGridViewCellStyle57;
            this.NROPAGOS.HeaderText = "Nº PAGOS";
            this.NROPAGOS.Name = "NROPAGOS";
            this.NROPAGOS.ReadOnly = true;
            this.NROPAGOS.Width = 65;
            // 
            // FECHACANCELACION
            // 
            this.FECHACANCELACION.DataPropertyName = "FECHACANCELACION";
            this.FECHACANCELACION.HeaderText = "FECHACANCELACION";
            this.FECHACANCELACION.Name = "FECHACANCELACION";
            this.FECHACANCELACION.ReadOnly = true;
            this.FECHACANCELACION.Visible = false;
            // 
            // TOTALDEPOSITADO
            // 
            this.TOTALDEPOSITADO.DataPropertyName = "TOTALDEPOSITADO";
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle58.Format = "N2";
            dataGridViewCellStyle58.NullValue = "0.00";
            this.TOTALDEPOSITADO.DefaultCellStyle = dataGridViewCellStyle58;
            this.TOTALDEPOSITADO.HeaderText = "TOTAL DEPOSITADO";
            this.TOTALDEPOSITADO.Name = "TOTALDEPOSITADO";
            this.TOTALDEPOSITADO.ReadOnly = true;
            this.TOTALDEPOSITADO.Width = 80;
            // 
            // DIFDEPOSITOS
            // 
            this.DIFDEPOSITOS.DataPropertyName = "DIFDEPOSITOS";
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle59.Format = "N2";
            dataGridViewCellStyle59.NullValue = "0.00";
            this.DIFDEPOSITOS.DefaultCellStyle = dataGridViewCellStyle59;
            this.DIFDEPOSITOS.HeaderText = "DIF DEPOSITOS";
            this.DIFDEPOSITOS.Name = "DIFDEPOSITOS";
            this.DIFDEPOSITOS.ReadOnly = true;
            this.DIFDEPOSITOS.Width = 90;
            // 
            // IDLIQUIDACION
            // 
            this.IDLIQUIDACION.DataPropertyName = "IDLIQUIDACION";
            this.IDLIQUIDACION.HeaderText = "IDLIQUIDACION";
            this.IDLIQUIDACION.Name = "IDLIQUIDACION";
            this.IDLIQUIDACION.ReadOnly = true;
            this.IDLIQUIDACION.Visible = false;
            // 
            // lblIdLiquidacion
            // 
            this.lblIdLiquidacion.AutoSize = true;
            this.lblIdLiquidacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLiquidacion.ForeColor = System.Drawing.Color.Navy;
            this.lblIdLiquidacion.Location = new System.Drawing.Point(805, 92);
            this.lblIdLiquidacion.Name = "lblIdLiquidacion";
            this.lblIdLiquidacion.Size = new System.Drawing.Size(21, 24);
            this.lblIdLiquidacion.TabIndex = 132;
            this.lblIdLiquidacion.Text = "0";
            this.lblIdLiquidacion.Visible = false;
            // 
            // frmGeneraLiquidacionDGAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 483);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblNro);
            this.Controls.Add(this.lblIdLiquidacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnListDoc);
            this.Controls.Add(this.btnGenerarDoscIngreso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRetencion);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GBSolicitante);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.btnGeneraLiquidacion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmGeneraLiquidacionDGAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Ingreso Liquidación DGAI:::...";
            this.GBSolicitante.ResumeLayout(false);
            this.GBSolicitante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresosxCajero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBSolicitante;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvIngresosxCajero;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtImporte;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtMora;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtDscto;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtIgv;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.Button btnAsignar;
        internal System.Windows.Forms.Button btnGeneraLiquidacion;
        internal System.Windows.Forms.TextBox txtRetencion;
        internal System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNro;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtDifDep;
        internal System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.ComboBox cboTipo;
        internal System.Windows.Forms.Button btnGenerarDoscIngreso;
        internal System.Windows.Forms.Button btnListLiquidaciones;
        internal System.Windows.Forms.Button btnListDoc;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECAJERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPORTEING;
        private System.Windows.Forms.DataGridViewTextBoxColumn MORAING;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCUENTOING;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGVING;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALING;
        private System.Windows.Forms.DataGridViewTextBoxColumn NROPAGOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHACANCELACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALDEPOSITADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIFDEPOSITOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLIQUIDACION;
        private System.Windows.Forms.Label lblIdLiquidacion;
    }
}