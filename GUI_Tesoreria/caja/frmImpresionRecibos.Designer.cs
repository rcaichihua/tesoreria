namespace GUI_Tesoreria.caja
{
    partial class frmImpresionRecibos
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
            this.crvReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvReportes
            // 
            this.crvReportes.ActiveViewIndex = -1;
            this.crvReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportes.Location = new System.Drawing.Point(0, 32);
            this.crvReportes.Margin = new System.Windows.Forms.Padding(2);
            this.crvReportes.Name = "crvReportes";
            this.crvReportes.Size = new System.Drawing.Size(750, 550);
            this.crvReportes.TabIndex = 1;
            this.crvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(0, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir Recibo";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmImpresionRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 582);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.crvReportes);
            this.DoubleBuffered = true;
            this.Name = "frmImpresionRecibos";
            this.Text = "frmImpresionRecibos";
            this.ResumeLayout(false);

        }

        #endregion

        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportes;
        private System.Windows.Forms.Button btnImprimir;
    }
}