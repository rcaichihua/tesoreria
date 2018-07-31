namespace GUI_Tesoreria.canevaro
{
    partial class frmMigrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResidente = new System.Windows.Forms.DataGridView();
            this.IDResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngresoResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagoResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionResidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MONTO = new System.Windows.Forms.Label();
            this.BtnGrabar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPension = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.txtVer = new System.Windows.Forms.Button();
            this.dgvIngresos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctacteResidenteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMovi = new System.Windows.Forms.TextBox();
            this.txtAfect = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnAnula = new System.Windows.Forms.Button();
            this.txtNroRecibo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 111;
            this.label2.Text = "Filtro por Apellido Paterno";
            // 
            // txtFiltro
            // 
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(205, 12);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 21);
            this.txtFiltro.TabIndex = 0;
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
            this.NombresResidente,
            this.ApellidosResidente,
            this.FechaIngresoResidente,
            this.TipoPagoResidente,
            this.DireccionResidente});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResidente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResidente.EnableHeadersVisualStyles = false;
            this.dgvResidente.Location = new System.Drawing.Point(12, 47);
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
            this.dgvResidente.Size = new System.Drawing.Size(788, 214);
            this.dgvResidente.TabIndex = 113;
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
            // NombresResidente
            // 
            this.NombresResidente.DataPropertyName = "NombreResidente";
            this.NombresResidente.HeaderText = "Nombres";
            this.NombresResidente.Name = "NombresResidente";
            this.NombresResidente.ReadOnly = true;
            this.NombresResidente.Width = 120;
            // 
            // ApellidosResidente
            // 
            this.ApellidosResidente.DataPropertyName = "apellidosResidente";
            this.ApellidosResidente.HeaderText = "Apellidos";
            this.ApellidosResidente.Name = "ApellidosResidente";
            this.ApellidosResidente.ReadOnly = true;
            this.ApellidosResidente.Width = 200;
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
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(11, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 33);
            this.label9.TabIndex = 116;
            this.label9.Text = "Cancela=C Acuenta=E";
            // 
            // txtMonto
            // 
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(477, 351);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(108, 21);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Text = "0.00";
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(119, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 116;
            this.label1.Text = "Mora=MO Dscto=DS Pension=PE";
            // 
            // MONTO
            // 
            this.MONTO.AutoSize = true;
            this.MONTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MONTO.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MONTO.Location = new System.Drawing.Point(474, 331);
            this.MONTO.Name = "MONTO";
            this.MONTO.Size = new System.Drawing.Size(57, 15);
            this.MONTO.TabIndex = 116;
            this.MONTO.Text = "MONTO";
            // 
            // BtnGrabar
            // 
            this.BtnGrabar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGrabar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGrabar.ForeColor = System.Drawing.Color.Navy;
            this.BtnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGrabar.Location = new System.Drawing.Point(9, 374);
            this.BtnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnGrabar.Name = "BtnGrabar";
            this.BtnGrabar.Size = new System.Drawing.Size(72, 39);
            this.BtnGrabar.TabIndex = 8;
            this.BtnGrabar.Text = "&Grabar";
            this.BtnGrabar.UseVisualStyleBackColor = false;
            this.BtnGrabar.Click += new System.EventHandler(this.BtnGrabar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Location = new System.Drawing.Point(119, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 15);
            this.label20.TabIndex = 119;
            this.label20.Text = "Nombres";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label24.Location = new System.Drawing.Point(9, 270);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 15);
            this.label24.TabIndex = 120;
            this.label24.Text = "ID";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(190, 267);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(184, 21);
            this.txtNombres.TabIndex = 118;
            // 
            // txtId
            // 
            this.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(36, 267);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(70, 21);
            this.txtId.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(380, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "Monto";
            // 
            // txtPension
            // 
            this.txtPension.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPension.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPension.Location = new System.Drawing.Point(451, 266);
            this.txtPension.Name = "txtPension";
            this.txtPension.ReadOnly = true;
            this.txtPension.Size = new System.Drawing.Size(140, 21);
            this.txtPension.TabIndex = 122;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(360, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 125;
            this.label4.Text = "Mes (Enero=1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(236, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 126;
            this.label5.Text = "Año";
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006"});
            this.cboAnio.Location = new System.Drawing.Point(236, 351);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(121, 21);
            this.cboAnio.TabIndex = 3;
            // 
            // txtVer
            // 
            this.txtVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.txtVer.ForeColor = System.Drawing.Color.Navy;
            this.txtVer.Location = new System.Drawing.Point(597, 266);
            this.txtVer.Name = "txtVer";
            this.txtVer.Size = new System.Drawing.Size(47, 38);
            this.txtVer.TabIndex = 112;
            this.txtVer.Text = "Ver";
            this.txtVer.UseVisualStyleBackColor = true;
            this.txtVer.Click += new System.EventHandler(this.txtVer_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.anio,
            this.mes,
            this.nombres,
            this.Docu,
            this.FechaPago,
            this.FechaRegistro,
            this.importe,
            this.estado,
            this.tipo,
            this.ctacteResidenteId});
            this.dgvIngresos.Location = new System.Drawing.Point(9, 419);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            this.dgvIngresos.RowHeadersWidth = 26;
            this.dgvIngresos.Size = new System.Drawing.Size(791, 150);
            this.dgvIngresos.TabIndex = 127;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // anio
            // 
            this.anio.DataPropertyName = "anio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.anio.DefaultCellStyle = dataGridViewCellStyle4;
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 50;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 65;
            // 
            // nombres
            // 
            this.nombres.DataPropertyName = "nombres";
            this.nombres.HeaderText = "Nombres";
            this.nombres.Name = "nombres";
            this.nombres.ReadOnly = true;
            this.nombres.Width = 180;
            // 
            // Docu
            // 
            this.Docu.DataPropertyName = "Docu";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Docu.DefaultCellStyle = dataGridViewCellStyle5;
            this.Docu.HeaderText = "Nro Recibo";
            this.Docu.Name = "Docu";
            this.Docu.ReadOnly = true;
            this.Docu.Width = 50;
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.FechaPago.DefaultCellStyle = dataGridViewCellStyle6;
            this.FechaPago.HeaderText = "Fecha Pago";
            this.FechaPago.Name = "FechaPago";
            this.FechaPago.ReadOnly = true;
            this.FechaPago.Width = 90;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.DataPropertyName = "FechaRegistro";
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 110;
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.importe.DefaultCellStyle = dataGridViewCellStyle7;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            this.importe.Width = 55;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle8;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 50;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.tipo.DefaultCellStyle = dataGridViewCellStyle9;
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 50;
            // 
            // ctacteResidenteId
            // 
            this.ctacteResidenteId.DataPropertyName = "ctacteResidenteId";
            this.ctacteResidenteId.HeaderText = "ctacteResidenteId";
            this.ctacteResidenteId.Name = "ctacteResidenteId";
            this.ctacteResidenteId.ReadOnly = true;
            this.ctacteResidenteId.Visible = false;
            // 
            // txtMovi
            // 
            this.txtMovi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovi.Location = new System.Drawing.Point(8, 351);
            this.txtMovi.Name = "txtMovi";
            this.txtMovi.Size = new System.Drawing.Size(108, 21);
            this.txtMovi.TabIndex = 1;
            this.txtMovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAfect
            // 
            this.txtAfect.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfect.Location = new System.Drawing.Point(122, 351);
            this.txtAfect.Name = "txtAfect";
            this.txtAfect.Size = new System.Drawing.Size(108, 21);
            this.txtAfect.TabIndex = 2;
            this.txtAfect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMes
            // 
            this.txtMes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(363, 351);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(108, 21);
            this.txtMes.TabIndex = 4;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // btnAnula
            // 
            this.btnAnula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnula.ForeColor = System.Drawing.Color.Navy;
            this.btnAnula.Location = new System.Drawing.Point(654, 377);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(71, 38);
            this.btnAnula.TabIndex = 112;
            this.btnAnula.Text = "&Anula";
            this.btnAnula.UseVisualStyleBackColor = true;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // txtNroRecibo
            // 
            this.txtNroRecibo.Location = new System.Drawing.Point(592, 351);
            this.txtNroRecibo.Name = "txtNroRecibo";
            this.txtNroRecibo.Size = new System.Drawing.Size(100, 20);
            this.txtNroRecibo.TabIndex = 6;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(699, 351);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 7;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(589, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 126;
            this.label6.Text = "Nro Recibo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(698, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 126;
            this.label7.Text = "Fecha Ingreso";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.Navy;
            this.btnCerrar.Location = new System.Drawing.Point(731, 377);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(71, 38);
            this.btnCerrar.TabIndex = 112;
            this.btnCerrar.Text = "&Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.Navy;
            this.btnFiltrar.Location = new System.Drawing.Point(399, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(71, 38);
            this.btnFiltrar.TabIndex = 112;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // frmMigrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 585);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNroRecibo);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.txtPension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.BtnGrabar);
            this.Controls.Add(this.MONTO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAfect);
            this.Controls.Add(this.txtMovi);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dgvResidente);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.txtVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMigrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMigrar";
            this.Load += new System.EventHandler(this.frmMigrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngresoResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagoResidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionResidente;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtMonto;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label MONTO;
        internal System.Windows.Forms.Button BtnGrabar;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.TextBox txtId;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtPension;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Button txtVer;
        private System.Windows.Forms.DataGridView dgvIngresos;
        internal System.Windows.Forms.TextBox txtMovi;
        internal System.Windows.Forms.TextBox txtAfect;
        internal System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.TextBox txtNroRecibo;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docu;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctacteResidenteId;
    }
}