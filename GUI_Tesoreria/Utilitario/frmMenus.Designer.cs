namespace GUI_Tesoreria.mantenimiento
{
    partial class frmMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenus));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.codmenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_submenu0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_submenu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_submenu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_submenu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_submenu4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.dgvMenu);
            this.GroupBox1.ForeColor = System.Drawing.Color.Navy;
            this.GroupBox1.Location = new System.Drawing.Point(16, 15);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupBox1.Size = new System.Drawing.Size(1281, 554);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codmenu,
            this.Column1,
            this.Column2,
            this.menu1,
            this.url,
            this.padre,
            this.orden,
            this.estado,
            this.id_submenu0,
            this.id_submenu1,
            this.id_submenu2,
            this.id_submenu3,
            this.id_submenu4});
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(4, 19);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersWidth = 30;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(1273, 531);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CurrentCellChanged += new System.EventHandler(this.dgvMenu_CurrentCellChanged);
            // 
            // codmenu
            // 
            this.codmenu.DataPropertyName = "intMeId";
            this.codmenu.HeaderText = "codmenu";
            this.codmenu.Name = "codmenu";
            this.codmenu.ReadOnly = true;
            this.codmenu.Width = 55;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "menuPrincipalID";
            this.Column1.HeaderText = "codMPId";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 55;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "subMenuPrincipalID";
            this.Column2.HeaderText = "codSMPId";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 55;
            // 
            // menu1
            // 
            this.menu1.DataPropertyName = "varMeNombreMenu";
            this.menu1.HeaderText = "menú";
            this.menu1.Name = "menu1";
            this.menu1.ReadOnly = true;
            this.menu1.Width = 160;
            // 
            // url
            // 
            this.url.DataPropertyName = "varMeNombreVariable";
            this.url.HeaderText = "NomVar";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            this.url.Width = 50;
            // 
            // padre
            // 
            this.padre.DataPropertyName = "intMePadre";
            this.padre.HeaderText = "padre";
            this.padre.Name = "padre";
            this.padre.ReadOnly = true;
            this.padre.Width = 50;
            // 
            // orden
            // 
            this.orden.DataPropertyName = "intMeOrden";
            this.orden.HeaderText = "orden";
            this.orden.Name = "orden";
            this.orden.ReadOnly = true;
            this.orden.Width = 50;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "bitMeEstado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estado.Width = 60;
            // 
            // id_submenu0
            // 
            this.id_submenu0.DataPropertyName = "intMeId_submenu0";
            this.id_submenu0.HeaderText = "id_submenu0";
            this.id_submenu0.Name = "id_submenu0";
            this.id_submenu0.ReadOnly = true;
            this.id_submenu0.Width = 75;
            // 
            // id_submenu1
            // 
            this.id_submenu1.DataPropertyName = "intMeId_submenu1";
            this.id_submenu1.HeaderText = "id_submenu1";
            this.id_submenu1.Name = "id_submenu1";
            this.id_submenu1.ReadOnly = true;
            this.id_submenu1.Width = 75;
            // 
            // id_submenu2
            // 
            this.id_submenu2.DataPropertyName = "intMeId_submenu2";
            this.id_submenu2.HeaderText = "id_submenu2";
            this.id_submenu2.Name = "id_submenu2";
            this.id_submenu2.ReadOnly = true;
            this.id_submenu2.Width = 75;
            // 
            // id_submenu3
            // 
            this.id_submenu3.DataPropertyName = "intMeId_submenu3";
            this.id_submenu3.HeaderText = "id_submenu3";
            this.id_submenu3.Name = "id_submenu3";
            this.id_submenu3.ReadOnly = true;
            this.id_submenu3.Width = 75;
            // 
            // id_submenu4
            // 
            this.id_submenu4.DataPropertyName = "intMeId_submenu4";
            this.id_submenu4.HeaderText = "id_submenu4";
            this.id_submenu4.Name = "id_submenu4";
            this.id_submenu4.ReadOnly = true;
            this.id_submenu4.Width = 75;
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistros.Location = new System.Drawing.Point(20, 590);
            this.lblRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(74, 19);
            this.lblRegistros.TabIndex = 13;
            this.lblRegistros.Text = "1 de 100";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1208, 576);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 90);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 681);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Descripción de Menús:::...";
            this.Load += new System.EventHandler(this.frmMenus_Load);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvMenu;
        internal System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codmenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn orden;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submenu0;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submenu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submenu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submenu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submenu4;
    }
}