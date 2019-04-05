namespace GUI_Tesoreria.caja
{
    partial class frmComparaVouchersPagoEfectivo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComparaVouchersPagoEfectivo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCompara = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FechaRegistroCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVouchers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCobroEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompara)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompara
            // 
            this.dgvCompara.AllowUserToAddRows = false;
            this.dgvCompara.AllowUserToDeleteRows = false;
            this.dgvCompara.AllowUserToResizeColumns = false;
            this.dgvCompara.AllowUserToResizeRows = false;
            this.dgvCompara.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCompara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistroCaja,
            this.FechaDeposito,
            this.CantidadRecibos,
            this.CantidadVouchers,
            this.TotalCobroEfectivo,
            this.TotalDeposito,
            this.Diferencia});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompara.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvCompara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompara.Location = new System.Drawing.Point(3, 17);
            this.dgvCompara.Name = "dgvCompara";
            this.dgvCompara.ReadOnly = true;
            this.dgvCompara.RowHeadersVisible = false;
            this.dgvCompara.RowHeadersWidth = 10;
            this.dgvCompara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompara.Size = new System.Drawing.Size(565, 429);
            this.dgvCompara.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(511, 464);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 58);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dgvCompara);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 449);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de ingreso de efectivo vs Deposito relacionados";
            // 
            // FechaRegistroCaja
            // 
            this.FechaRegistroCaja.DataPropertyName = "FechaRegistroCaja";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaRegistroCaja.DefaultCellStyle = dataGridViewCellStyle11;
            this.FechaRegistroCaja.HeaderText = "FECHA REG CAJA";
            this.FechaRegistroCaja.Name = "FechaRegistroCaja";
            this.FechaRegistroCaja.ReadOnly = true;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.DataPropertyName = "FechaDeposito";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaDeposito.DefaultCellStyle = dataGridViewCellStyle12;
            this.FechaDeposito.HeaderText = "FECHA DEPOSITO";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            this.FechaDeposito.Visible = false;
            // 
            // CantidadRecibos
            // 
            this.CantidadRecibos.DataPropertyName = "CantidadRecibos";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CantidadRecibos.DefaultCellStyle = dataGridViewCellStyle13;
            this.CantidadRecibos.HeaderText = "CANT. DOC";
            this.CantidadRecibos.Name = "CantidadRecibos";
            this.CantidadRecibos.ReadOnly = true;
            this.CantidadRecibos.Width = 70;
            // 
            // CantidadVouchers
            // 
            this.CantidadVouchers.DataPropertyName = "CantidadVouchers";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CantidadVouchers.DefaultCellStyle = dataGridViewCellStyle14;
            this.CantidadVouchers.HeaderText = "CANT. VOUCH.";
            this.CantidadVouchers.Name = "CantidadVouchers";
            this.CantidadVouchers.ReadOnly = true;
            this.CantidadVouchers.Width = 70;
            // 
            // TotalCobroEfectivo
            // 
            this.TotalCobroEfectivo.DataPropertyName = "TotalCobroEfectivo";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Format = "N2";
            this.TotalCobroEfectivo.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalCobroEfectivo.HeaderText = "TOTAL EFECTIVO";
            this.TotalCobroEfectivo.Name = "TotalCobroEfectivo";
            this.TotalCobroEfectivo.ReadOnly = true;
            // 
            // TotalDeposito
            // 
            this.TotalDeposito.DataPropertyName = "TotalDeposito";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle16.Format = "N2";
            this.TotalDeposito.DefaultCellStyle = dataGridViewCellStyle16;
            this.TotalDeposito.HeaderText = "TOTAL DEPOSITO";
            this.TotalDeposito.Name = "TotalDeposito";
            this.TotalDeposito.ReadOnly = true;
            // 
            // Diferencia
            // 
            this.Diferencia.DataPropertyName = "Diferencia";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N2";
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle17;
            this.Diferencia.HeaderText = "DIFERENCIA";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            // 
            // frmComparaVouchersPagoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmComparaVouchersPagoEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Listado:::...";
            this.Load += new System.EventHandler(this.frmComparaVouchersPagoEfectivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompara)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.DataGridView dgvCompara;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVouchers;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCobroEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
        internal System.Windows.Forms.GroupBox groupBox3;
    }
}