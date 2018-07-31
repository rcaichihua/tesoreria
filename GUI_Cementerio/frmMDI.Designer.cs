namespace GUI_Cementerio
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cementerioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCementerioElAngelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCementerioPresbiteroMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cementerioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cementerioToolStripMenuItem
            // 
            this.cementerioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoCementerioElAngelToolStripMenuItem,
            this.ingresoCementerioPresbiteroMToolStripMenuItem});
            this.cementerioToolStripMenuItem.Name = "cementerioToolStripMenuItem";
            this.cementerioToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.cementerioToolStripMenuItem.Text = "&Cementerio";
            // 
            // ingresoCementerioElAngelToolStripMenuItem
            // 
            this.ingresoCementerioElAngelToolStripMenuItem.Name = "ingresoCementerioElAngelToolStripMenuItem";
            this.ingresoCementerioElAngelToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.ingresoCementerioElAngelToolStripMenuItem.Text = "Ingreso Cementerio El Angel";
            // 
            // ingresoCementerioPresbiteroMToolStripMenuItem
            // 
            this.ingresoCementerioPresbiteroMToolStripMenuItem.Name = "ingresoCementerioPresbiteroMToolStripMenuItem";
            this.ingresoCementerioPresbiteroMToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.ingresoCementerioPresbiteroMToolStripMenuItem.Text = "Ingreso Cementerio Presbitero M.";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 497);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "frmMDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cementerioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCementerioElAngelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCementerioPresbiteroMToolStripMenuItem;
    }
}