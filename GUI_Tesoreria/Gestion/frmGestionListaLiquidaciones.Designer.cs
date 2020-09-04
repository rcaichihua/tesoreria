namespace GUI_Tesoreria.Gestion
{
    partial class frmGestionListaLiquidaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoLiquidaciones = new System.Windows.Forms.DataGridView();
            this.idLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varProDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCajaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngresoCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferenciaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroLiquidaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalIngresoCaja = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtCodigoContribuyente = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.txtNroLiquidacion = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalDeposito = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.GBEstadoConvenio = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.RBTodos = new System.Windows.Forms.RadioButton();
            this.RBAnulados = new System.Windows.Forms.RadioButton();
            this.RBActivos = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btnListadoContable = new System.Windows.Forms.Button();
            this.btnReciboIngreso = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnIngresosCaja = new System.Windows.Forms.Button();
            this.btnLiquidacionInmobiliaria = new System.Windows.Forms.Button();
            this.btnIngresoCanevaro = new System.Windows.Forms.Button();
            this.btnLiquidaciónCementerio = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.chkcuentas = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLiquidaciones)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GBEstadoConvenio.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvListadoLiquidaciones);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 343);
            this.groupBox2.TabIndex = 153;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de liquidaciones";
            // 
            // dgvListadoLiquidaciones
            // 
            this.dgvListadoLiquidaciones.AllowUserToAddRows = false;
            this.dgvListadoLiquidaciones.AllowUserToDeleteRows = false;
            this.dgvListadoLiquidaciones.AllowUserToResizeColumns = false;
            this.dgvListadoLiquidaciones.AllowUserToResizeRows = false;
            this.dgvListadoLiquidaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLiquidaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLiquidacion,
            this.numeroLiquidacion,
            this.intProId,
            this.varProDescripcion,
            this.fechaLiquidacion,
            this.fechaCajaOrigen,
            this.totalIngresoCaja,
            this.diferenciaDeposito,
            this.TotalRecibo,
            this.observaciones,
            this.estado});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoLiquidaciones.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListadoLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoLiquidaciones.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoLiquidaciones.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoLiquidaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoLiquidaciones.Name = "dgvListadoLiquidaciones";
            this.dgvListadoLiquidaciones.ReadOnly = true;
            this.dgvListadoLiquidaciones.RowHeadersVisible = false;
            this.dgvListadoLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoLiquidaciones.Size = new System.Drawing.Size(892, 323);
            this.dgvListadoLiquidaciones.TabIndex = 0;
            // 
            // idLiquidacion
            // 
            this.idLiquidacion.DataPropertyName = "idLiquidacion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idLiquidacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.idLiquidacion.HeaderText = "ID LIQ";
            this.idLiquidacion.Name = "idLiquidacion";
            this.idLiquidacion.ReadOnly = true;
            this.idLiquidacion.Width = 40;
            // 
            // numeroLiquidacion
            // 
            this.numeroLiquidacion.DataPropertyName = "numeroLiquidacion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numeroLiquidacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.numeroLiquidacion.HeaderText = "Nº DE LIQ";
            this.numeroLiquidacion.Name = "numeroLiquidacion";
            this.numeroLiquidacion.ReadOnly = true;
            this.numeroLiquidacion.Width = 80;
            // 
            // intProId
            // 
            this.intProId.DataPropertyName = "intProId";
            this.intProId.HeaderText = "intProId";
            this.intProId.Name = "intProId";
            this.intProId.ReadOnly = true;
            this.intProId.Visible = false;
            this.intProId.Width = 80;
            // 
            // varProDescripcion
            // 
            this.varProDescripcion.DataPropertyName = "varProDescripcion";
            this.varProDescripcion.HeaderText = "PROGRAMA";
            this.varProDescripcion.Name = "varProDescripcion";
            this.varProDescripcion.ReadOnly = true;
            this.varProDescripcion.Width = 170;
            // 
            // fechaLiquidacion
            // 
            this.fechaLiquidacion.DataPropertyName = "fechaLiquidacion";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaLiquidacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.fechaLiquidacion.HeaderText = "FECHA LIQ";
            this.fechaLiquidacion.Name = "fechaLiquidacion";
            this.fechaLiquidacion.ReadOnly = true;
            this.fechaLiquidacion.Width = 90;
            // 
            // fechaCajaOrigen
            // 
            this.fechaCajaOrigen.DataPropertyName = "fechaCajaOrigen";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaCajaOrigen.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaCajaOrigen.HeaderText = "FECHA CAJA";
            this.fechaCajaOrigen.Name = "fechaCajaOrigen";
            this.fechaCajaOrigen.ReadOnly = true;
            this.fechaCajaOrigen.Width = 90;
            // 
            // totalIngresoCaja
            // 
            this.totalIngresoCaja.DataPropertyName = "totalIngresoCaja";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.totalIngresoCaja.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalIngresoCaja.HeaderText = "TOTAL CAJA";
            this.totalIngresoCaja.Name = "totalIngresoCaja";
            this.totalIngresoCaja.ReadOnly = true;
            // 
            // diferenciaDeposito
            // 
            this.diferenciaDeposito.DataPropertyName = "TotalDeposito";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.diferenciaDeposito.DefaultCellStyle = dataGridViewCellStyle6;
            this.diferenciaDeposito.HeaderText = "TOTAL DEPOSITO";
            this.diferenciaDeposito.Name = "diferenciaDeposito";
            this.diferenciaDeposito.ReadOnly = true;
            // 
            // TotalRecibo
            // 
            this.TotalRecibo.DataPropertyName = "TotalRecibo";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.TotalRecibo.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalRecibo.HeaderText = "TOTAL RECIBOS";
            this.TotalRecibo.Name = "TotalRecibo";
            this.TotalRecibo.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "observaciones";
            this.observaciones.HeaderText = "OBSERVACIONES";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle8;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            this.estado.Width = 80;
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.lblNroLiquidaciones);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.txtTotalIngresoCaja);
            this.GroupBox3.Controls.Add(this.LblNombre);
            this.GroupBox3.Controls.Add(this.TxtCodigoContribuyente);
            this.GroupBox3.Controls.Add(this.TxtNombre);
            this.GroupBox3.Controls.Add(this.txtNroLiquidacion);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.txtTotalDeposito);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox3.Location = new System.Drawing.Point(12, 460);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(898, 45);
            this.GroupBox3.TabIndex = 151;
            this.GroupBox3.TabStop = false;
            // 
            // lblNroLiquidaciones
            // 
            this.lblNroLiquidaciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLiquidaciones.ForeColor = System.Drawing.Color.Navy;
            this.lblNroLiquidaciones.Location = new System.Drawing.Point(162, 12);
            this.lblNroLiquidaciones.Name = "lblNroLiquidaciones";
            this.lblNroLiquidaciones.Size = new System.Drawing.Size(67, 15);
            this.lblNroLiquidaciones.TabIndex = 120;
            this.lblNroLiquidaciones.Text = "0";
            this.lblNroLiquidaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Cantidad de liquidaciones";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(408, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Total Ingreso Caja";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalIngresoCaja
            // 
            this.txtTotalIngresoCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalIngresoCaja.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalIngresoCaja.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalIngresoCaja.Location = new System.Drawing.Point(525, 9);
            this.txtTotalIngresoCaja.MaxLength = 4000;
            this.txtTotalIngresoCaja.Name = "txtTotalIngresoCaja";
            this.txtTotalIngresoCaja.ReadOnly = true;
            this.txtTotalIngresoCaja.Size = new System.Drawing.Size(132, 21);
            this.txtTotalIngresoCaja.TabIndex = 89;
            this.txtTotalIngresoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblNombre
            // 
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Navy;
            this.LblNombre.Location = new System.Drawing.Point(322, 18);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(34, 15);
            this.LblNombre.TabIndex = 87;
            this.LblNombre.Text = "Nro. Liquidación  -       Programa :";
            this.LblNombre.Visible = false;
            // 
            // TxtCodigoContribuyente
            // 
            this.TxtCodigoContribuyente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCodigoContribuyente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoContribuyente.ForeColor = System.Drawing.Color.Maroon;
            this.TxtCodigoContribuyente.Location = new System.Drawing.Point(256, 12);
            this.TxtCodigoContribuyente.Name = "TxtCodigoContribuyente";
            this.TxtCodigoContribuyente.ReadOnly = true;
            this.TxtCodigoContribuyente.Size = new System.Drawing.Size(31, 21);
            this.TxtCodigoContribuyente.TabIndex = 115;
            this.TxtCodigoContribuyente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoContribuyente.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNombre.Location = new System.Drawing.Point(293, 12);
            this.TxtNombre.MaxLength = 4000;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(23, 21);
            this.TxtNombre.TabIndex = 86;
            this.TxtNombre.Visible = false;
            // 
            // txtNroLiquidacion
            // 
            this.txtNroLiquidacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNroLiquidacion.ForeColor = System.Drawing.Color.Maroon;
            this.txtNroLiquidacion.Location = new System.Drawing.Point(235, 12);
            this.txtNroLiquidacion.Name = "txtNroLiquidacion";
            this.txtNroLiquidacion.Size = new System.Drawing.Size(15, 21);
            this.txtNroLiquidacion.TabIndex = 116;
            this.txtNroLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroLiquidacion.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(663, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 13);
            this.Label1.TabIndex = 88;
            this.Label1.Text = "Total Depositos :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalDeposito
            // 
            this.txtTotalDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalDeposito.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalDeposito.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalDeposito.Location = new System.Drawing.Point(770, 9);
            this.txtTotalDeposito.MaxLength = 4000;
            this.txtTotalDeposito.Name = "txtTotalDeposito";
            this.txtTotalDeposito.ReadOnly = true;
            this.txtTotalDeposito.Size = new System.Drawing.Size(122, 21);
            this.txtTotalDeposito.TabIndex = 86;
            this.txtTotalDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = global::GUI_Tesoreria.Properties.Resources.buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(753, 54);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(78, 46);
            this.BtnBuscar.TabIndex = 152;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // GBEstadoConvenio
            // 
            this.GBEstadoConvenio.BackColor = System.Drawing.Color.Transparent;
            this.GBEstadoConvenio.Controls.Add(this.Label3);
            this.GBEstadoConvenio.Controls.Add(this.Label4);
            this.GBEstadoConvenio.Controls.Add(this.RBTodos);
            this.GBEstadoConvenio.Controls.Add(this.RBAnulados);
            this.GBEstadoConvenio.Controls.Add(this.RBActivos);
            this.GBEstadoConvenio.Enabled = false;
            this.GBEstadoConvenio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEstadoConvenio.ForeColor = System.Drawing.Color.Maroon;
            this.GBEstadoConvenio.Location = new System.Drawing.Point(837, 44);
            this.GBEstadoConvenio.MaximumSize = new System.Drawing.Size(303, 61);
            this.GBEstadoConvenio.Name = "GBEstadoConvenio";
            this.GBEstadoConvenio.Size = new System.Drawing.Size(199, 61);
            this.GBEstadoConvenio.TabIndex = 148;
            this.GBEstadoConvenio.TabStop = false;
            this.GBEstadoConvenio.Text = "Estado de Liquidaciones";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LightCoral;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.Location = new System.Drawing.Point(79, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 17);
            this.Label3.TabIndex = 85;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Location = new System.Drawing.Point(79, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 17);
            this.Label4.TabIndex = 86;
            // 
            // RBTodos
            // 
            this.RBTodos.AutoSize = true;
            this.RBTodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTodos.ForeColor = System.Drawing.Color.Navy;
            this.RBTodos.Location = new System.Drawing.Point(120, 16);
            this.RBTodos.Name = "RBTodos";
            this.RBTodos.Size = new System.Drawing.Size(59, 17);
            this.RBTodos.TabIndex = 1;
            this.RBTodos.Text = "Todos";
            this.RBTodos.UseVisualStyleBackColor = true;
            // 
            // RBAnulados
            // 
            this.RBAnulados.AutoSize = true;
            this.RBAnulados.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBAnulados.ForeColor = System.Drawing.Color.Navy;
            this.RBAnulados.Location = new System.Drawing.Point(6, 37);
            this.RBAnulados.Name = "RBAnulados";
            this.RBAnulados.Size = new System.Drawing.Size(77, 17);
            this.RBAnulados.TabIndex = 5;
            this.RBAnulados.Text = "Anulados";
            this.RBAnulados.UseVisualStyleBackColor = true;
            // 
            // RBActivos
            // 
            this.RBActivos.AutoSize = true;
            this.RBActivos.Checked = true;
            this.RBActivos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBActivos.ForeColor = System.Drawing.Color.Navy;
            this.RBActivos.Location = new System.Drawing.Point(6, 16);
            this.RBActivos.Name = "RBActivos";
            this.RBActivos.Size = new System.Drawing.Size(67, 17);
            this.RBActivos.TabIndex = 4;
            this.RBActivos.TabStop = true;
            this.RBActivos.Text = "Activos";
            this.RBActivos.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.dtpFechaHasta);
            this.GroupBox1.Controls.Add(this.dtpFechaDesde);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox1.Location = new System.Drawing.Point(12, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(735, 61);
            this.GroupBox1.TabIndex = 150;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Busqueda por :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(201, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 118;
            this.label8.Text = "Hasta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Desde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(274, 19);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaHasta.TabIndex = 117;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(79, 19);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaDesde.TabIndex = 117;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnListadoContable);
            this.GBOpciones.Controls.Add(this.btnReciboIngreso);
            this.GBOpciones.Controls.Add(this.btnRegresar);
            this.GBOpciones.Controls.Add(this.btnIngresosCaja);
            this.GBOpciones.Controls.Add(this.btnLiquidacionInmobiliaria);
            this.GBOpciones.Controls.Add(this.btnIngresoCanevaro);
            this.GBOpciones.Controls.Add(this.btnLiquidaciónCementerio);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(916, 111);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(120, 394);
            this.GBOpciones.TabIndex = 149;
            this.GBOpciones.TabStop = false;
            // 
            // btnListadoContable
            // 
            this.btnListadoContable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListadoContable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoContable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoContable.ForeColor = System.Drawing.Color.Navy;
            this.btnListadoContable.Image = global::GUI_Tesoreria.Properties.Resources.reporte;
            this.btnListadoContable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListadoContable.Location = new System.Drawing.Point(8, 99);
            this.btnListadoContable.Name = "btnListadoContable";
            this.btnListadoContable.Size = new System.Drawing.Size(106, 73);
            this.btnListadoContable.TabIndex = 150;
            this.btnListadoContable.Text = "&Listado Contable Tesoreria";
            this.btnListadoContable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListadoContable.UseVisualStyleBackColor = false;
            this.btnListadoContable.Click += new System.EventHandler(this.btnListadoContable_Click);
            // 
            // btnReciboIngreso
            // 
            this.btnReciboIngreso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReciboIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReciboIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciboIngreso.ForeColor = System.Drawing.Color.Navy;
            this.btnReciboIngreso.Image = global::GUI_Tesoreria.Properties.Resources.nuevodoc;
            this.btnReciboIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReciboIngreso.Location = new System.Drawing.Point(8, 17);
            this.btnReciboIngreso.Name = "btnReciboIngreso";
            this.btnReciboIngreso.Size = new System.Drawing.Size(106, 76);
            this.btnReciboIngreso.TabIndex = 149;
            this.btnReciboIngreso.Text = "&Recibo de Ingreso de Tesoreria";
            this.btnReciboIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReciboIngreso.UseVisualStyleBackColor = false;
            this.btnReciboIngreso.Click += new System.EventHandler(this.btnReciboIngreso_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.Navy;
            this.btnRegresar.Image = global::GUI_Tesoreria.Properties.Resources.back_32_32;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegresar.Location = new System.Drawing.Point(8, 320);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 68);
            this.btnRegresar.TabIndex = 148;
            this.btnRegresar.Text = "&Regresar al Menú";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnIngresosCaja
            // 
            this.btnIngresosCaja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresosCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresosCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresosCaja.ForeColor = System.Drawing.Color.Navy;
            this.btnIngresosCaja.Image = global::GUI_Tesoreria.Properties.Resources.Ingreso_caja_32_32;
            this.btnIngresosCaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresosCaja.Location = new System.Drawing.Point(8, 178);
            this.btnIngresosCaja.Name = "btnIngresosCaja";
            this.btnIngresosCaja.Size = new System.Drawing.Size(106, 52);
            this.btnIngresosCaja.TabIndex = 151;
            this.btnIngresosCaja.Text = "&Recibo Caja";
            this.btnIngresosCaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresosCaja.UseVisualStyleBackColor = false;
            this.btnIngresosCaja.Click += new System.EventHandler(this.btnIngresosCaja_Click);
            // 
            // btnLiquidacionInmobiliaria
            // 
            this.btnLiquidacionInmobiliaria.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLiquidacionInmobiliaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidacionInmobiliaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidacionInmobiliaria.ForeColor = System.Drawing.Color.Navy;
            this.btnLiquidacionInmobiliaria.Image = global::GUI_Tesoreria.Properties.Resources.inmo_32_32;
            this.btnLiquidacionInmobiliaria.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLiquidacionInmobiliaria.Location = new System.Drawing.Point(8, 236);
            this.btnLiquidacionInmobiliaria.Name = "btnLiquidacionInmobiliaria";
            this.btnLiquidacionInmobiliaria.Size = new System.Drawing.Size(106, 78);
            this.btnLiquidacionInmobiliaria.TabIndex = 151;
            this.btnLiquidacionInmobiliaria.Text = "&Liquidación por dia Inmobiliaria";
            this.btnLiquidacionInmobiliaria.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLiquidacionInmobiliaria.UseVisualStyleBackColor = false;
            this.btnLiquidacionInmobiliaria.Click += new System.EventHandler(this.btnLiquidacionInmobiliaria_Click);
            // 
            // btnIngresoCanevaro
            // 
            this.btnIngresoCanevaro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresoCanevaro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresoCanevaro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresoCanevaro.ForeColor = System.Drawing.Color.Navy;
            this.btnIngresoCanevaro.Image = global::GUI_Tesoreria.Properties.Resources.cane_32_32;
            this.btnIngresoCanevaro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngresoCanevaro.Location = new System.Drawing.Point(8, 236);
            this.btnIngresoCanevaro.Name = "btnIngresoCanevaro";
            this.btnIngresoCanevaro.Size = new System.Drawing.Size(106, 78);
            this.btnIngresoCanevaro.TabIndex = 151;
            this.btnIngresoCanevaro.Text = "&Reporte Liquidación Canevaro";
            this.btnIngresoCanevaro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresoCanevaro.UseVisualStyleBackColor = false;
            this.btnIngresoCanevaro.Click += new System.EventHandler(this.btnIngresoCanevaro_Click);
            // 
            // btnLiquidaciónCementerio
            // 
            this.btnLiquidaciónCementerio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLiquidaciónCementerio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiquidaciónCementerio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiquidaciónCementerio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiquidaciónCementerio.ForeColor = System.Drawing.Color.Navy;
            this.btnLiquidaciónCementerio.Image = global::GUI_Tesoreria.Properties.Resources.cemetery_32_32;
            this.btnLiquidaciónCementerio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLiquidaciónCementerio.Location = new System.Drawing.Point(8, 236);
            this.btnLiquidaciónCementerio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLiquidaciónCementerio.Name = "btnLiquidaciónCementerio";
            this.btnLiquidaciónCementerio.Size = new System.Drawing.Size(106, 78);
            this.btnLiquidaciónCementerio.TabIndex = 147;
            this.btnLiquidaciónCementerio.Text = "&Reporte Liquidación Cementerio";
            this.btnLiquidaciónCementerio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLiquidaciónCementerio.UseVisualStyleBackColor = false;
            this.btnLiquidaciónCementerio.Click += new System.EventHandler(this.btnLiquidaciónCementerio_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1024, 32);
            this.LblTitulo.TabIndex = 147;
            this.LblTitulo.Text = ":::   LIQUIDACIONES  EMITIDAS   :::\r\n";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // chkcuentas
            // 
            this.chkcuentas.AutoSize = true;
            this.chkcuentas.Checked = true;
            this.chkcuentas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkcuentas.Location = new System.Drawing.Point(12, 511);
            this.chkcuentas.Name = "chkcuentas";
            this.chkcuentas.Size = new System.Drawing.Size(285, 17);
            this.chkcuentas.TabIndex = 171;
            this.chkcuentas.Text = "Códigos Contable - PLAN CONTABLE EMPRESARIAL";
            this.chkcuentas.UseVisualStyleBackColor = true;
            this.chkcuentas.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit_32_32;
            this.btnSalir.Location = new System.Drawing.Point(998, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 32);
            this.btnSalir.TabIndex = 172;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGestionListaLiquidaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 522);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chkcuentas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GBEstadoConvenio);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.LblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmGestionListaLiquidaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Liquidaciones Alta Dirección:::...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGestionListaLiquidaciones_FormClosing);
            this.Load += new System.EventHandler(this.frmGestionListaLiquidaciones_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLiquidaciones)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GBEstadoConvenio.ResumeLayout(false);
            this.GBEstadoConvenio.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvListadoLiquidaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn intProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn varProDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCajaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIngresoCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferenciaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblNroLiquidaciones;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotalIngresoCaja;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotalDeposito;
        internal System.Windows.Forms.Button BtnBuscar;
        internal System.Windows.Forms.GroupBox GBEstadoConvenio;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.RadioButton RBTodos;
        internal System.Windows.Forms.RadioButton RBAnulados;
        internal System.Windows.Forms.RadioButton RBActivos;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        internal System.Windows.Forms.TextBox txtNroLiquidacion;
        internal System.Windows.Forms.TextBox TxtCodigoContribuyente;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button btnRegresar;
        internal System.Windows.Forms.Button btnLiquidaciónCementerio;
        internal System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button btnReciboIngreso;
        private System.Windows.Forms.CheckBox chkcuentas;
        private System.Windows.Forms.Button btnListadoContable;
        private System.Windows.Forms.Button btnIngresoCanevaro;
        private System.Windows.Forms.Button btnLiquidacionInmobiliaria;
        private System.Windows.Forms.Button btnIngresosCaja;
        internal System.Windows.Forms.Button btnSalir;
    }
}