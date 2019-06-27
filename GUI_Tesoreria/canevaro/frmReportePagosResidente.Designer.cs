namespace GUI_Tesoreria.canevaro
{
    partial class frmReportePagosResidente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePagosResidente));
            this.crvReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboAFiscal = new System.Windows.Forms.ComboBox();
            this.cboResidentes = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvReportes
            // 
            this.crvReportes.ActiveViewIndex = -1;
            this.crvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReportes.Location = new System.Drawing.Point(0, 0);
            this.crvReportes.Margin = new System.Windows.Forms.Padding(2);
            this.crvReportes.Name = "crvReportes";
            this.crvReportes.SelectionFormula = "";
            this.crvReportes.Size = new System.Drawing.Size(733, 489);
            this.crvReportes.TabIndex = 0;
            this.crvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReportes.ViewTimeSelectionFormula = "";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.txtBuscar);
            this.Panel1.Controls.Add(this.cboAFiscal);
            this.Panel1.Controls.Add(this.cboResidentes);
            this.Panel1.Controls.Add(this.btnImprimir);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(733, 45);
            this.Panel1.TabIndex = 91;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(361, 15);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(112, 21);
            this.txtBuscar.TabIndex = 88;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_TextChanged);
            // 
            // cboAFiscal
            // 
            this.cboAFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAFiscal.FormattingEnabled = true;
            this.cboAFiscal.Items.AddRange(new object[] {
            "2006",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cboAFiscal.Location = new System.Drawing.Point(548, 16);
            this.cboAFiscal.Name = "cboAFiscal";
            this.cboAFiscal.Size = new System.Drawing.Size(121, 21);
            this.cboAFiscal.TabIndex = 86;
            // 
            // cboResidentes
            // 
            this.cboResidentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResidentes.FormattingEnabled = true;
            this.cboResidentes.Location = new System.Drawing.Point(96, 16);
            this.cboResidentes.Name = "cboResidentes";
            this.cboResidentes.Size = new System.Drawing.Size(260, 21);
            this.cboResidentes.TabIndex = 85;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(695, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(26, 23);
            this.btnImprimir.TabIndex = 76;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Residente";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Navy;
            this.Label5.Location = new System.Drawing.Point(514, 20);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 84;
            this.Label5.Text = "Año";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.crvReportes);
            this.splitContainer1.Size = new System.Drawing.Size(733, 537);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 92;
            // 
            // frmReportePagosResidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 537);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReportePagosResidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Reportes:::...";
            this.Load += new System.EventHandler(this.frmReporteProceso_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReportes;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboAFiscal;
        private System.Windows.Forms.ComboBox cboResidentes;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtBuscar;


    }
}