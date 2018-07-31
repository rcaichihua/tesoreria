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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComparaVouchersPagoEfectivo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.dgvCompara = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.FechaRegistroCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRecibos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVouchers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCobroEfectivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompara)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvCompara);
            this.GBDatosRubros.Location = new System.Drawing.Point(12, 12);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(593, 312);
            this.GBDatosRubros.TabIndex = 116;
            this.GBDatosRubros.TabStop = false;
            // 
            // dgvCompara
            // 
            this.dgvCompara.AllowUserToAddRows = false;
            this.dgvCompara.AllowUserToDeleteRows = false;
            this.dgvCompara.AllowUserToResizeColumns = false;
            this.dgvCompara.AllowUserToResizeRows = false;
            this.dgvCompara.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompara.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompara.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistroCaja,
            this.FechaDeposito,
            this.CantidadRecibos,
            this.CantidadVouchers,
            this.TotalCobroEfectivo,
            this.TotalDeposito,
            this.Diferencia});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompara.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCompara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompara.Location = new System.Drawing.Point(3, 16);
            this.dgvCompara.Name = "dgvCompara";
            this.dgvCompara.ReadOnly = true;
            this.dgvCompara.RowHeadersVisible = false;
            this.dgvCompara.RowHeadersWidth = 10;
            this.dgvCompara.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompara.Size = new System.Drawing.Size(587, 293);
            this.dgvCompara.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(533, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(72, 58);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FechaRegistroCaja
            // 
            this.FechaRegistroCaja.DataPropertyName = "FechaRegistroCaja";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaRegistroCaja.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaRegistroCaja.HeaderText = "FECHA REG CAJA";
            this.FechaRegistroCaja.Name = "FechaRegistroCaja";
            this.FechaRegistroCaja.ReadOnly = true;
            this.FechaRegistroCaja.Width = 80;
            // 
            // FechaDeposito
            // 
            this.FechaDeposito.DataPropertyName = "FechaDeposito";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.FechaDeposito.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaDeposito.HeaderText = "FECHA DEPOSITO";
            this.FechaDeposito.Name = "FechaDeposito";
            this.FechaDeposito.ReadOnly = true;
            this.FechaDeposito.Width = 80;
            // 
            // CantidadRecibos
            // 
            this.CantidadRecibos.DataPropertyName = "CantidadRecibos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CantidadRecibos.DefaultCellStyle = dataGridViewCellStyle4;
            this.CantidadRecibos.HeaderText = "CANT. DOC";
            this.CantidadRecibos.Name = "CantidadRecibos";
            this.CantidadRecibos.ReadOnly = true;
            this.CantidadRecibos.Width = 70;
            // 
            // CantidadVouchers
            // 
            this.CantidadVouchers.DataPropertyName = "CantidadVouchers";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.CantidadVouchers.DefaultCellStyle = dataGridViewCellStyle5;
            this.CantidadVouchers.HeaderText = "CANT. VOUCH.";
            this.CantidadVouchers.Name = "CantidadVouchers";
            this.CantidadVouchers.ReadOnly = true;
            this.CantidadVouchers.Width = 70;
            // 
            // TotalCobroEfectivo
            // 
            this.TotalCobroEfectivo.DataPropertyName = "TotalCobroEfectivo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            this.TotalCobroEfectivo.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalCobroEfectivo.HeaderText = "TOTAL EFECTIVO";
            this.TotalCobroEfectivo.Name = "TotalCobroEfectivo";
            this.TotalCobroEfectivo.ReadOnly = true;
            this.TotalCobroEfectivo.Width = 90;
            // 
            // TotalDeposito
            // 
            this.TotalDeposito.DataPropertyName = "TotalDeposito";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "N2";
            this.TotalDeposito.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotalDeposito.HeaderText = "TOTAL DEPOSITO";
            this.TotalDeposito.Name = "TotalDeposito";
            this.TotalDeposito.ReadOnly = true;
            this.TotalDeposito.Width = 90;
            // 
            // Diferencia
            // 
            this.Diferencia.DataPropertyName = "Diferencia";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "N2";
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle8;
            this.Diferencia.HeaderText = "DIFERENCIA";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.Width = 70;
            // 
            // frmComparaVouchersPagoEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 392);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GBDatosRubros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmComparaVouchersPagoEfectivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmComparaVouchersPagoEfectivo";
            this.Load += new System.EventHandler(this.frmComparaVouchersPagoEfectivo_Load);
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView dgvCompara;
        protected System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRecibos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVouchers;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCobroEfectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
    }
}