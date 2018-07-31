namespace GUI_Tesoreria.caja
{
    partial class frmDetalleRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleRecibo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVCtaCteImpuestos = new System.Windows.Forms.DataGridView();
            this.TxtFechaInicio = new System.Windows.Forms.TextBox();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TxtNumeroDoc = new System.Windows.Forms.TextBox();
            this.LblNumeroRecibo = new System.Windows.Forms.Label();
            this.GBDatosContribuyente = new System.Windows.Forms.GroupBox();
            this.TxtNombreContribuyente = new System.Windows.Forms.TextBox();
            this.LblContribuyente = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.id_recibocabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_movimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_tiporubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion_tiporubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_agencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharecibo_recibocabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_recibocabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion_recibocabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_recibocabecera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_rubros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_recibodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_movimiento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCtaCteImpuestos)).BeginInit();
            this.GBDatosContribuyente.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Black;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSalir.Location = new System.Drawing.Point(4, 31);
            this.BtnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(47, 38);
            this.BtnSalir.TabIndex = 84;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.DGVCtaCteImpuestos);
            this.GroupBox2.Location = new System.Drawing.Point(13, 115);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(766, 291);
            this.GroupBox2.TabIndex = 94;
            this.GroupBox2.TabStop = false;
            // 
            // DGVCtaCteImpuestos
            // 
            this.DGVCtaCteImpuestos.AllowUserToAddRows = false;
            this.DGVCtaCteImpuestos.AllowUserToDeleteRows = false;
            this.DGVCtaCteImpuestos.AllowUserToResizeColumns = false;
            this.DGVCtaCteImpuestos.AllowUserToResizeRows = false;
            this.DGVCtaCteImpuestos.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVCtaCteImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVCtaCteImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCtaCteImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_recibocabecera,
            this.id_movimiento,
            this.numero_movimiento,
            this.id_tiporubro,
            this.descripcion_tiporubro,
            this.id_Recibo,
            this.numero_recibo,
            this.id_agencia,
            this.nombre_agencia,
            this.fecharecibo_recibocabecera,
            this.total_recibocabecera,
            this.observacion_recibocabecera,
            this.id_usuario_caja,
            this.nombre_usuario,
            this.estado_recibocabecera,
            this.Estado,
            this.item_recibodetalle,
            this.idpagina,
            this.recibo,
            this.id_rubros,
            this.precio_recibodetalle,
            this.cantidad_recibodetalle,
            this.total_recibodetalle,
            this.numero_movimiento1});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCtaCteImpuestos.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVCtaCteImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCtaCteImpuestos.Location = new System.Drawing.Point(3, 16);
            this.DGVCtaCteImpuestos.Name = "DGVCtaCteImpuestos";
            this.DGVCtaCteImpuestos.ReadOnly = true;
            this.DGVCtaCteImpuestos.RowHeadersVisible = false;
            this.DGVCtaCteImpuestos.RowHeadersWidth = 10;
            this.DGVCtaCteImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCtaCteImpuestos.Size = new System.Drawing.Size(760, 272);
            this.DGVCtaCteImpuestos.TabIndex = 89;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtFechaInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtFechaInicio.ForeColor = System.Drawing.Color.Maroon;
            this.TxtFechaInicio.Location = new System.Drawing.Point(346, 43);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.ReadOnly = true;
            this.TxtFechaInicio.Size = new System.Drawing.Size(170, 21);
            this.TxtFechaInicio.TabIndex = 53;
            this.TxtFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.LblFechaInicio.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaInicio.ForeColor = System.Drawing.Color.Navy;
            this.LblFechaInicio.Location = new System.Drawing.Point(294, 46);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(46, 13);
            this.LblFechaInicio.TabIndex = 42;
            this.LblFechaInicio.Text = "Fecha :";
            // 
            // LblTitulo
            // 
            this.LblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitulo.BackColor = System.Drawing.Color.White;
            this.LblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.Navy;
            this.LblTitulo.Location = new System.Drawing.Point(12, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(767, 31);
            this.LblTitulo.TabIndex = 93;
            this.LblTitulo.Text = "::  DETALLE DEL DOCUMENTO  ::";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNumeroDoc
            // 
            this.TxtNumeroDoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNumeroDoc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.TxtNumeroDoc.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNumeroDoc.Location = new System.Drawing.Point(196, 43);
            this.TxtNumeroDoc.Name = "TxtNumeroDoc";
            this.TxtNumeroDoc.ReadOnly = true;
            this.TxtNumeroDoc.Size = new System.Drawing.Size(83, 21);
            this.TxtNumeroDoc.TabIndex = 56;
            this.TxtNumeroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNumeroRecibo
            // 
            this.LblNumeroRecibo.AutoSize = true;
            this.LblNumeroRecibo.BackColor = System.Drawing.Color.Transparent;
            this.LblNumeroRecibo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumeroRecibo.ForeColor = System.Drawing.Color.Navy;
            this.LblNumeroRecibo.Location = new System.Drawing.Point(20, 46);
            this.LblNumeroRecibo.Name = "LblNumeroRecibo";
            this.LblNumeroRecibo.Size = new System.Drawing.Size(94, 13);
            this.LblNumeroRecibo.TabIndex = 54;
            this.LblNumeroRecibo.Text = "Nº Documento :";
            // 
            // GBDatosContribuyente
            // 
            this.GBDatosContribuyente.BackColor = System.Drawing.Color.Transparent;
            this.GBDatosContribuyente.Controls.Add(this.TxtFechaInicio);
            this.GBDatosContribuyente.Controls.Add(this.LblFechaInicio);
            this.GBDatosContribuyente.Controls.Add(this.txtSerie);
            this.GBDatosContribuyente.Controls.Add(this.TxtNumeroDoc);
            this.GBDatosContribuyente.Controls.Add(this.LblNumeroRecibo);
            this.GBDatosContribuyente.Controls.Add(this.TxtNombreContribuyente);
            this.GBDatosContribuyente.Controls.Add(this.LblContribuyente);
            this.GBDatosContribuyente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBDatosContribuyente.Location = new System.Drawing.Point(12, 42);
            this.GBDatosContribuyente.Name = "GBDatosContribuyente";
            this.GBDatosContribuyente.Size = new System.Drawing.Size(710, 73);
            this.GBDatosContribuyente.TabIndex = 92;
            this.GBDatosContribuyente.TabStop = false;
            // 
            // TxtNombreContribuyente
            // 
            this.TxtNombreContribuyente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtNombreContribuyente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreContribuyente.ForeColor = System.Drawing.Color.Maroon;
            this.TxtNombreContribuyente.Location = new System.Drawing.Point(119, 16);
            this.TxtNombreContribuyente.Name = "TxtNombreContribuyente";
            this.TxtNombreContribuyente.ReadOnly = true;
            this.TxtNombreContribuyente.Size = new System.Drawing.Size(585, 21);
            this.TxtNombreContribuyente.TabIndex = 4;
            // 
            // LblContribuyente
            // 
            this.LblContribuyente.AutoSize = true;
            this.LblContribuyente.BackColor = System.Drawing.Color.Transparent;
            this.LblContribuyente.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContribuyente.ForeColor = System.Drawing.Color.Navy;
            this.LblContribuyente.Location = new System.Drawing.Point(61, 19);
            this.LblContribuyente.Name = "LblContribuyente";
            this.LblContribuyente.Size = new System.Drawing.Size(52, 13);
            this.LblContribuyente.TabIndex = 1;
            this.LblContribuyente.Text = "Cliente :";
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.BtnSalir);
            this.GroupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(725, 42);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(54, 73);
            this.GroupBox3.TabIndex = 95;
            this.GroupBox3.TabStop = false;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSerie.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtSerie.ForeColor = System.Drawing.Color.Maroon;
            this.txtSerie.Location = new System.Drawing.Point(119, 43);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(71, 21);
            this.txtSerie.TabIndex = 56;
            this.txtSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_recibocabecera
            // 
            this.id_recibocabecera.DataPropertyName = "id_recibocabecera";
            this.id_recibocabecera.HeaderText = "id_recibocabecera";
            this.id_recibocabecera.Name = "id_recibocabecera";
            this.id_recibocabecera.ReadOnly = true;
            this.id_recibocabecera.Visible = false;
            // 
            // id_movimiento
            // 
            this.id_movimiento.DataPropertyName = "id_movimiento";
            this.id_movimiento.HeaderText = "id_movimiento";
            this.id_movimiento.Name = "id_movimiento";
            this.id_movimiento.ReadOnly = true;
            this.id_movimiento.Visible = false;
            // 
            // numero_movimiento
            // 
            this.numero_movimiento.DataPropertyName = "numero_movimiento";
            this.numero_movimiento.HeaderText = "numero_movimiento";
            this.numero_movimiento.Name = "numero_movimiento";
            this.numero_movimiento.ReadOnly = true;
            this.numero_movimiento.Visible = false;
            // 
            // id_tiporubro
            // 
            this.id_tiporubro.DataPropertyName = "id_tiporubro";
            this.id_tiporubro.HeaderText = "id_tiporubro";
            this.id_tiporubro.Name = "id_tiporubro";
            this.id_tiporubro.ReadOnly = true;
            this.id_tiporubro.Visible = false;
            // 
            // descripcion_tiporubro
            // 
            this.descripcion_tiporubro.DataPropertyName = "descripcion_tiporubro";
            this.descripcion_tiporubro.HeaderText = "descripcion_tiporubro";
            this.descripcion_tiporubro.Name = "descripcion_tiporubro";
            this.descripcion_tiporubro.ReadOnly = true;
            this.descripcion_tiporubro.Visible = false;
            // 
            // id_Recibo
            // 
            this.id_Recibo.DataPropertyName = "id_Recibo";
            this.id_Recibo.HeaderText = "id_Recibo";
            this.id_Recibo.Name = "id_Recibo";
            this.id_Recibo.ReadOnly = true;
            this.id_Recibo.Visible = false;
            // 
            // numero_recibo
            // 
            this.numero_recibo.DataPropertyName = "numero_recibo";
            this.numero_recibo.HeaderText = "numero_recibo";
            this.numero_recibo.Name = "numero_recibo";
            this.numero_recibo.ReadOnly = true;
            this.numero_recibo.Visible = false;
            // 
            // id_agencia
            // 
            this.id_agencia.DataPropertyName = "id_agencia";
            this.id_agencia.HeaderText = "id_agencia";
            this.id_agencia.Name = "id_agencia";
            this.id_agencia.ReadOnly = true;
            this.id_agencia.Visible = false;
            // 
            // nombre_agencia
            // 
            this.nombre_agencia.DataPropertyName = "nombre_agencia";
            this.nombre_agencia.HeaderText = "nombre_agencia";
            this.nombre_agencia.Name = "nombre_agencia";
            this.nombre_agencia.ReadOnly = true;
            this.nombre_agencia.Visible = false;
            // 
            // fecharecibo_recibocabecera
            // 
            this.fecharecibo_recibocabecera.DataPropertyName = "fecharecibo_recibocabecera";
            this.fecharecibo_recibocabecera.HeaderText = "fecharecibo_recibocabecera";
            this.fecharecibo_recibocabecera.Name = "fecharecibo_recibocabecera";
            this.fecharecibo_recibocabecera.ReadOnly = true;
            this.fecharecibo_recibocabecera.Visible = false;
            // 
            // total_recibocabecera
            // 
            this.total_recibocabecera.DataPropertyName = "total_recibocabecera";
            this.total_recibocabecera.HeaderText = "total_recibocabecera";
            this.total_recibocabecera.Name = "total_recibocabecera";
            this.total_recibocabecera.ReadOnly = true;
            this.total_recibocabecera.Visible = false;
            // 
            // observacion_recibocabecera
            // 
            this.observacion_recibocabecera.DataPropertyName = "observacion_recibocabecera";
            this.observacion_recibocabecera.HeaderText = "observacion_recibocabecera";
            this.observacion_recibocabecera.Name = "observacion_recibocabecera";
            this.observacion_recibocabecera.ReadOnly = true;
            this.observacion_recibocabecera.Visible = false;
            // 
            // id_usuario_caja
            // 
            this.id_usuario_caja.DataPropertyName = "id_usuario_caja";
            this.id_usuario_caja.HeaderText = "id_usuario_caja";
            this.id_usuario_caja.Name = "id_usuario_caja";
            this.id_usuario_caja.ReadOnly = true;
            this.id_usuario_caja.Visible = false;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.DataPropertyName = "nombre_usuario";
            this.nombre_usuario.HeaderText = "nombre_usuario";
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.ReadOnly = true;
            this.nombre_usuario.Visible = false;
            // 
            // estado_recibocabecera
            // 
            this.estado_recibocabecera.DataPropertyName = "estado_recibocabecera";
            this.estado_recibocabecera.HeaderText = "estado_recibocabecera";
            this.estado_recibocabecera.Name = "estado_recibocabecera";
            this.estado_recibocabecera.ReadOnly = true;
            this.estado_recibocabecera.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // item_recibodetalle
            // 
            this.item_recibodetalle.DataPropertyName = "item_recibodetalle";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "0";
            dataGridViewCellStyle2.NullValue = "0";
            this.item_recibodetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.item_recibodetalle.HeaderText = "item";
            this.item_recibodetalle.Name = "item_recibodetalle";
            this.item_recibodetalle.ReadOnly = true;
            this.item_recibodetalle.Width = 50;
            // 
            // idpagina
            // 
            this.idpagina.DataPropertyName = "idpagina";
            this.idpagina.HeaderText = "idpagina";
            this.idpagina.Name = "idpagina";
            this.idpagina.ReadOnly = true;
            this.idpagina.Visible = false;
            // 
            // recibo
            // 
            this.recibo.DataPropertyName = "recibo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.recibo.DefaultCellStyle = dataGridViewCellStyle3;
            this.recibo.HeaderText = "Nº Recibo";
            this.recibo.Name = "recibo";
            this.recibo.ReadOnly = true;
            // 
            // id_rubros
            // 
            this.id_rubros.DataPropertyName = "id_rubros";
            this.id_rubros.HeaderText = "id_rubros";
            this.id_rubros.Name = "id_rubros";
            this.id_rubros.ReadOnly = true;
            this.id_rubros.Visible = false;
            // 
            // precio_recibodetalle
            // 
            this.precio_recibodetalle.DataPropertyName = "precio_recibodetalle";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.precio_recibodetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.precio_recibodetalle.HeaderText = "Precio";
            this.precio_recibodetalle.Name = "precio_recibodetalle";
            this.precio_recibodetalle.ReadOnly = true;
            this.precio_recibodetalle.Visible = false;
            this.precio_recibodetalle.Width = 90;
            // 
            // cantidad_recibodetalle
            // 
            this.cantidad_recibodetalle.DataPropertyName = "cantidad_recibodetalle";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.cantidad_recibodetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidad_recibodetalle.HeaderText = "Cantidad";
            this.cantidad_recibodetalle.Name = "cantidad_recibodetalle";
            this.cantidad_recibodetalle.ReadOnly = true;
            this.cantidad_recibodetalle.Visible = false;
            this.cantidad_recibodetalle.Width = 90;
            // 
            // total_recibodetalle
            // 
            this.total_recibodetalle.DataPropertyName = "total_recibodetalle";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "0";
            this.total_recibodetalle.DefaultCellStyle = dataGridViewCellStyle6;
            this.total_recibodetalle.HeaderText = "Importe";
            this.total_recibodetalle.Name = "total_recibodetalle";
            this.total_recibodetalle.ReadOnly = true;
            this.total_recibodetalle.Visible = false;
            this.total_recibodetalle.Width = 90;
            // 
            // numero_movimiento1
            // 
            this.numero_movimiento1.DataPropertyName = "numero_movimiento1";
            this.numero_movimiento1.HeaderText = "numero_movimiento";
            this.numero_movimiento1.Name = "numero_movimiento1";
            this.numero_movimiento1.ReadOnly = true;
            this.numero_movimiento1.Visible = false;
            // 
            // frmDetalleRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 411);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GBDatosContribuyente);
            this.Controls.Add(this.GroupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetalleRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...:::Detalle Documento:::...";
            this.GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCtaCteImpuestos)).EndInit();
            this.GBDatosContribuyente.ResumeLayout(false);
            this.GBDatosContribuyente.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button BtnSalir;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DataGridView DGVCtaCteImpuestos;
        internal System.Windows.Forms.TextBox TxtFechaInicio;
        internal System.Windows.Forms.Label LblFechaInicio;
        internal System.Windows.Forms.Label LblTitulo;
        internal System.Windows.Forms.TextBox TxtNumeroDoc;
        internal System.Windows.Forms.Label LblNumeroRecibo;
        internal System.Windows.Forms.GroupBox GBDatosContribuyente;
        internal System.Windows.Forms.TextBox TxtNombreContribuyente;
        internal System.Windows.Forms.Label LblContribuyente;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_recibocabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_movimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tiporubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion_tiporubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_agencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharecibo_recibocabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_recibocabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion_recibocabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_recibocabecera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_rubros;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_recibodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_movimiento1;
    }
}