namespace GUI_Tesoreria.mantenimiento
{
    partial class frmFiltroCuarteles
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
            this.cuartelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCuartel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cementerio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuartelID,
            this.nombreCuartel,
            this.Tipo,
            this.puerta,
            this.Cementerio});
            this.dgvFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiltro.Location = new System.Drawing.Point(0, 0);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            this.dgvFiltro.RowHeadersWidth = 28;
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(691, 528);
            this.dgvFiltro.TabIndex = 2;
            this.dgvFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFiltro_KeyDown);
            // 
            // cuartelID
            // 
            this.cuartelID.DataPropertyName = "cuartelID";
            this.cuartelID.HeaderText = "ID";
            this.cuartelID.Name = "cuartelID";
            this.cuartelID.ReadOnly = true;
            this.cuartelID.Width = 50;
            // 
            // nombreCuartel
            // 
            this.nombreCuartel.DataPropertyName = "nombreCuartel";
            this.nombreCuartel.HeaderText = "Nombre Cuartel";
            this.nombreCuartel.Name = "nombreCuartel";
            this.nombreCuartel.ReadOnly = true;
            this.nombreCuartel.Width = 220;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // puerta
            // 
            this.puerta.DataPropertyName = "puerta";
            this.puerta.HeaderText = "Puerta";
            this.puerta.Name = "puerta";
            this.puerta.ReadOnly = true;
            // 
            // Cementerio
            // 
            this.Cementerio.DataPropertyName = "Cementerio";
            this.Cementerio.HeaderText = "Cementerio";
            this.Cementerio.Name = "Cementerio";
            this.Cementerio.ReadOnly = true;
            this.Cementerio.Width = 200;
            // 
            // frmFiltroCuarteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 528);
            this.Controls.Add(this.dgvFiltro);
            this.Name = "frmFiltroCuarteles";
            this.Text = "...:::Filtro Cuarteles:::...";
            this.Load += new System.EventHandler(this.frmFiltroCuarteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuartelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCuartel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn puerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cementerio;
    }
}