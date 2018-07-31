namespace GUI_Tesoreria.caja
{
    partial class frmAsignarVouchers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAsigna = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbSeleccionar = new System.Windows.Forms.GroupBox();
            this.rdbNinguno = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReciboID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante_ReciboCabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNroRecibos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigna)).BeginInit();
            this.grbSeleccionar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsigna
            // 
            this.dgvAsigna.AllowUserToAddRows = false;
            this.dgvAsigna.AllowUserToDeleteRows = false;
            this.dgvAsigna.AllowUserToResizeColumns = false;
            this.dgvAsigna.AllowUserToResizeRows = false;
            this.dgvAsigna.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsigna.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsigna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReciboID,
            this.Recibo,
            this.Solicitante_ReciboCabecera,
            this.Importe,
            this.seleccion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsigna.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAsigna.Location = new System.Drawing.Point(8, 36);
            this.dgvAsigna.Name = "dgvAsigna";
            this.dgvAsigna.RowHeadersVisible = false;
            this.dgvAsigna.RowHeadersWidth = 10;
            this.dgvAsigna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAsigna.Size = new System.Drawing.Size(584, 359);
            this.dgvAsigna.TabIndex = 4;
            this.dgvAsigna.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsigna_CellValueChanged);
            this.dgvAsigna.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvAsigna_CurrentCellDirtyStateChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Navy;
            this.btnGuardar.Location = new System.Drawing.Point(443, 410);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 32);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbSeleccionar
            // 
            this.grbSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.grbSeleccionar.Controls.Add(this.rdbNinguno);
            this.grbSeleccionar.Controls.Add(this.rdbTodos);
            this.grbSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSeleccionar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grbSeleccionar.Location = new System.Drawing.Point(8, 401);
            this.grbSeleccionar.Name = "grbSeleccionar";
            this.grbSeleccionar.Size = new System.Drawing.Size(169, 45);
            this.grbSeleccionar.TabIndex = 65;
            this.grbSeleccionar.TabStop = false;
            this.grbSeleccionar.Text = "Cancelar";
            // 
            // rdbNinguno
            // 
            this.rdbNinguno.AutoSize = true;
            this.rdbNinguno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNinguno.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbNinguno.Location = new System.Drawing.Point(95, 16);
            this.rdbNinguno.Name = "rdbNinguno";
            this.rdbNinguno.Size = new System.Drawing.Size(79, 19);
            this.rdbNinguno.TabIndex = 1;
            this.rdbNinguno.TabStop = true;
            this.rdbNinguno.Text = "&Ninguno";
            this.rdbNinguno.UseVisualStyleBackColor = true;
            this.rdbNinguno.CheckedChanged += new System.EventHandler(this.rdbNinguno_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTodos.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdbTodos.Location = new System.Drawing.Point(25, 16);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(64, 19);
            this.rdbTodos.TabIndex = 0;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "&Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(182, 401);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(255, 45);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(116, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(134, 22);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total a asignar";
            // 
            // ReciboID
            // 
            this.ReciboID.DataPropertyName = "ReciboID";
            this.ReciboID.HeaderText = "ID";
            this.ReciboID.Name = "ReciboID";
            this.ReciboID.ReadOnly = true;
            this.ReciboID.Visible = false;
            // 
            // Recibo
            // 
            this.Recibo.DataPropertyName = "Recibo";
            this.Recibo.HeaderText = "Recibo";
            this.Recibo.Name = "Recibo";
            this.Recibo.ReadOnly = true;
            // 
            // Solicitante_ReciboCabecera
            // 
            this.Solicitante_ReciboCabecera.DataPropertyName = "Solicitante_ReciboCabecera";
            this.Solicitante_ReciboCabecera.HeaderText = "Solicitante_ReciboCabecera";
            this.Solicitante_ReciboCabecera.Name = "Solicitante_ReciboCabecera";
            this.Solicitante_ReciboCabecera.ReadOnly = true;
            this.Solicitante_ReciboCabecera.Width = 250;
            // 
            // Importe
            // 
            this.Importe.DataPropertyName = "Importe";
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // seleccion
            // 
            this.seleccion.DataPropertyName = "seleccion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = false;
            this.seleccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.seleccion.FalseValue = "0";
            this.seleccion.HeaderText = "Select";
            this.seleccion.IndeterminateValue = "0";
            this.seleccion.Name = "seleccion";
            this.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.seleccion.TrueValue = "1";
            this.seleccion.Width = 60;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Location = new System.Drawing.Point(536, 410);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 32);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNroRecibos
            // 
            this.lblNroRecibos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroRecibos.ForeColor = System.Drawing.Color.Navy;
            this.lblNroRecibos.Location = new System.Drawing.Point(152, 18);
            this.lblNroRecibos.Name = "lblNroRecibos";
            this.lblNroRecibos.Size = new System.Drawing.Size(67, 15);
            this.lblNroRecibos.TabIndex = 124;
            this.lblNroRecibos.Text = "0";
            this.lblNroRecibos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 123;
            this.label7.Text = "Cantidad de recibos: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAsignarVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.lblNroRecibos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbSeleccionar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvAsigna);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAsignarVouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAsignarVouchers";
            this.Load += new System.EventHandler(this.frmAsignarVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigna)).EndInit();
            this.grbSeleccionar.ResumeLayout(false);
            this.grbSeleccionar.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvAsigna;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.GroupBox grbSeleccionar;
        internal System.Windows.Forms.RadioButton rdbNinguno;
        internal System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReciboID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante_ReciboCabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccion;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Label lblNroRecibos;
        internal System.Windows.Forms.Label label7;
    }
}