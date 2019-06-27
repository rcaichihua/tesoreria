namespace GUI_Tesoreria.Deposito
{
    partial class frmEdicionCompDiario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtpFechaLiquidación = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDiarioCabecera = new System.Windows.Forms.DataGridView();
            this.DONUME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOFECH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROGRAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLOSA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONOCO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIARIO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.dtpFechaComprobante = new System.Windows.Forms.DateTimePicker();
            this.txtNumCompro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDiarioCabeceraDet = new System.Windows.Forms.DataGridView();
            this.PLCODI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HABER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GLOSA_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIARIO_ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REG_ID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txthaber = new System.Windows.Forms.TextBox();
            this.txtdebe = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiarioCabecera)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiarioCabeceraDet)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Navy;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 162;
            this.Label2.Text = "Fecha";
            // 
            // dtpFechaLiquidación
            // 
            this.dtpFechaLiquidación.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiquidación.Location = new System.Drawing.Point(58, 9);
            this.dtpFechaLiquidación.Name = "dtpFechaLiquidación";
            this.dtpFechaLiquidación.Size = new System.Drawing.Size(104, 20);
            this.dtpFechaLiquidación.TabIndex = 161;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvDiarioCabecera);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 186);
            this.groupBox3.TabIndex = 163;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Vouchers";
            // 
            // dgvDiarioCabecera
            // 
            this.dgvDiarioCabecera.AllowUserToAddRows = false;
            this.dgvDiarioCabecera.AllowUserToDeleteRows = false;
            this.dgvDiarioCabecera.AllowUserToResizeColumns = false;
            this.dgvDiarioCabecera.AllowUserToResizeRows = false;
            this.dgvDiarioCabecera.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiarioCabecera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiarioCabecera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DONUME,
            this.DOFECH,
            this.PROGRAMA,
            this.GLOSA,
            this.DOCODI,
            this.DONOCO,
            this.DIARIO_ID});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiarioCabecera.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiarioCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiarioCabecera.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDiarioCabecera.Location = new System.Drawing.Point(3, 17);
            this.dgvDiarioCabecera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDiarioCabecera.Name = "dgvDiarioCabecera";
            this.dgvDiarioCabecera.ReadOnly = true;
            this.dgvDiarioCabecera.RowHeadersVisible = false;
            this.dgvDiarioCabecera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiarioCabecera.Size = new System.Drawing.Size(661, 166);
            this.dgvDiarioCabecera.TabIndex = 16;
            this.dgvDiarioCabecera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiarioCabecera_CellClick);
            this.dgvDiarioCabecera.SelectionChanged += new System.EventHandler(this.dgvDiarioCabecera_SelectionChanged);
            // 
            // DONUME
            // 
            this.DONUME.DataPropertyName = "DONUME";
            this.DONUME.HeaderText = "NUMERO";
            this.DONUME.Name = "DONUME";
            this.DONUME.ReadOnly = true;
            this.DONUME.Width = 60;
            // 
            // DOFECH
            // 
            this.DOFECH.DataPropertyName = "DOFECH";
            this.DOFECH.HeaderText = "FECHA";
            this.DOFECH.Name = "DOFECH";
            this.DOFECH.ReadOnly = true;
            this.DOFECH.Width = 70;
            // 
            // PROGRAMA
            // 
            this.PROGRAMA.DataPropertyName = "PROGRAMA";
            this.PROGRAMA.HeaderText = "PROGRAMA";
            this.PROGRAMA.Name = "PROGRAMA";
            this.PROGRAMA.ReadOnly = true;
            this.PROGRAMA.Width = 150;
            // 
            // GLOSA
            // 
            this.GLOSA.DataPropertyName = "GLOSA";
            this.GLOSA.HeaderText = "REFERENCIA";
            this.GLOSA.Name = "GLOSA";
            this.GLOSA.ReadOnly = true;
            this.GLOSA.Width = 300;
            // 
            // DOCODI
            // 
            this.DOCODI.DataPropertyName = "DOCODI";
            this.DOCODI.HeaderText = "DOCODI";
            this.DOCODI.Name = "DOCODI";
            this.DOCODI.ReadOnly = true;
            this.DOCODI.Visible = false;
            this.DOCODI.Width = 50;
            // 
            // DONOCO
            // 
            this.DONOCO.DataPropertyName = "DONOCO";
            this.DONOCO.HeaderText = "DONOCO";
            this.DONOCO.Name = "DONOCO";
            this.DONOCO.ReadOnly = true;
            this.DONOCO.Visible = false;
            this.DONOCO.Width = 50;
            // 
            // DIARIO_ID
            // 
            this.DIARIO_ID.DataPropertyName = "DIARIO_ID";
            this.DIARIO_ID.HeaderText = "DIARIO_ID";
            this.DIARIO_ID.Name = "DIARIO_ID";
            this.DIARIO_ID.ReadOnly = true;
            this.DIARIO_ID.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.dtpFechaComprobante);
            this.groupBox1.Controls.Add(this.txtNumCompro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 72);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.White;
            this.txtReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferencia.ForeColor = System.Drawing.Color.Maroon;
            this.txtReferencia.Location = new System.Drawing.Point(112, 41);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(549, 22);
            this.txtReferencia.TabIndex = 171;
            // 
            // dtpFechaComprobante
            // 
            this.dtpFechaComprobante.Enabled = false;
            this.dtpFechaComprobante.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaComprobante.Location = new System.Drawing.Point(557, 11);
            this.dtpFechaComprobante.Name = "dtpFechaComprobante";
            this.dtpFechaComprobante.Size = new System.Drawing.Size(104, 21);
            this.dtpFechaComprobante.TabIndex = 161;
            // 
            // txtNumCompro
            // 
            this.txtNumCompro.BackColor = System.Drawing.Color.White;
            this.txtNumCompro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumCompro.Enabled = false;
            this.txtNumCompro.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCompro.ForeColor = System.Drawing.Color.Maroon;
            this.txtNumCompro.Location = new System.Drawing.Point(112, 13);
            this.txtNumCompro.Name = "txtNumCompro";
            this.txtNumCompro.Size = new System.Drawing.Size(184, 22);
            this.txtNumCompro.TabIndex = 172;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(38, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 169;
            this.label3.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(511, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 162;
            this.label1.Text = "Fecha";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Navy;
            this.LblTotal.Location = new System.Drawing.Point(6, 17);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(100, 13);
            this.LblTotal.TabIndex = 170;
            this.LblTotal.Text = "Nº Comprobante";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDiarioCabeceraDet);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 186);
            this.groupBox2.TabIndex = 169;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Vouchers";
            // 
            // dgvDiarioCabeceraDet
            // 
            this.dgvDiarioCabeceraDet.AllowUserToAddRows = false;
            this.dgvDiarioCabeceraDet.AllowUserToDeleteRows = false;
            this.dgvDiarioCabeceraDet.AllowUserToResizeColumns = false;
            this.dgvDiarioCabeceraDet.AllowUserToResizeRows = false;
            this.dgvDiarioCabeceraDet.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiarioCabeceraDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiarioCabeceraDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PLCODI,
            this.DEBE,
            this.HABER,
            this.GLOSA_,
            this.DIARIO_ID_,
            this.REG_ID_});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiarioCabeceraDet.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiarioCabeceraDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiarioCabeceraDet.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDiarioCabeceraDet.Location = new System.Drawing.Point(3, 17);
            this.dgvDiarioCabeceraDet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDiarioCabeceraDet.Name = "dgvDiarioCabeceraDet";
            this.dgvDiarioCabeceraDet.ReadOnly = true;
            this.dgvDiarioCabeceraDet.RowHeadersVisible = false;
            this.dgvDiarioCabeceraDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiarioCabeceraDet.Size = new System.Drawing.Size(661, 166);
            this.dgvDiarioCabeceraDet.TabIndex = 16;
            // 
            // PLCODI
            // 
            this.PLCODI.DataPropertyName = "PLCODI";
            this.PLCODI.HeaderText = "CUENTA";
            this.PLCODI.Name = "PLCODI";
            this.PLCODI.ReadOnly = true;
            this.PLCODI.Width = 150;
            // 
            // DEBE
            // 
            this.DEBE.DataPropertyName = "DEBE";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "n2";
            this.DEBE.DefaultCellStyle = dataGridViewCellStyle2;
            this.DEBE.HeaderText = "DEBE";
            this.DEBE.Name = "DEBE";
            this.DEBE.ReadOnly = true;
            // 
            // HABER
            // 
            this.HABER.DataPropertyName = "HABER";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "n2";
            this.HABER.DefaultCellStyle = dataGridViewCellStyle3;
            this.HABER.HeaderText = "HABER";
            this.HABER.Name = "HABER";
            this.HABER.ReadOnly = true;
            // 
            // GLOSA_
            // 
            this.GLOSA_.DataPropertyName = "GLOSA";
            this.GLOSA_.HeaderText = "GLOSA";
            this.GLOSA_.Name = "GLOSA_";
            this.GLOSA_.ReadOnly = true;
            this.GLOSA_.Width = 150;
            // 
            // DIARIO_ID_
            // 
            this.DIARIO_ID_.DataPropertyName = "DIARIO_ID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DIARIO_ID_.DefaultCellStyle = dataGridViewCellStyle4;
            this.DIARIO_ID_.HeaderText = "DIARIO_ID";
            this.DIARIO_ID_.Name = "DIARIO_ID_";
            this.DIARIO_ID_.ReadOnly = true;
            this.DIARIO_ID_.Width = 70;
            // 
            // REG_ID_
            // 
            this.REG_ID_.DataPropertyName = "REG_ID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.REG_ID_.DefaultCellStyle = dataGridViewCellStyle5;
            this.REG_ID_.HeaderText = "REG_ID";
            this.REG_ID_.Name = "REG_ID_";
            this.REG_ID_.ReadOnly = true;
            this.REG_ID_.Width = 70;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(584, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 36);
            this.btnSalir.TabIndex = 165;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Image = global::GUI_Tesoreria.Properties.Resources.guardarDoc;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(108, 311);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 36);
            this.btnGuardar.TabIndex = 164;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Image = global::GUI_Tesoreria.Properties.Resources.modificar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 164;
            this.button3.Text = "&Modificar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Navy;
            this.btnEditar.Image = global::GUI_Tesoreria.Properties.Resources.editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(12, 311);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 36);
            this.btnEditar.TabIndex = 164;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Navy;
            this.btnVer.Image = global::GUI_Tesoreria.Properties.Resources.asignar;
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(486, 3);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(92, 36);
            this.btnVer.TabIndex = 164;
            this.btnVer.Text = "&Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Image = global::GUI_Tesoreria.Properties.Resources.salir_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(206, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 165;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // txthaber
            // 
            this.txthaber.BackColor = System.Drawing.Color.White;
            this.txthaber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthaber.Enabled = false;
            this.txthaber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthaber.ForeColor = System.Drawing.Color.Maroon;
            this.txthaber.Location = new System.Drawing.Point(270, 542);
            this.txthaber.Name = "txthaber";
            this.txthaber.Size = new System.Drawing.Size(124, 22);
            this.txthaber.TabIndex = 174;
            // 
            // txtdebe
            // 
            this.txtdebe.BackColor = System.Drawing.Color.White;
            this.txtdebe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdebe.Enabled = false;
            this.txtdebe.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdebe.ForeColor = System.Drawing.Color.Maroon;
            this.txtdebe.Location = new System.Drawing.Point(147, 542);
            this.txtdebe.Name = "txtdebe";
            this.txtdebe.Size = new System.Drawing.Size(117, 22);
            this.txtdebe.TabIndex = 175;
            // 
            // frmEdicionCompDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 584);
            this.Controls.Add(this.txthaber);
            this.Controls.Add(this.txtdebe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtpFechaLiquidación);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEdicionCompDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Edición Comprobante Diario:::...";
            this.Load += new System.EventHandler(this.frmEdicionCompDiario_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiarioCabecera)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiarioCabeceraDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.DateTimePicker dtpFechaLiquidación;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvDiarioCabecera;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaComprobante;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtReferencia;
        internal System.Windows.Forms.TextBox txtNumCompro;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label LblTotal;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.DataGridView dgvDiarioCabeceraDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HABER;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLOSA_;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIARIO_ID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn REG_ID_;
        internal System.Windows.Forms.Button btnEditar;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONUME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOFECH;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROGRAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GLOSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCODI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONOCO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIARIO_ID;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.TextBox txthaber;
        internal System.Windows.Forms.TextBox txtdebe;
    }
}