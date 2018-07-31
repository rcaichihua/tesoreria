namespace GUI_Tesoreria.cementerio
{
    partial class frmListarCuarteles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cuartelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCuartel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cementerio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nichos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niveles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFiltro
            // 
            this.dgvFiltro.AllowUserToAddRows = false;
            this.dgvFiltro.AllowUserToDeleteRows = false;
            this.dgvFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cuartelID,
            this.nombreCuartel,
            this.Tipo,
            this.puerta,
            this.intCeId,
            this.Cementerio,
            this.nichos,
            this.niveles});
            this.dgvFiltro.Location = new System.Drawing.Point(13, 58);
            this.dgvFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFiltro.Name = "dgvFiltro";
            this.dgvFiltro.ReadOnly = true;
            this.dgvFiltro.RowHeadersWidth = 28;
            this.dgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiltro.Size = new System.Drawing.Size(638, 442);
            this.dgvFiltro.TabIndex = 3;
            this.dgvFiltro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiltro_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro para busqueda de cuartel";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(247, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(272, 22);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // cuartelID
            // 
            this.cuartelID.DataPropertyName = "cuartelID";
            this.cuartelID.HeaderText = "ID";
            this.cuartelID.Name = "cuartelID";
            this.cuartelID.ReadOnly = true;
            this.cuartelID.Width = 46;
            // 
            // nombreCuartel
            // 
            this.nombreCuartel.DataPropertyName = "nombreCuartel";
            this.nombreCuartel.FillWeight = 83.23158F;
            this.nombreCuartel.HeaderText = "Nombre Cuartel";
            this.nombreCuartel.Name = "nombreCuartel";
            this.nombreCuartel.ReadOnly = true;
            this.nombreCuartel.Width = 121;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.FillWeight = 46.4277F;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 61;
            // 
            // puerta
            // 
            this.puerta.DataPropertyName = "puerta";
            this.puerta.FillWeight = 65.31535F;
            this.puerta.HeaderText = "Puerta";
            this.puerta.Name = "puerta";
            this.puerta.ReadOnly = true;
            this.puerta.Width = 75;
            // 
            // intCeId
            // 
            this.intCeId.DataPropertyName = "intCeId";
            this.intCeId.HeaderText = "intCeId";
            this.intCeId.Name = "intCeId";
            this.intCeId.ReadOnly = true;
            this.intCeId.Visible = false;
            this.intCeId.Width = 76;
            // 
            // Cementerio
            // 
            this.Cementerio.DataPropertyName = "Cementerio";
            this.Cementerio.FillWeight = 92.47495F;
            this.Cementerio.HeaderText = "Cementerio";
            this.Cementerio.Name = "Cementerio";
            this.Cementerio.ReadOnly = true;
            this.Cementerio.Width = 105;
            // 
            // nichos
            // 
            this.nichos.DataPropertyName = "nichos";
            this.nichos.FillWeight = 129.8093F;
            this.nichos.HeaderText = "nichos";
            this.nichos.Name = "nichos";
            this.nichos.ReadOnly = true;
            this.nichos.Width = 74;
            // 
            // niveles
            // 
            this.niveles.DataPropertyName = "niveles";
            this.niveles.FillWeight = 182.7411F;
            this.niveles.HeaderText = "niveles";
            this.niveles.Name = "niveles";
            this.niveles.ReadOnly = true;
            this.niveles.Width = 77;
            // 
            // frmListarCuarteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 513);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListarCuarteles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarCuarteles";
            this.Load += new System.EventHandler(this.frmListarCuarteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuartelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCuartel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn puerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cementerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nichos;
        private System.Windows.Forms.DataGridViewTextBoxColumn niveles;
    }
}