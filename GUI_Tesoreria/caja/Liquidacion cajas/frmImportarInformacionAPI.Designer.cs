namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmImportarInformacionAPI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBPago = new System.Windows.Forms.GroupBox();
            this.btnGeneraCodigoContable = new System.Windows.Forms.Button();
            this.btnImportaLiquidacionInmobiliaria = new System.Windows.Forms.Button();
            this.dtpFechaLiquidacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroPliego = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRenta = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_INMB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_CONTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INQUILINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_RUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCOMPROBANTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_DOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_DOCU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCH_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_MOVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIP_PAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCON_REN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCON_MOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODCON_IGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTOSOLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_COB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMontoSoles = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarLiq = new System.Windows.Forms.Button();
            this.btnModificarLiq = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.BtnSalirC = new System.Windows.Forms.Button();
            this.GBPago.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // GBPago
            // 
            this.GBPago.BackColor = System.Drawing.Color.Transparent;
            this.GBPago.Controls.Add(this.btnGeneraCodigoContable);
            this.GBPago.Controls.Add(this.btnImportaLiquidacionInmobiliaria);
            this.GBPago.Controls.Add(this.dtpFechaLiquidacion);
            this.GBPago.Controls.Add(this.label1);
            this.GBPago.Controls.Add(this.btnImportar);
            this.GBPago.Controls.Add(this.dtpFechaCaja);
            this.GBPago.Controls.Add(this.label3);
            this.GBPago.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBPago.ForeColor = System.Drawing.Color.Maroon;
            this.GBPago.Location = new System.Drawing.Point(12, 12);
            this.GBPago.Name = "GBPago";
            this.GBPago.Size = new System.Drawing.Size(863, 70);
            this.GBPago.TabIndex = 161;
            this.GBPago.TabStop = false;
            this.GBPago.Text = "Filtro de liquidaciones";
            this.GBPago.Enter += new System.EventHandler(this.GBPago_Enter);
            // 
            // btnGeneraCodigoContable
            // 
            this.btnGeneraCodigoContable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeneraCodigoContable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneraCodigoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneraCodigoContable.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneraCodigoContable.ForeColor = System.Drawing.Color.Navy;
            this.btnGeneraCodigoContable.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnGeneraCodigoContable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneraCodigoContable.Location = new System.Drawing.Point(414, 17);
            this.btnGeneraCodigoContable.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGeneraCodigoContable.Name = "btnGeneraCodigoContable";
            this.btnGeneraCodigoContable.Size = new System.Drawing.Size(231, 34);
            this.btnGeneraCodigoContable.TabIndex = 165;
            this.btnGeneraCodigoContable.Text = "&Generación de codigos Contables";
            this.btnGeneraCodigoContable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneraCodigoContable.UseVisualStyleBackColor = false;
            this.btnGeneraCodigoContable.Click += new System.EventHandler(this.btnGeneraCodigoContable_Click);
            // 
            // btnImportaLiquidacionInmobiliaria
            // 
            this.btnImportaLiquidacionInmobiliaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportaLiquidacionInmobiliaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportaLiquidacionInmobiliaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportaLiquidacionInmobiliaria.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportaLiquidacionInmobiliaria.ForeColor = System.Drawing.Color.Navy;
            this.btnImportaLiquidacionInmobiliaria.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnImportaLiquidacionInmobiliaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportaLiquidacionInmobiliaria.Location = new System.Drawing.Point(223, 17);
            this.btnImportaLiquidacionInmobiliaria.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImportaLiquidacionInmobiliaria.Name = "btnImportaLiquidacionInmobiliaria";
            this.btnImportaLiquidacionInmobiliaria.Size = new System.Drawing.Size(181, 34);
            this.btnImportaLiquidacionInmobiliaria.TabIndex = 165;
            this.btnImportaLiquidacionInmobiliaria.Text = "&Importa Liquidacion API";
            this.btnImportaLiquidacionInmobiliaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportaLiquidacionInmobiliaria.UseVisualStyleBackColor = false;
            this.btnImportaLiquidacionInmobiliaria.Click += new System.EventHandler(this.btnImportaLiquidacionInmobiliaria_Click);
            // 
            // dtpFechaLiquidacion
            // 
            this.dtpFechaLiquidacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidacion.Location = new System.Drawing.Point(98, 15);
            this.dtpFechaLiquidacion.Name = "dtpFechaLiquidacion";
            this.dtpFechaLiquidacion.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaLiquidacion.TabIndex = 2;
            this.dtpFechaLiquidacion.ValueChanged += new System.EventHandler(this.dtpFechaLiquidacion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Liqui";
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Image = global::GUI_Tesoreria.Properties.Resources.procesar;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportar.Location = new System.Drawing.Point(656, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(201, 44);
            this.btnImportar.TabIndex = 147;
            this.btnImportar.Text = "&Importar Información del API";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Visible = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(98, 42);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(117, 21);
            this.dtpFechaCaja.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(7, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha de Caja";
            // 
            // txtNroPliego
            // 
            this.txtNroPliego.BackColor = System.Drawing.Color.White;
            this.txtNroPliego.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroPliego.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroPliego.ForeColor = System.Drawing.Color.Maroon;
            this.txtNroPliego.Location = new System.Drawing.Point(1027, 411);
            this.txtNroPliego.Name = "txtNroPliego";
            this.txtNroPliego.Size = new System.Drawing.Size(116, 21);
            this.txtNroPliego.TabIndex = 149;
            this.txtNroPliego.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNroPliego.Visible = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(1024, 367);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(105, 13);
            this.LblTotal.TabIndex = 148;
            this.LblTotal.Text = "Número de Pliego";
            this.LblTotal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(342, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Renta";
            // 
            // txtRenta
            // 
            this.txtRenta.BackColor = System.Drawing.Color.White;
            this.txtRenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRenta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRenta.ForeColor = System.Drawing.Color.Maroon;
            this.txtRenta.Location = new System.Drawing.Point(384, 446);
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.ReadOnly = true;
            this.txtRenta.Size = new System.Drawing.Size(118, 21);
            this.txtRenta.TabIndex = 149;
            this.txtRenta.Text = "0.00";
            this.txtRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvListado);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(863, 351);
            this.groupBox2.TabIndex = 171;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeColumns = false;
            this.dgvListado.AllowUserToResizeRows = false;
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.COD_INMB,
            this.NUM_CONTR,
            this.INQUILINO,
            this.NUM_RUC,
            this.IDCOMPROBANTE,
            this.AA,
            this.MM,
            this.TIP_DOCU,
            this.NRO_DOCU,
            this.FCH_PAGO,
            this.TIP_MOVI,
            this.TIP_PAGO,
            this.CODCON_REN,
            this.CODCON_MOR,
            this.CODCON_IGV,
            this.MONTOSOLES,
            this.RENTA,
            this.IGV,
            this.MORA,
            this.COD_COB});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListado.Location = new System.Drawing.Point(3, 17);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.RowHeadersWidth = 10;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(857, 331);
            this.dgvListado.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // COD_INMB
            // 
            this.COD_INMB.DataPropertyName = "COD_INMB";
            this.COD_INMB.HeaderText = "COD_INMB";
            this.COD_INMB.Name = "COD_INMB";
            this.COD_INMB.ReadOnly = true;
            // 
            // NUM_CONTR
            // 
            this.NUM_CONTR.DataPropertyName = "NUM_CONTR";
            this.NUM_CONTR.HeaderText = "NUM CONTR";
            this.NUM_CONTR.Name = "NUM_CONTR";
            this.NUM_CONTR.ReadOnly = true;
            this.NUM_CONTR.Width = 50;
            // 
            // INQUILINO
            // 
            this.INQUILINO.DataPropertyName = "INQUILINO";
            this.INQUILINO.HeaderText = "INQUILINO";
            this.INQUILINO.Name = "INQUILINO";
            this.INQUILINO.ReadOnly = true;
            // 
            // NUM_RUC
            // 
            this.NUM_RUC.DataPropertyName = "NUM_RUC";
            this.NUM_RUC.HeaderText = "NUM RUC";
            this.NUM_RUC.Name = "NUM_RUC";
            this.NUM_RUC.ReadOnly = true;
            this.NUM_RUC.Width = 70;
            // 
            // IDCOMPROBANTE
            // 
            this.IDCOMPROBANTE.DataPropertyName = "IDCOMPROBANTE";
            this.IDCOMPROBANTE.HeaderText = "IDCOMPROBANTE";
            this.IDCOMPROBANTE.Name = "IDCOMPROBANTE";
            this.IDCOMPROBANTE.ReadOnly = true;
            this.IDCOMPROBANTE.Visible = false;
            // 
            // AA
            // 
            this.AA.DataPropertyName = "AA";
            this.AA.HeaderText = "AA";
            this.AA.Name = "AA";
            this.AA.ReadOnly = true;
            this.AA.Width = 50;
            // 
            // MM
            // 
            this.MM.DataPropertyName = "MM";
            this.MM.HeaderText = "MM";
            this.MM.Name = "MM";
            this.MM.ReadOnly = true;
            this.MM.Width = 30;
            // 
            // TIP_DOCU
            // 
            this.TIP_DOCU.DataPropertyName = "TIP_DOCU";
            this.TIP_DOCU.HeaderText = "DOC";
            this.TIP_DOCU.Name = "TIP_DOCU";
            this.TIP_DOCU.ReadOnly = true;
            this.TIP_DOCU.Width = 30;
            // 
            // NRO_DOCU
            // 
            this.NRO_DOCU.DataPropertyName = "NRO_DOCU";
            this.NRO_DOCU.HeaderText = "NRO_DOCU";
            this.NRO_DOCU.Name = "NRO_DOCU";
            this.NRO_DOCU.ReadOnly = true;
            // 
            // FCH_PAGO
            // 
            this.FCH_PAGO.DataPropertyName = "FCH_PAGO";
            this.FCH_PAGO.HeaderText = "FCH_PAGO";
            this.FCH_PAGO.Name = "FCH_PAGO";
            this.FCH_PAGO.ReadOnly = true;
            // 
            // TIP_MOVI
            // 
            this.TIP_MOVI.DataPropertyName = "TIP_MOVI";
            this.TIP_MOVI.HeaderText = "TIP MOVI";
            this.TIP_MOVI.Name = "TIP_MOVI";
            this.TIP_MOVI.ReadOnly = true;
            this.TIP_MOVI.Width = 50;
            // 
            // TIP_PAGO
            // 
            this.TIP_PAGO.DataPropertyName = "TIP_PAGO";
            this.TIP_PAGO.HeaderText = "TIP PAGO";
            this.TIP_PAGO.Name = "TIP_PAGO";
            this.TIP_PAGO.ReadOnly = true;
            this.TIP_PAGO.Width = 50;
            // 
            // CODCON_REN
            // 
            this.CODCON_REN.DataPropertyName = "CODCON_REN";
            this.CODCON_REN.HeaderText = "CODCON_REN";
            this.CODCON_REN.Name = "CODCON_REN";
            this.CODCON_REN.ReadOnly = true;
            this.CODCON_REN.Width = 150;
            // 
            // CODCON_MOR
            // 
            this.CODCON_MOR.DataPropertyName = "CODCON_MOR";
            this.CODCON_MOR.HeaderText = "CODCON_MOR";
            this.CODCON_MOR.Name = "CODCON_MOR";
            this.CODCON_MOR.ReadOnly = true;
            this.CODCON_MOR.Width = 130;
            // 
            // CODCON_IGV
            // 
            this.CODCON_IGV.DataPropertyName = "CODCON_IGV";
            this.CODCON_IGV.HeaderText = "CODCON_IGV";
            this.CODCON_IGV.Name = "CODCON_IGV";
            this.CODCON_IGV.ReadOnly = true;
            this.CODCON_IGV.Width = 130;
            // 
            // MONTOSOLES
            // 
            this.MONTOSOLES.DataPropertyName = "MONTOSOLES";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.MONTOSOLES.DefaultCellStyle = dataGridViewCellStyle8;
            this.MONTOSOLES.HeaderText = "MONTO SOLES";
            this.MONTOSOLES.Name = "MONTOSOLES";
            this.MONTOSOLES.ReadOnly = true;
            // 
            // RENTA
            // 
            this.RENTA.DataPropertyName = "RENTA";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.RENTA.DefaultCellStyle = dataGridViewCellStyle9;
            this.RENTA.HeaderText = "RENTA";
            this.RENTA.Name = "RENTA";
            this.RENTA.ReadOnly = true;
            // 
            // IGV
            // 
            this.IGV.DataPropertyName = "IGV";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.IGV.DefaultCellStyle = dataGridViewCellStyle10;
            this.IGV.HeaderText = "IGV";
            this.IGV.Name = "IGV";
            this.IGV.ReadOnly = true;
            // 
            // MORA
            // 
            this.MORA.DataPropertyName = "MORA";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N2";
            this.MORA.DefaultCellStyle = dataGridViewCellStyle11;
            this.MORA.HeaderText = "MORA";
            this.MORA.Name = "MORA";
            this.MORA.ReadOnly = true;
            // 
            // COD_COB
            // 
            this.COD_COB.DataPropertyName = "COD_COB";
            this.COD_COB.HeaderText = "COD_COB";
            this.COD_COB.Name = "COD_COB";
            this.COD_COB.ReadOnly = true;
            this.COD_COB.Width = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(508, 449);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "IGV";
            // 
            // txtIgv
            // 
            this.txtIgv.BackColor = System.Drawing.Color.White;
            this.txtIgv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIgv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.Color.Maroon;
            this.txtIgv.Location = new System.Drawing.Point(541, 446);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(90, 21);
            this.txtIgv.TabIndex = 149;
            this.txtIgv.Text = "0.00";
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(637, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 148;
            this.label5.Text = "Mora";
            // 
            // txtMora
            // 
            this.txtMora.BackColor = System.Drawing.Color.White;
            this.txtMora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMora.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMora.ForeColor = System.Drawing.Color.Maroon;
            this.txtMora.Location = new System.Drawing.Point(679, 446);
            this.txtMora.Name = "txtMora";
            this.txtMora.ReadOnly = true;
            this.txtMora.Size = new System.Drawing.Size(90, 21);
            this.txtMora.TabIndex = 149;
            this.txtMora.Text = "0.00";
            this.txtMora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMora.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(526, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "Monto Soles Total";
            // 
            // txtMontoSoles
            // 
            this.txtMontoSoles.BackColor = System.Drawing.Color.White;
            this.txtMontoSoles.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoSoles.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoSoles.ForeColor = System.Drawing.Color.Maroon;
            this.txtMontoSoles.Location = new System.Drawing.Point(640, 477);
            this.txtMontoSoles.Name = "txtMontoSoles";
            this.txtMontoSoles.ReadOnly = true;
            this.txtMontoSoles.Size = new System.Drawing.Size(129, 21);
            this.txtMontoSoles.TabIndex = 149;
            this.txtMontoSoles.Text = "0.00";
            this.txtMontoSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminar.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(177, 446);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(74, 56);
            this.btnEliminar.TabIndex = 170;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarLiq
            // 
            this.btnAgregarLiq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarLiq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarLiq.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLiq.ForeColor = System.Drawing.Color.Navy;
            this.btnAgregarLiq.Image = global::GUI_Tesoreria.Properties.Resources.agregar_32x32;
            this.btnAgregarLiq.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarLiq.Location = new System.Drawing.Point(13, 445);
            this.btnAgregarLiq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarLiq.Name = "btnAgregarLiq";
            this.btnAgregarLiq.Size = new System.Drawing.Size(74, 56);
            this.btnAgregarLiq.TabIndex = 168;
            this.btnAgregarLiq.Text = "&Agregar";
            this.btnAgregarLiq.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarLiq.UseVisualStyleBackColor = false;
            this.btnAgregarLiq.Click += new System.EventHandler(this.btnAgregarLiq_Click);
            // 
            // btnModificarLiq
            // 
            this.btnModificarLiq.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLiq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarLiq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLiq.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLiq.ForeColor = System.Drawing.Color.Navy;
            this.btnModificarLiq.Image = global::GUI_Tesoreria.Properties.Resources.modif_32x32;
            this.btnModificarLiq.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificarLiq.Location = new System.Drawing.Point(95, 445);
            this.btnModificarLiq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarLiq.Name = "btnModificarLiq";
            this.btnModificarLiq.Size = new System.Drawing.Size(74, 56);
            this.btnModificarLiq.TabIndex = 169;
            this.btnModificarLiq.Text = "&Modificar";
            this.btnModificarLiq.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificarLiq.UseVisualStyleBackColor = false;
            this.btnModificarLiq.Click += new System.EventHandler(this.btnModificarLiq_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.Navy;
            this.btnExportar.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(260, 446);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(74, 56);
            this.btnExportar.TabIndex = 164;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Visible = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // BtnSalirC
            // 
            this.BtnSalirC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalirC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalirC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalirC.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalirC.ForeColor = System.Drawing.Color.Navy;
            this.BtnSalirC.Image = global::GUI_Tesoreria.Properties.Resources.salirDoc;
            this.BtnSalirC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalirC.Location = new System.Drawing.Point(799, 443);
            this.BtnSalirC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalirC.Name = "BtnSalirC";
            this.BtnSalirC.Size = new System.Drawing.Size(74, 58);
            this.BtnSalirC.TabIndex = 148;
            this.BtnSalirC.Text = "&Salir";
            this.BtnSalirC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalirC.UseVisualStyleBackColor = false;
            this.BtnSalirC.Click += new System.EventHandler(this.BtnSalirC_Click);
            // 
            // frmImportarInformacionAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarLiq);
            this.Controls.Add(this.btnModificarLiq);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtNroPliego);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMontoSoles);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSalirC);
            this.Controls.Add(this.GBPago);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImportarInformacionAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Importar Datos API:::...";
            this.Load += new System.EventHandler(this.frmImportarInformacionAPI_Load);
            this.GBPago.ResumeLayout(false);
            this.GBPago.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        internal System.Windows.Forms.GroupBox GBPago;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidacion;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnSalirC;
        internal System.Windows.Forms.TextBox txtNroPliego;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtRenta;
        internal System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        internal System.Windows.Forms.Button btnImportaLiquidacionInmobiliaria;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnAgregarLiq;
        internal System.Windows.Forms.Button btnModificarLiq;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvListado;
        internal System.Windows.Forms.Button btnGeneraCodigoContable;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtIgv;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtMora;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtMontoSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_INMB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_CONTR;
        private System.Windows.Forms.DataGridViewTextBoxColumn INQUILINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM_RUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOMPROBANTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_DOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_DOCU;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCH_PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_MOVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIP_PAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCON_REN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCON_MOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODCON_IGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTOSOLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn RENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_COB;
    }
}