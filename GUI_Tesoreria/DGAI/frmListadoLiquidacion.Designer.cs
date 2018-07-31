namespace GUI_Tesoreria.DGAI
{
    partial class frmListadoLiquidacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GBDatosRubros = new System.Windows.Forms.GroupBox();
            this.dgvDGAI = new System.Windows.Forms.DataGridView();
            this.id_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalEmbargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDepositado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_liquidacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fecha_registro_liquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnListLiquidaciones = new System.Windows.Forms.Button();
            this.GBDatosRubros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGAI)).BeginInit();
            this.SuspendLayout();
            // 
            // GBDatosRubros
            // 
            this.GBDatosRubros.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosRubros.Controls.Add(this.dgvDGAI);
            this.GBDatosRubros.Location = new System.Drawing.Point(12, 12);
            this.GBDatosRubros.Name = "GBDatosRubros";
            this.GBDatosRubros.Size = new System.Drawing.Size(751, 424);
            this.GBDatosRubros.TabIndex = 123;
            this.GBDatosRubros.TabStop = false;
            // 
            // dgvDGAI
            // 
            this.dgvDGAI.AllowUserToAddRows = false;
            this.dgvDGAI.AllowUserToDeleteRows = false;
            this.dgvDGAI.AllowUserToResizeColumns = false;
            this.dgvDGAI.AllowUserToResizeRows = false;
            this.dgvDGAI.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDGAI.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDGAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDGAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_liquidacion,
            this.numero_liquidacion,
            this.montoTotal,
            this.TotalEmbargo,
            this.TotalDepositado,
            this.TotalIngreso,
            this.fecha_liquidacion,
            this.estado_liquidacion,
            this.fecha_registro_liquidacion});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDGAI.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDGAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDGAI.Location = new System.Drawing.Point(3, 16);
            this.dgvDGAI.Name = "dgvDGAI";
            this.dgvDGAI.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDGAI.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDGAI.RowHeadersVisible = false;
            this.dgvDGAI.RowHeadersWidth = 10;
            this.dgvDGAI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDGAI.Size = new System.Drawing.Size(745, 405);
            this.dgvDGAI.TabIndex = 3;
            // 
            // id_liquidacion
            // 
            this.id_liquidacion.DataPropertyName = "id_liquidacion";
            this.id_liquidacion.HeaderText = "id_liquidacion";
            this.id_liquidacion.Name = "id_liquidacion";
            this.id_liquidacion.ReadOnly = true;
            this.id_liquidacion.Visible = false;
            // 
            // numero_liquidacion
            // 
            this.numero_liquidacion.DataPropertyName = "numero_liquidacion";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.numero_liquidacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.numero_liquidacion.HeaderText = "Nro liquidación";
            this.numero_liquidacion.Name = "numero_liquidacion";
            this.numero_liquidacion.ReadOnly = true;
            // 
            // montoTotal
            // 
            this.montoTotal.DataPropertyName = "montoTotal";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle3.Format = "N2";
            this.montoTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.montoTotal.HeaderText = "Monto cobrado";
            this.montoTotal.Name = "montoTotal";
            this.montoTotal.ReadOnly = true;
            // 
            // TotalEmbargo
            // 
            this.TotalEmbargo.DataPropertyName = "TotalEmbargo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            this.TotalEmbargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalEmbargo.HeaderText = "Total retenido";
            this.TotalEmbargo.Name = "TotalEmbargo";
            this.TotalEmbargo.ReadOnly = true;
            // 
            // TotalDepositado
            // 
            this.TotalDepositado.DataPropertyName = "TotalDepositado";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            this.TotalDepositado.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalDepositado.HeaderText = "Total Depositado";
            this.TotalDepositado.Name = "TotalDepositado";
            this.TotalDepositado.ReadOnly = true;
            // 
            // TotalIngreso
            // 
            this.TotalIngreso.DataPropertyName = "TotalIngreso";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle6.Format = "N2";
            this.TotalIngreso.DefaultCellStyle = dataGridViewCellStyle6;
            this.TotalIngreso.HeaderText = "Total Ingreso";
            this.TotalIngreso.Name = "TotalIngreso";
            this.TotalIngreso.ReadOnly = true;
            // 
            // fecha_liquidacion
            // 
            this.fecha_liquidacion.DataPropertyName = "fecha_liquidacion";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.fecha_liquidacion.DefaultCellStyle = dataGridViewCellStyle7;
            this.fecha_liquidacion.HeaderText = "Fecha Liquidación";
            this.fecha_liquidacion.Name = "fecha_liquidacion";
            this.fecha_liquidacion.ReadOnly = true;
            // 
            // estado_liquidacion
            // 
            this.estado_liquidacion.DataPropertyName = "estado_liquidacion";
            this.estado_liquidacion.HeaderText = "Estado";
            this.estado_liquidacion.Name = "estado_liquidacion";
            this.estado_liquidacion.ReadOnly = true;
            this.estado_liquidacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado_liquidacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // fecha_registro_liquidacion
            // 
            this.fecha_registro_liquidacion.DataPropertyName = "fecha_registro_liquidacion";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.fecha_registro_liquidacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.fecha_registro_liquidacion.HeaderText = "fecha_registro_liquidacion";
            this.fecha_registro_liquidacion.Name = "fecha_registro_liquidacion";
            this.fecha_registro_liquidacion.ReadOnly = true;
            this.fecha_registro_liquidacion.Visible = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Navy;
            this.btnSalir.Image = global::GUI_Tesoreria.Properties.Resources.exit;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(667, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 29);
            this.btnSalir.TabIndex = 124;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnListLiquidaciones
            // 
            this.btnListLiquidaciones.BackColor = System.Drawing.Color.White;
            this.btnListLiquidaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLiquidaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLiquidaciones.ForeColor = System.Drawing.Color.Navy;
            this.btnListLiquidaciones.Image = global::GUI_Tesoreria.Properties.Resources.anular;
            this.btnListLiquidaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListLiquidaciones.Location = new System.Drawing.Point(15, 439);
            this.btnListLiquidaciones.Name = "btnListLiquidaciones";
            this.btnListLiquidaciones.Size = new System.Drawing.Size(93, 29);
            this.btnListLiquidaciones.TabIndex = 124;
            this.btnListLiquidaciones.Text = "&Anular";
            this.btnListLiquidaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListLiquidaciones.UseVisualStyleBackColor = false;
            this.btnListLiquidaciones.Click += new System.EventHandler(this.btnListLiquidaciones_Click);
            // 
            // frmListadoLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListLiquidaciones);
            this.Controls.Add(this.GBDatosRubros);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmListadoLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListadoLiquidacion";
            this.Load += new System.EventHandler(this.frmListadoLiquidacion_Load);
            this.GBDatosRubros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDGAI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GBDatosRubros;
        internal System.Windows.Forms.DataGridView dgvDGAI;
        internal System.Windows.Forms.Button btnListLiquidaciones;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalEmbargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDepositado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_liquidacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado_liquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_registro_liquidacion;
    }
}