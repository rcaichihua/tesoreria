namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    partial class frmListadoRecibosTotal
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
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListadoRecibos = new System.Windows.Forms.DataGridView();
            this.IdReciboCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrorecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionModalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeCambioIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtNroLiquidacion = new System.Windows.Forms.TextBox();
            this.TxtCodigoContribuyente = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNroLiquidaciones = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalIngresoCaja = new System.Windows.Forms.TextBox();
            this.GBOpciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).BeginInit();
            this.GBEstadoConvenio.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btnImprimir);
            this.GBOpciones.Controls.Add(this.btnEditar);
            this.GBOpciones.Controls.Add(this.btnCancelar);
            this.GBOpciones.Controls.Add(this.btnAnular);
            this.GBOpciones.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBOpciones.Location = new System.Drawing.Point(939, 111);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(84, 393);
            this.GBOpciones.TabIndex = 150;
            this.GBOpciones.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Navy;
            this.btnImprimir.Image = global::GUI_Tesoreria.Properties.Resources.imprimirD;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(8, 75);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 57);
            this.btnImprimir.TabIndex = 148;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Navy;
            this.btnEditar.Image = global::GUI_Tesoreria.Properties.Resources.editarD;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(8, 138);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 57);
            this.btnEditar.TabIndex = 148;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(8, 330);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 57);
            this.btnCancelar.TabIndex = 148;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Navy;
            this.btnAnular.Image = global::GUI_Tesoreria.Properties.Resources.eliminarV;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(8, 17);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(69, 52);
            this.btnAnular.TabIndex = 148;
            this.btnAnular.Text = "&Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvListadoRecibos);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 342);
            this.groupBox2.TabIndex = 149;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de recibos de caja";
            // 
            // dgvListadoRecibos
            // 
            this.dgvListadoRecibos.AllowUserToAddRows = false;
            this.dgvListadoRecibos.AllowUserToDeleteRows = false;
            this.dgvListadoRecibos.AllowUserToResizeColumns = false;
            this.dgvListadoRecibos.AllowUserToResizeRows = false;
            this.dgvListadoRecibos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoRecibos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdReciboCaja,
            this.Nrorecibo,
            this.receptorNombre,
            this.descripcionModalidad,
            this.moneda,
            this.importeIngreso,
            this.tipoCambio,
            this.importeCambioIngreso,
            this.totalDocumento,
            this.glosa,
            this.ESTADO});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListadoRecibos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoRecibos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoRecibos.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvListadoRecibos.Location = new System.Drawing.Point(3, 17);
            this.dgvListadoRecibos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvListadoRecibos.Name = "dgvListadoRecibos";
            this.dgvListadoRecibos.ReadOnly = true;
            this.dgvListadoRecibos.RowHeadersVisible = false;
            this.dgvListadoRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoRecibos.Size = new System.Drawing.Size(917, 322);
            this.dgvListadoRecibos.TabIndex = 0;
            this.dgvListadoRecibos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListadoRecibos_CellFormatting);
            // 
            // IdReciboCaja
            // 
            this.IdReciboCaja.DataPropertyName = "IdReciboCaja";
            this.IdReciboCaja.HeaderText = "IdReciboCaja";
            this.IdReciboCaja.Name = "IdReciboCaja";
            this.IdReciboCaja.ReadOnly = true;
            this.IdReciboCaja.Visible = false;
            // 
            // Nrorecibo
            // 
            this.Nrorecibo.DataPropertyName = "Nrorecibo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nrorecibo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nrorecibo.HeaderText = "Nº RECIBO";
            this.Nrorecibo.Name = "Nrorecibo";
            this.Nrorecibo.ReadOnly = true;
            this.Nrorecibo.Width = 80;
            // 
            // receptorNombre
            // 
            this.receptorNombre.DataPropertyName = "receptorNombre";
            this.receptorNombre.HeaderText = "NOMBRE";
            this.receptorNombre.Name = "receptorNombre";
            this.receptorNombre.ReadOnly = true;
            this.receptorNombre.Width = 180;
            // 
            // descripcionModalidad
            // 
            this.descripcionModalidad.DataPropertyName = "descripcionModalidad";
            this.descripcionModalidad.HeaderText = "MODALIDAD";
            this.descripcionModalidad.Name = "descripcionModalidad";
            this.descripcionModalidad.ReadOnly = true;
            this.descripcionModalidad.Width = 80;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "MONEDA";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 60;
            // 
            // importeIngreso
            // 
            this.importeIngreso.DataPropertyName = "importeIngreso";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.importeIngreso.DefaultCellStyle = dataGridViewCellStyle2;
            this.importeIngreso.HeaderText = "INGRESO REAL";
            this.importeIngreso.Name = "importeIngreso";
            this.importeIngreso.ReadOnly = true;
            this.importeIngreso.Width = 80;
            // 
            // tipoCambio
            // 
            this.tipoCambio.DataPropertyName = "tipoCambio";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            this.tipoCambio.DefaultCellStyle = dataGridViewCellStyle3;
            this.tipoCambio.HeaderText = "T.C.";
            this.tipoCambio.Name = "tipoCambio";
            this.tipoCambio.ReadOnly = true;
            this.tipoCambio.Width = 50;
            // 
            // importeCambioIngreso
            // 
            this.importeCambioIngreso.DataPropertyName = "importeCambioIngreso";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.importeCambioIngreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.importeCambioIngreso.HeaderText = "TOTAL CAMBIO";
            this.importeCambioIngreso.Name = "importeCambioIngreso";
            this.importeCambioIngreso.ReadOnly = true;
            this.importeCambioIngreso.Width = 80;
            // 
            // totalDocumento
            // 
            this.totalDocumento.DataPropertyName = "totalDocumento";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.totalDocumento.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalDocumento.HeaderText = "TOTAL";
            this.totalDocumento.Name = "totalDocumento";
            this.totalDocumento.ReadOnly = true;
            this.totalDocumento.Width = 80;
            // 
            // glosa
            // 
            this.glosa.DataPropertyName = "glosa";
            this.glosa.HeaderText = "GLOSA";
            this.glosa.Name = "glosa";
            this.glosa.ReadOnly = true;
            this.glosa.Width = 200;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Visible = false;
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
            this.BtnBuscar.TabIndex = 154;
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
            this.GBEstadoConvenio.Location = new System.Drawing.Point(837, 44);
            this.GBEstadoConvenio.MaximumSize = new System.Drawing.Size(303, 61);
            this.GBEstadoConvenio.Name = "GBEstadoConvenio";
            this.GBEstadoConvenio.Size = new System.Drawing.Size(186, 61);
            this.GBEstadoConvenio.TabIndex = 152;
            this.GBEstadoConvenio.TabStop = false;
            this.GBEstadoConvenio.Text = "Estado de recibo";
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
            this.RBActivos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBActivos.ForeColor = System.Drawing.Color.Navy;
            this.RBActivos.Location = new System.Drawing.Point(6, 16);
            this.RBActivos.Name = "RBActivos";
            this.RBActivos.Size = new System.Drawing.Size(67, 17);
            this.RBActivos.TabIndex = 4;
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
            this.GroupBox1.Controls.Add(this.txtNroLiquidacion);
            this.GroupBox1.Controls.Add(this.TxtCodigoContribuyente);
            this.GroupBox1.Controls.Add(this.LblNombre);
            this.GroupBox1.Controls.Add(this.TxtNombre);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox1.Location = new System.Drawing.Point(12, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(735, 61);
            this.GroupBox1.TabIndex = 153;
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
            // txtNroLiquidacion
            // 
            this.txtNroLiquidacion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtNroLiquidacion.ForeColor = System.Drawing.Color.Maroon;
            this.txtNroLiquidacion.Location = new System.Drawing.Point(9, 33);
            this.txtNroLiquidacion.Name = "txtNroLiquidacion";
            this.txtNroLiquidacion.Size = new System.Drawing.Size(96, 21);
            this.txtNroLiquidacion.TabIndex = 116;
            this.txtNroLiquidacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // LblNombre
            // 
            this.LblNombre.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Navy;
            this.LblNombre.Location = new System.Drawing.Point(6, 16);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(441, 15);
            this.LblNombre.TabIndex = 87;
            this.LblNombre.Text = "Nro. Recibo  -       Nombre :";
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
            this.LblTitulo.Size = new System.Drawing.Size(1011, 32);
            this.LblTitulo.TabIndex = 151;
            this.LblTitulo.Text = ":::   RECIBOS DE INGRESO EMITIDOS  :::\r\n";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.lblNroLiquidaciones);
            this.GroupBox3.Controls.Add(this.label7);
            this.GroupBox3.Controls.Add(this.label2);
            this.GroupBox3.Controls.Add(this.txtTotalIngresoCaja);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.GroupBox3.Location = new System.Drawing.Point(12, 459);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(923, 45);
            this.GroupBox3.TabIndex = 155;
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
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "Cantidad de documentos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(533, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalIngresoCaja
            // 
            this.txtTotalIngresoCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalIngresoCaja.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotalIngresoCaja.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotalIngresoCaja.Location = new System.Drawing.Point(575, 10);
            this.txtTotalIngresoCaja.MaxLength = 4000;
            this.txtTotalIngresoCaja.Name = "txtTotalIngresoCaja";
            this.txtTotalIngresoCaja.ReadOnly = true;
            this.txtTotalIngresoCaja.Size = new System.Drawing.Size(132, 21);
            this.txtTotalIngresoCaja.TabIndex = 89;
            this.txtTotalIngresoCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmListadoRecibosTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 506);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GBEstadoConvenio);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListadoRecibosTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listado total de Recibos:::...";
            this.Load += new System.EventHandler(this.frmListadoRecibosTotal_Load);
            this.GBOpciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoRecibos)).EndInit();
            this.GBEstadoConvenio.ResumeLayout(false);
            this.GBEstadoConvenio.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnAnular;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvListadoRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdReciboCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrorecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionModalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeCambioIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn glosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
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
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label lblNroLiquidaciones;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTotalIngresoCaja;
    }
}