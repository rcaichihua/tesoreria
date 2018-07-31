namespace GUI_Tesoreria.mantenimiento
{
    partial class frmFiltro
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
            this.dgvFiltro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.Location = new System.Drawing.Point(0, 0);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            this.dgvFiltro.RowHeadersWidth = 28;
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(517, 457);
            this.dgvFiltro.TabIndex = 0;
            this.dgvFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFiltro_KeyDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_cuenta_contable";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "codigoCuenta";
            this.Column2.HeaderText = "Codigo cuenta contable";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descripcionCuenta";
            this.Column3.HeaderText = "Descripcion cuenta contable";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 250;
            // 
            // frmFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 457);
            this.Controls.Add(this.dgvFiltro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFiltro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Filtro:::...";
            this.Load += new System.EventHandler(this.frmFiltro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}