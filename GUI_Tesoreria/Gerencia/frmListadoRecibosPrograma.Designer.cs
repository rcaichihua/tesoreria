namespace GUI_Tesoreria.Gerencia
{
    partial class frmListadoRecibosPrograma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoRecibosPrograma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroRecibos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtIgv = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
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
            this.txtNrorecibo = new System.Windows.Forms.TextBox();
            this.TxtCodigoContribuyente = new System.Windows.Forms.TextBox();
            this.ChTodos = new System.Windows.Forms.CheckBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.cboPrograma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.Id_ReciboCabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieRecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            this.GBEstadoConvenio.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.lblNroRecibos);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label6);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.txtSubTotal);
            this.GroupBox3.Controls.Add(this.txtIgv);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.txtTotal);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox3.Location = new System.Drawing.Point(12, 461);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(924, 45);
            this.GroupBox3.TabIndex = 120;
            this.GroupBox3.TabStop = false;
            // 
            // lblNroRecibos
            // 
            this.lblNroRecibos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRecibos.ForeColor = System.Drawing.Color.Navy;
            this.lblNroRecibos.Location = new System.Drawing.Point(155, 11);
            this.lblNroRecibos.Name = "lblNroRecibos";
            this.lblNroRecibos.Size = new System.Drawing.Size(67, 15);
            this.lblNroRecibos.TabIndex = 120;
            this.lblNroRecibos.Text = "0";
            this.lblNroRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(15, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 119;
            this.label7.Text = "Cantidad de recibos: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(458, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 90;
            this.label6.Text = "Sub Total :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(630, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 90;
            this.label2.Text = "Igv :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSubTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtSubTotal.Location = new System.Drawing.Point(531, 9);
            this.txtSubTotal.MaxLength = 4000;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(93, 21);
            this.txtSubTotal.TabIndex = 89;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIgv
            // 
            this.txtIgv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIgv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtIgv.ForeColor = System.Drawing.Color.Maroon;
            this.txtIgv.Location = new System.Drawing.Point(670, 9);
            this.txtIgv.MaxLength = 4000;
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(83, 21);
            this.txtIgv.TabIndex = 89;
            this.txtIgv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(773, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 15);
            this.Label1.TabIndex = 88;
            this.Label1.Text = "Total :";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(821, 9);
            this.txtTotal.MaxLength = 4000;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(97, 21);
            this.txtTotal.TabIndex = 86;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.dgvRecibos);
            this.GroupBox2.Location = new System.Drawing.Point(12, 107);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(924, 353);
            this.GroupBox2.TabIndex = 119;
            this.GroupBox2.TabStop = false;
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.AllowUserToAddRows = false;
            this.dgvRecibos.AllowUserToDeleteRows = false;
            this.dgvRecibos.AllowUserToResizeColumns = false;
            this.dgvRecibos.AllowUserToResizeRows = false;
            this.dgvRecibos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_ReciboCabecera,
            this.Id_Movimiento,
            this.Estado,
            this.concepto,
            this.nombre_documento,
            this.serieRecibo,
            this.Numero_Recibo,
            this.Fecha,
            this.cod_cliente,
            this.NombreCompleto_Cliente,
            this.subTotal,
            this.Igv,
            this.Total});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecibos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecibos.Location = new System.Drawing.Point(3, 16);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.ReadOnly = true;
            this.dgvRecibos.RowHeadersVisible = false;
            this.dgvRecibos.RowHeadersWidth = 10;
            this.dgvRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecibos.Size = new System.Drawing.Size(918, 334);
            this.dgvRecibos.TabIndex = 83;
            this.dgvRecibos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRecibos_CellFormatting);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.White;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBuscar.Location = new System.Drawing.Point(753, 62);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(53, 39);
            this.BtnBuscar.TabIndex = 121;
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
            this.GBEstadoConvenio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBEstadoConvenio.ForeColor = System.Drawing.Color.Maroon;
            this.GBEstadoConvenio.Location = new System.Drawing.Point(837, 45);
            this.GBEstadoConvenio.MaximumSize = new System.Drawing.Size(303, 61);
            this.GBEstadoConvenio.Name = "GBEstadoConvenio";
            this.GBEstadoConvenio.Size = new System.Drawing.Size(186, 61);
            this.GBEstadoConvenio.TabIndex = 116;
            this.GBEstadoConvenio.TabStop = false;
            this.GBEstadoConvenio.Text = "Estado de Recibos";
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
            this.RBTodos.Checked = true;
            this.RBTodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTodos.ForeColor = System.Drawing.Color.Navy;
            this.RBTodos.Location = new System.Drawing.Point(120, 16);
            this.RBTodos.Name = "RBTodos";
            this.RBTodos.Size = new System.Drawing.Size(59, 17);
            this.RBTodos.TabIndex = 1;
            this.RBTodos.TabStop = true;
            this.RBTodos.Text = "Todos";
            this.RBTodos.UseVisualStyleBackColor = true;
            this.RBTodos.CheckedChanged += new System.EventHandler(this.RBTodos_CheckedChanged);
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
            this.RBAnulados.CheckedChanged += new System.EventHandler(this.RBAnulados_CheckedChanged);
            // 
            // RBActivos
            // 
            this.RBActivos.AutoSize = true;
            this.RBActivos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBActivos.ForeColor = System.Drawing.Color.Navy;
            this.RBActivos.Location = new System.Drawing.Point(6, 16);
            this.RBActivos.Name = "RBActivos";
            this.RBActivos.Size = new System.Drawing.Size(67, 17);
            this.RBActivos.TabIndex = 4;
            this.RBActivos.Text = "Activos";
            this.RBActivos.UseVisualStyleBackColor = true;
            this.RBActivos.CheckedChanged += new System.EventHandler(this.RBActivos_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.dtpFechaHasta);
            this.GroupBox1.Controls.Add(this.dtpFechaDesde);
            this.GroupBox1.Controls.Add(this.txtNrorecibo);
            this.GroupBox1.Controls.Add(this.TxtCodigoContribuyente);
            this.GroupBox1.Controls.Add(this.ChTodos);
            this.GroupBox1.Controls.Add(this.LblNombre);
            this.GroupBox1.Controls.Add(this.TxtNombre);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox1.Location = new System.Drawing.Point(12, 45);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(735, 61);
            this.GroupBox1.TabIndex = 118;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Busqueda por :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(584, 15);
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
            this.label5.Location = new System.Drawing.Point(462, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 118;
            this.label5.Text = "Desde";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(587, 33);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaHasta.TabIndex = 117;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(465, 33);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(116, 20);
            this.dtpFechaDesde.TabIndex = 117;
            // 
            // txtNrorecibo
            // 
            this.txtNrorecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNrorecibo.ForeColor = System.Drawing.Color.Maroon;
            this.txtNrorecibo.Location = new System.Drawing.Point(9, 33);
            this.txtNrorecibo.Name = "txtNrorecibo";
            this.txtNrorecibo.Size = new System.Drawing.Size(96, 21);
            this.txtNrorecibo.TabIndex = 116;
            this.txtNrorecibo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCodigoContribuyente
            // 
            this.TxtCodigoContribuyente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtCodigoContribuyente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoContribuyente.ForeColor = System.Drawing.Color.Maroon;
            this.TxtCodigoContribuyente.Location = new System.Drawing.Point(9, 33);
            this.TxtCodigoContribuyente.Name = "TxtCodigoContribuyente";
            this.TxtCodigoContribuyente.ReadOnly = true;
            this.TxtCodigoContribuyente.Size = new System.Drawing.Size(31, 21);
            this.TxtCodigoContribuyente.TabIndex = 115;
            this.TxtCodigoContribuyente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodigoContribuyente.Visible = false;
            // 
            // ChTodos
            // 
            this.ChTodos.AutoSize = true;
            this.ChTodos.BackColor = System.Drawing.Color.Transparent;
            this.ChTodos.Checked = true;
            this.ChTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChTodos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChTodos.ForeColor = System.Drawing.Color.Navy;
            this.ChTodos.Location = new System.Drawing.Point(330, 10);
            this.ChTodos.Name = "ChTodos";
            this.ChTodos.Size = new System.Drawing.Size(103, 17);
            this.ChTodos.TabIndex = 113;
            this.ChTodos.Text = "Mostar Todos";
            this.ChTodos.UseVisualStyleBackColor = false;
            this.ChTodos.Visible = false;
            this.ChTodos.CheckedChanged += new System.EventHandler(this.ChTodos_CheckedChanged);
            // 
            // LblNombre
            // 
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Navy;
            this.LblNombre.Location = new System.Drawing.Point(6, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(441, 15);
            this.LblNombre.TabIndex = 87;
            this.LblNombre.Text = "Nro. de Recibo - Nombres/Razón Social, Fecha  :";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtNombre.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNombre.Location = new System.Drawing.Point(111, 33);
            this.TxtNombre.MaxLength = 4000;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(348, 21);
            this.TxtNombre.TabIndex = 86;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnExportar);
            this.GBOpciones.Controls.Add(this.BtnSalir);
            this.GBOpciones.Controls.Add(this.BtnImprimir);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(942, 107);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(81, 399);
            this.GBOpciones.TabIndex = 117;
            this.GBOpciones.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(6, 353);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(59, 39);
            this.BtnSalir.TabIndex = 58;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.Location = new System.Drawing.Point(6, 11);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(59, 39);
            this.BtnImprimir.TabIndex = 93;
            this.BtnImprimir.Text = "&Previo";
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 10);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1011, 32);
            this.LblTitulo.TabIndex = 115;
            this.LblTitulo.Text = ":::   RECIBOS  EMITIDOS  :::\r\n";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPrograma
            // 
            this.cboPrograma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrograma.FormattingEnabled = true;
            this.cboPrograma.Location = new System.Drawing.Point(90, 512);
            this.cboPrograma.Name = "cboPrograma";
            this.cboPrograma.Size = new System.Drawing.Size(234, 23);
            this.cboPrograma.TabIndex = 123;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(14, 515);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 122;
            this.label9.Text = "Programa";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExportar.Image = global::GUI_Tesoreria.Properties.Resources.generar;
            this.btnExportar.Location = new System.Drawing.Point(7, 56);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(59, 39);
            this.btnExportar.TabIndex = 58;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // Id_ReciboCabecera
            // 
            this.Id_ReciboCabecera.DataPropertyName = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.HeaderText = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.Name = "Id_ReciboCabecera";
            this.Id_ReciboCabecera.ReadOnly = true;
            this.Id_ReciboCabecera.Visible = false;
            this.Id_ReciboCabecera.Width = 103;
            // 
            // Id_Movimiento
            // 
            this.Id_Movimiento.DataPropertyName = "Id_Movimiento";
            this.Id_Movimiento.HeaderText = "Id_Movimiento";
            this.Id_Movimiento.Name = "Id_Movimiento";
            this.Id_Movimiento.ReadOnly = true;
            this.Id_Movimiento.Visible = false;
            this.Id_Movimiento.Width = 101;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 85;
            // 
            // concepto
            // 
            this.concepto.DataPropertyName = "concepto";
            this.concepto.HeaderText = "concepto";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            this.concepto.Visible = false;
            // 
            // nombre_documento
            // 
            this.nombre_documento.DataPropertyName = "nombre_documento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.nombre_documento.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombre_documento.HeaderText = "Documento";
            this.nombre_documento.Name = "nombre_documento";
            this.nombre_documento.ReadOnly = true;
            this.nombre_documento.Width = 90;
            // 
            // serieRecibo
            // 
            this.serieRecibo.DataPropertyName = "serieRecibo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.serieRecibo.DefaultCellStyle = dataGridViewCellStyle3;
            this.serieRecibo.HeaderText = "Serie";
            this.serieRecibo.Name = "serieRecibo";
            this.serieRecibo.ReadOnly = true;
            this.serieRecibo.Width = 70;
            // 
            // Numero_Recibo
            // 
            this.Numero_Recibo.DataPropertyName = "Numero_Recibo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Numero_Recibo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Numero_Recibo.HeaderText = "Nº Recibo";
            this.Numero_Recibo.Name = "Numero_Recibo";
            this.Numero_Recibo.ReadOnly = true;
            this.Numero_Recibo.Width = 85;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 85;
            // 
            // cod_cliente
            // 
            this.cod_cliente.DataPropertyName = "Dni_Ruc_ReciboCabecera";
            this.cod_cliente.HeaderText = "Dni/RUC";
            this.cod_cliente.Name = "cod_cliente";
            this.cod_cliente.ReadOnly = true;
            this.cod_cliente.Width = 112;
            // 
            // NombreCompleto_Cliente
            // 
            this.NombreCompleto_Cliente.DataPropertyName = "NombreCompleto_Cliente";
            this.NombreCompleto_Cliente.HeaderText = "Cliente";
            this.NombreCompleto_Cliente.Name = "NombreCompleto_Cliente";
            this.NombreCompleto_Cliente.ReadOnly = true;
            this.NombreCompleto_Cliente.Width = 220;
            // 
            // subTotal
            // 
            this.subTotal.DataPropertyName = "subTotal";
            this.subTotal.HeaderText = "Sub Total";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 85;
            // 
            // Igv
            // 
            this.Igv.DataPropertyName = "igv";
            this.Igv.HeaderText = "Igv";
            this.Igv.Name = "Igv";
            this.Igv.ReadOnly = true;
            this.Igv.Width = 80;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 85;
            // 
            // frmListadoRecibosPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 542);
            this.Controls.Add(this.cboPrograma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GBEstadoConvenio);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.LblTitulo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListadoRecibosPrograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoRecibosPrograma";
            this.Load += new System.EventHandler(this.frmListadoRecibosPrograma_Load);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            this.GBEstadoConvenio.ResumeLayout(false);
            this.GBEstadoConvenio.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblNroRecibos;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.TextBox txtIgv;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView dgvRecibos;
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
        internal System.Windows.Forms.TextBox txtNrorecibo;
        internal System.Windows.Forms.TextBox TxtCodigoContribuyente;
        internal System.Windows.Forms.CheckBox ChTodos;
        internal System.Windows.Forms.Label LblNombre;
        internal System.Windows.Forms.TextBox TxtNombre;
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.Button BtnImprimir;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.ComboBox cboPrograma;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ReciboCabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieRecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}