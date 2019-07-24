﻿namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmListaLiquidacionesCierre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoLiquidaciones = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroLiquidaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalIngresoCaja = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalDeposito = new System.Windows.Forms.TextBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReAperturar = new System.Windows.Forms.Button();
            this.btnCerrarLiquidacion = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.fechaLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIngresoCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diferenciaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox2.Size = new System.Drawing.Size(678, 343);
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
            this.fechaLiquidacion,
            this.totalIngresoCaja,
            this.diferenciaDeposito,
            this.TotalRecibo,
            this.programa,
            this.intProId,
            this.estado});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoLiquidaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoLiquidaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoLiquidaciones.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoLiquidaciones.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoLiquidaciones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoLiquidaciones.Name = "dgvListadoLiquidaciones";
            this.dgvListadoLiquidaciones.ReadOnly = true;
            this.dgvListadoLiquidaciones.RowHeadersVisible = false;
            this.dgvListadoLiquidaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoLiquidaciones.Size = new System.Drawing.Size(672, 323);
            this.dgvListadoLiquidaciones.TabIndex = 0;
            this.dgvListadoLiquidaciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListadoLiquidaciones_CellFormatting);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.lblNroLiquidaciones);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.txtTotalIngresoCaja);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.txtTotalDeposito);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox3.Location = new System.Drawing.Point(12, 460);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(584, 45);
            this.GroupBox3.TabIndex = 151;
            this.GroupBox3.TabStop = false;
            // 
            // lblNroLiquidaciones
            // 
            this.lblNroLiquidaciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroLiquidaciones.ForeColor = System.Drawing.Color.Navy;
            this.lblNroLiquidaciones.Location = new System.Drawing.Point(54, 12);
            this.lblNroLiquidaciones.Name = "lblNroLiquidaciones";
            this.lblNroLiquidaciones.Size = new System.Drawing.Size(37, 15);
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
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Nº Liq ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(97, 15);
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
            this.txtTotalIngresoCaja.Location = new System.Drawing.Point(214, 12);
            this.txtTotalIngresoCaja.MaxLength = 4000;
            this.txtTotalIngresoCaja.Name = "txtTotalIngresoCaja";
            this.txtTotalIngresoCaja.ReadOnly = true;
            this.txtTotalIngresoCaja.Size = new System.Drawing.Size(132, 21);
            this.txtTotalIngresoCaja.TabIndex = 89;
            this.txtTotalIngresoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(352, 15);
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
            this.txtTotalDeposito.Location = new System.Drawing.Point(459, 12);
            this.txtTotalDeposito.MaxLength = 4000;
            this.txtTotalDeposito.Name = "txtTotalDeposito";
            this.txtTotalDeposito.ReadOnly = true;
            this.txtTotalDeposito.Size = new System.Drawing.Size(122, 21);
            this.txtTotalDeposito.TabIndex = 86;
            this.txtTotalDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GBEstadoConvenio
            // 
            this.GBEstadoConvenio.BackColor = System.Drawing.Color.Transparent;
            this.GBEstadoConvenio.Controls.Add(this.Label3);
            this.GBEstadoConvenio.Controls.Add(this.Label4);
            this.GBEstadoConvenio.Controls.Add(this.RBTodos);
            this.GBEstadoConvenio.Controls.Add(this.RBAnulados);
            this.GBEstadoConvenio.Controls.Add(this.RBActivos);
            this.GBEstadoConvenio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEstadoConvenio.ForeColor = System.Drawing.Color.Maroon;
            this.GBEstadoConvenio.Location = new System.Drawing.Point(602, 44);
            this.GBEstadoConvenio.MaximumSize = new System.Drawing.Size(303, 61);
            this.GBEstadoConvenio.Name = "GBEstadoConvenio";
            this.GBEstadoConvenio.Size = new System.Drawing.Size(201, 61);
            this.GBEstadoConvenio.TabIndex = 148;
            this.GBEstadoConvenio.TabStop = false;
            this.GBEstadoConvenio.Text = "Estado de Liquidaciones";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(94, 35);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 17);
            this.Label3.TabIndex = 85;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Location = new System.Drawing.Point(94, 16);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(30, 17);
            this.Label4.TabIndex = 86;
            // 
            // RBTodos
            // 
            this.RBTodos.AutoSize = true;
            this.RBTodos.Checked = true;
            this.RBTodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTodos.ForeColor = System.Drawing.Color.Navy;
            this.RBTodos.Location = new System.Drawing.Point(130, 14);
            this.RBTodos.Name = "RBTodos";
            this.RBTodos.Size = new System.Drawing.Size(59, 17);
            this.RBTodos.TabIndex = 1;
            this.RBTodos.TabStop = true;
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
            this.RBAnulados.Size = new System.Drawing.Size(76, 17);
            this.RBAnulados.TabIndex = 5;
            this.RBAnulados.Text = "Cerrados";
            this.RBAnulados.UseVisualStyleBackColor = true;
            // 
            // RBActivos
            // 
            this.RBActivos.AutoSize = true;
            this.RBActivos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBActivos.ForeColor = System.Drawing.Color.Navy;
            this.RBActivos.Location = new System.Drawing.Point(6, 16);
            this.RBActivos.Name = "RBActivos";
            this.RBActivos.Size = new System.Drawing.Size(82, 17);
            this.RBActivos.TabIndex = 4;
            this.RBActivos.Text = "Pendiente";
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
            this.GroupBox1.Size = new System.Drawing.Size(387, 61);
            this.GroupBox1.TabIndex = 150;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Busqueda por fecha de liquidación:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(168, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 118;
            this.label8.Text = "Hasta";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(46, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Desde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(171, 33);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaHasta.TabIndex = 117;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(49, 33);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaDesde.TabIndex = 117;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnCancelar);
            this.GBOpciones.Controls.Add(this.btnReAperturar);
            this.GBOpciones.Controls.Add(this.btnCerrarLiquidacion);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(696, 111);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(107, 394);
            this.GBOpciones.TabIndex = 149;
            this.GBOpciones.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.cancelardoc;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(8, 331);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 57);
            this.btnCancelar.TabIndex = 148;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReAperturar
            // 
            this.btnReAperturar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReAperturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReAperturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReAperturar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReAperturar.ForeColor = System.Drawing.Color.Navy;
            this.btnReAperturar.Image = global::GUI_Tesoreria.Properties.Resources.reaperturar;
            this.btnReAperturar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReAperturar.Location = new System.Drawing.Point(8, 85);
            this.btnReAperturar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnReAperturar.Name = "btnReAperturar";
            this.btnReAperturar.Size = new System.Drawing.Size(90, 77);
            this.btnReAperturar.TabIndex = 148;
            this.btnReAperturar.Text = "&Re Aperturar Liquidación";
            this.btnReAperturar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReAperturar.UseVisualStyleBackColor = false;
            this.btnReAperturar.Click += new System.EventHandler(this.btnReAperturar_Click);
            // 
            // btnCerrarLiquidacion
            // 
            this.btnCerrarLiquidacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrarLiquidacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarLiquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarLiquidacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarLiquidacion.ForeColor = System.Drawing.Color.Navy;
            this.btnCerrarLiquidacion.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnCerrarLiquidacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrarLiquidacion.Location = new System.Drawing.Point(8, 17);
            this.btnCerrarLiquidacion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCerrarLiquidacion.Name = "btnCerrarLiquidacion";
            this.btnCerrarLiquidacion.Size = new System.Drawing.Size(90, 62);
            this.btnCerrarLiquidacion.TabIndex = 148;
            this.btnCerrarLiquidacion.Text = "&Cerrar Liquidación";
            this.btnCerrarLiquidacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrarLiquidacion.UseVisualStyleBackColor = false;
            this.btnCerrarLiquidacion.Click += new System.EventHandler(this.btnCerrarLiquidacion_Click);
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
            this.LblTitulo.Size = new System.Drawing.Size(791, 32);
            this.LblTitulo.TabIndex = 147;
            this.LblTitulo.Text = ":::   RESUMEN LIQUIDACIONES   :::\r\n";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = global::GUI_Tesoreria.Properties.Resources.buscar;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(518, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(78, 46);
            this.BtnBuscar.TabIndex = 152;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // fechaLiquidacion
            // 
            this.fechaLiquidacion.DataPropertyName = "fechaLiquidacion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaLiquidacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaLiquidacion.HeaderText = "FECHA LIQ";
            this.fechaLiquidacion.Name = "fechaLiquidacion";
            this.fechaLiquidacion.ReadOnly = true;
            // 
            // totalIngresoCaja
            // 
            this.totalIngresoCaja.DataPropertyName = "totalIngresoCaja";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.totalIngresoCaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalIngresoCaja.HeaderText = "TOTAL CAJA";
            this.totalIngresoCaja.Name = "totalIngresoCaja";
            this.totalIngresoCaja.ReadOnly = true;
            // 
            // diferenciaDeposito
            // 
            this.diferenciaDeposito.DataPropertyName = "TotalDeposito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.diferenciaDeposito.DefaultCellStyle = dataGridViewCellStyle3;
            this.diferenciaDeposito.HeaderText = "TOTAL DEPOSITO";
            this.diferenciaDeposito.Name = "diferenciaDeposito";
            this.diferenciaDeposito.ReadOnly = true;
            this.diferenciaDeposito.Width = 110;
            // 
            // TotalRecibo
            // 
            this.TotalRecibo.DataPropertyName = "TotalRecibo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.TotalRecibo.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalRecibo.HeaderText = "TOTAL RECIBOS";
            this.TotalRecibo.Name = "TotalRecibo";
            this.TotalRecibo.ReadOnly = true;
            this.TotalRecibo.Width = 110;
            // 
            // programa
            // 
            this.programa.DataPropertyName = "programa";
            this.programa.HeaderText = "PROGRAMA";
            this.programa.Name = "programa";
            this.programa.ReadOnly = true;
            this.programa.Width = 120;
            // 
            // intProId
            // 
            this.intProId.DataPropertyName = "intProId";
            this.intProId.HeaderText = "intProId";
            this.intProId.Name = "intProId";
            this.intProId.ReadOnly = true;
            this.intProId.Visible = false;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle5;
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // frmListaLiquidacionesCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GBEstadoConvenio);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.LblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListaLiquidacionesCierre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listado de números de liquidación:::...";
            this.Load += new System.EventHandler(this.frmListaLiquidacionesCierre_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLiquidaciones)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GBEstadoConvenio.ResumeLayout(false);
            this.GBEstadoConvenio.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvListadoLiquidaciones;
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
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnCerrarLiquidacion;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.Button btnReAperturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalIngresoCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn diferenciaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn intProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}