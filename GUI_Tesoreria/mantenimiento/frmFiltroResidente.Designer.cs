namespace GUI_Tesoreria.mantenimiento
{
    partial class frmFiltroResidente
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
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.redidenteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.redidenteId,
            this.Nombres});
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.Location = new System.Drawing.Point(0, 0);
            this.dgvFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            this.dgvFiltro.RowHeadersWidth = 28;
            this.dgvFiltro.Size = new System.Drawing.Size(537, 566);
            this.dgvFiltro.TabIndex = 0;
            this.dgvFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFiltro_KeyDown);
            // 
            // redidenteId
            // 
            this.redidenteId.DataPropertyName = "residenteId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.redidenteId.DefaultCellStyle = dataGridViewCellStyle1;
            this.redidenteId.HeaderText = "Residente ID";
            this.redidenteId.Name = "redidenteId";
            this.redidenteId.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 250;
            // 
            // frmFiltroResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 566);
            this.Controls.Add(this.dgvFiltro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmFiltroResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Filtro Residente:::...";
            this.Load += new System.EventHandler(this.frmFiltroResidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn redidenteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;

    }
}