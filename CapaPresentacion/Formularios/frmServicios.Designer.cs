namespace CapaPresentacion.Formularios
{
   partial class frmServicios
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
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.cmbServicios = new System.Windows.Forms.ComboBox();
         this.dtgvTipoServicios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.idS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.idTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Serv = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Tipo_de_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.EstadoTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnServicio = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnTipoS = new Bunifu.Framework.UI.BunifuThinButton2();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.pnTS = new System.Windows.Forms.Panel();
         this.cmbEstadoTS = new System.Windows.Forms.ComboBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtDuracionTS = new System.Windows.Forms.MaskedTextBox();
         this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtObservacionTS = new System.Windows.Forms.TextBox();
         this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtNombreTS = new System.Windows.Forms.TextBox();
         this.cmbServPn = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnExpandir = new System.Windows.Forms.Button();
         this.btnMinimizar = new System.Windows.Forms.Button();
         this.dtgvServicios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.idServic = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.pnS = new System.Windows.Forms.Panel();
         this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
         this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
         this.label3 = new System.Windows.Forms.Label();
         this.cmbEstado = new System.Windows.Forms.ComboBox();
         this.txtNombreServicio = new System.Windows.Forms.TextBox();
         this.txtObservacionServicio = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTipoServicios)).BeginInit();
         this.pnTS.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).BeginInit();
         this.pnS.SuspendLayout();
         this.SuspendLayout();
         // 
         // cmbServicios
         // 
         this.cmbServicios.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.cmbServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbServicios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbServicios.FormattingEnabled = true;
         this.cmbServicios.Location = new System.Drawing.Point(12, 17);
         this.cmbServicios.Name = "cmbServicios";
         this.cmbServicios.Size = new System.Drawing.Size(199, 28);
         this.cmbServicios.TabIndex = 1;
         this.cmbServicios.DropDownClosed += new System.EventHandler(this.cmbServicios_DropDownClosed);
         this.cmbServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbServicios_KeyPress);
         // 
         // dtgvTipoServicios
         // 
         this.dtgvTipoServicios.AllowUserToAddRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvTipoServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.dtgvTipoServicios.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvTipoServicios.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvTipoServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvTipoServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvTipoServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dtgvTipoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvTipoServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idS,
            this.idTS,
            this.Serv,
            this.Tipo_de_Servicio,
            this.Duracion,
            this.Precio,
            this.Detalle,
            this.EstadoTS});
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvTipoServicios.DefaultCellStyle = dataGridViewCellStyle3;
         this.dtgvTipoServicios.DoubleBuffered = true;
         this.dtgvTipoServicios.EnableHeadersVisualStyles = false;
         this.dtgvTipoServicios.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvTipoServicios.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvTipoServicios.Location = new System.Drawing.Point(12, 92);
         this.dtgvTipoServicios.Name = "dtgvTipoServicios";
         this.dtgvTipoServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvTipoServicios.Size = new System.Drawing.Size(882, 481);
         this.dtgvTipoServicios.TabIndex = 20;
         // 
         // idS
         // 
         this.idS.HeaderText = "idS";
         this.idS.Name = "idS";
         this.idS.ReadOnly = true;
         this.idS.Visible = false;
         // 
         // idTS
         // 
         this.idTS.HeaderText = "idTS";
         this.idTS.Name = "idTS";
         this.idTS.ReadOnly = true;
         this.idTS.Visible = false;
         // 
         // Serv
         // 
         this.Serv.HeaderText = "Servicio";
         this.Serv.Name = "Serv";
         this.Serv.ReadOnly = true;
         this.Serv.Width = 120;
         // 
         // Tipo_de_Servicio
         // 
         this.Tipo_de_Servicio.HeaderText = "Tipo de Servicio";
         this.Tipo_de_Servicio.Name = "Tipo_de_Servicio";
         this.Tipo_de_Servicio.ReadOnly = true;
         this.Tipo_de_Servicio.Width = 200;
         // 
         // Duracion
         // 
         this.Duracion.HeaderText = "Duración Promedio";
         this.Duracion.Name = "Duracion";
         this.Duracion.ReadOnly = true;
         this.Duracion.Width = 190;
         // 
         // Precio
         // 
         this.Precio.HeaderText = "Precio";
         this.Precio.Name = "Precio";
         this.Precio.ReadOnly = true;
         // 
         // Detalle
         // 
         this.Detalle.HeaderText = "Observación";
         this.Detalle.Name = "Detalle";
         this.Detalle.ReadOnly = true;
         this.Detalle.Width = 400;
         // 
         // EstadoTS
         // 
         this.EstadoTS.HeaderText = "Estado";
         this.EstadoTS.Name = "EstadoTS";
         this.EstadoTS.ReadOnly = true;
         this.EstadoTS.Width = 120;
         // 
         // btnServicio
         // 
         this.btnServicio.ActiveBorderThickness = 1;
         this.btnServicio.ActiveCornerRadius = 10;
         this.btnServicio.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnServicio.ActiveForecolor = System.Drawing.Color.White;
         this.btnServicio.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnServicio.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnServicio.BackColor = System.Drawing.Color.White;
         this.btnServicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnServicio.BackgroundImage")));
         this.btnServicio.ButtonText = "Editar Servicio";
         this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnServicio.IdleBorderThickness = 1;
         this.btnServicio.IdleCornerRadius = 20;
         this.btnServicio.IdleFillColor = System.Drawing.Color.White;
         this.btnServicio.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnServicio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnServicio.Location = new System.Drawing.Point(472, 9);
         this.btnServicio.Margin = new System.Windows.Forms.Padding(5);
         this.btnServicio.Name = "btnServicio";
         this.btnServicio.Size = new System.Drawing.Size(181, 41);
         this.btnServicio.TabIndex = 21;
         this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
         // 
         // btnTipoS
         // 
         this.btnTipoS.ActiveBorderThickness = 1;
         this.btnTipoS.ActiveCornerRadius = 10;
         this.btnTipoS.ActiveFillColor = System.Drawing.Color.SteelBlue;
         this.btnTipoS.ActiveForecolor = System.Drawing.Color.White;
         this.btnTipoS.ActiveLineColor = System.Drawing.Color.SteelBlue;
         this.btnTipoS.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnTipoS.BackColor = System.Drawing.Color.White;
         this.btnTipoS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTipoS.BackgroundImage")));
         this.btnTipoS.ButtonText = "Editar Tipo de Servicio";
         this.btnTipoS.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnTipoS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnTipoS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnTipoS.IdleBorderThickness = 1;
         this.btnTipoS.IdleCornerRadius = 20;
         this.btnTipoS.IdleFillColor = System.Drawing.Color.White;
         this.btnTipoS.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnTipoS.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnTipoS.Location = new System.Drawing.Point(679, 9);
         this.btnTipoS.Margin = new System.Windows.Forms.Padding(5);
         this.btnTipoS.Name = "btnTipoS";
         this.btnTipoS.Size = new System.Drawing.Size(213, 41);
         this.btnTipoS.TabIndex = 23;
         this.btnTipoS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnTipoS.Click += new System.EventHandler(this.btnTipoS_Click);
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator2.LineThickness = 3;
         this.bunifuSeparator2.Location = new System.Drawing.Point(661, 9);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(10, 43);
         this.bunifuSeparator2.TabIndex = 24;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = true;
         // 
         // pnTS
         // 
         this.pnTS.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.pnTS.BackColor = System.Drawing.Color.Gainsboro;
         this.pnTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pnTS.Controls.Add(this.cmbEstadoTS);
         this.pnTS.Controls.Add(this.label4);
         this.pnTS.Controls.Add(this.label2);
         this.pnTS.Controls.Add(this.bunifuSeparator6);
         this.pnTS.Controls.Add(this.txtDuracionTS);
         this.pnTS.Controls.Add(this.bunifuSeparator5);
         this.pnTS.Controls.Add(this.txtObservacionTS);
         this.pnTS.Controls.Add(this.bunifuSeparator4);
         this.pnTS.Controls.Add(this.txtPrecio);
         this.pnTS.Controls.Add(this.bunifuSeparator3);
         this.pnTS.Controls.Add(this.txtNombreTS);
         this.pnTS.Controls.Add(this.cmbServPn);
         this.pnTS.Controls.Add(this.label1);
         this.pnTS.Location = new System.Drawing.Point(12, 403);
         this.pnTS.Name = "pnTS";
         this.pnTS.Size = new System.Drawing.Size(355, 169);
         this.pnTS.TabIndex = 25;
         this.pnTS.Visible = false;
         // 
         // cmbEstadoTS
         // 
         this.cmbEstadoTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbEstadoTS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbEstadoTS.FormattingEnabled = true;
         this.cmbEstadoTS.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
         this.cmbEstadoTS.Location = new System.Drawing.Point(213, 62);
         this.cmbEstadoTS.Name = "cmbEstadoTS";
         this.cmbEstadoTS.Size = new System.Drawing.Size(135, 25);
         this.cmbEstadoTS.TabIndex = 36;
         this.toolTip1.SetToolTip(this.cmbEstadoTS, "Estado");
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label4.Location = new System.Drawing.Point(210, 42);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(56, 17);
         this.label4.TabIndex = 35;
         this.label4.Text = "Estado:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label2.Location = new System.Drawing.Point(210, 120);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 17);
         this.label2.TabIndex = 34;
         this.label2.Text = "Duración";
         // 
         // bunifuSeparator6
         // 
         this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator6.LineThickness = 3;
         this.bunifuSeparator6.Location = new System.Drawing.Point(213, 138);
         this.bunifuSeparator6.Name = "bunifuSeparator6";
         this.bunifuSeparator6.Size = new System.Drawing.Size(131, 15);
         this.bunifuSeparator6.TabIndex = 33;
         this.bunifuSeparator6.Transparency = 255;
         this.bunifuSeparator6.Vertical = false;
         // 
         // txtDuracionTS
         // 
         this.txtDuracionTS.BackColor = System.Drawing.Color.Gainsboro;
         this.txtDuracionTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDuracionTS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDuracionTS.Location = new System.Drawing.Point(283, 121);
         this.txtDuracionTS.Mask = "00:00";
         this.txtDuracionTS.Name = "txtDuracionTS";
         this.txtDuracionTS.Size = new System.Drawing.Size(35, 16);
         this.txtDuracionTS.TabIndex = 32;
         this.toolTip1.SetToolTip(this.txtDuracionTS, "Duración aproximada de un tipo de servicio");
         this.txtDuracionTS.ValidatingType = typeof(System.DateTime);
         // 
         // bunifuSeparator5
         // 
         this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator5.LineThickness = 3;
         this.bunifuSeparator5.Location = new System.Drawing.Point(8, 138);
         this.bunifuSeparator5.Name = "bunifuSeparator5";
         this.bunifuSeparator5.Size = new System.Drawing.Size(189, 15);
         this.bunifuSeparator5.TabIndex = 31;
         this.bunifuSeparator5.Transparency = 255;
         this.bunifuSeparator5.Vertical = false;
         // 
         // txtObservacionTS
         // 
         this.txtObservacionTS.BackColor = System.Drawing.Color.Gainsboro;
         this.txtObservacionTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtObservacionTS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtObservacionTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtObservacionTS.Location = new System.Drawing.Point(8, 120);
         this.txtObservacionTS.Name = "txtObservacionTS";
         this.txtObservacionTS.Size = new System.Drawing.Size(192, 16);
         this.txtObservacionTS.TabIndex = 30;
         this.txtObservacionTS.Text = "Observación";
         this.toolTip1.SetToolTip(this.txtObservacionTS, "Observación");
         this.txtObservacionTS.Click += new System.EventHandler(this.txtNombreTS_Click);
         this.txtObservacionTS.Leave += new System.EventHandler(this.txtNombreTS_Leave);
         // 
         // bunifuSeparator4
         // 
         this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator4.LineThickness = 3;
         this.bunifuSeparator4.Location = new System.Drawing.Point(8, 99);
         this.bunifuSeparator4.Name = "bunifuSeparator4";
         this.bunifuSeparator4.Size = new System.Drawing.Size(189, 15);
         this.bunifuSeparator4.TabIndex = 29;
         this.bunifuSeparator4.Transparency = 255;
         this.bunifuSeparator4.Vertical = false;
         // 
         // txtPrecio
         // 
         this.txtPrecio.BackColor = System.Drawing.Color.Gainsboro;
         this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtPrecio.Location = new System.Drawing.Point(8, 81);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.Size = new System.Drawing.Size(192, 16);
         this.txtPrecio.TabIndex = 28;
         this.txtPrecio.Text = "Precio";
         this.toolTip1.SetToolTip(this.txtPrecio, "Precio");
         this.txtPrecio.Click += new System.EventHandler(this.txtNombreTS_Click);
         this.txtPrecio.Leave += new System.EventHandler(this.txtNombreTS_Leave);
         // 
         // bunifuSeparator3
         // 
         this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator3.LineThickness = 3;
         this.bunifuSeparator3.Location = new System.Drawing.Point(8, 60);
         this.bunifuSeparator3.Name = "bunifuSeparator3";
         this.bunifuSeparator3.Size = new System.Drawing.Size(189, 15);
         this.bunifuSeparator3.TabIndex = 27;
         this.bunifuSeparator3.Transparency = 255;
         this.bunifuSeparator3.Vertical = false;
         // 
         // txtNombreTS
         // 
         this.txtNombreTS.BackColor = System.Drawing.Color.Gainsboro;
         this.txtNombreTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombreTS.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombreTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtNombreTS.Location = new System.Drawing.Point(8, 42);
         this.txtNombreTS.Name = "txtNombreTS";
         this.txtNombreTS.Size = new System.Drawing.Size(192, 16);
         this.txtNombreTS.TabIndex = 26;
         this.txtNombreTS.Text = "Nombre";
         this.toolTip1.SetToolTip(this.txtNombreTS, "Nombre de tipo de servicio");
         this.txtNombreTS.Click += new System.EventHandler(this.txtNombreTS_Click);
         this.txtNombreTS.Leave += new System.EventHandler(this.txtNombreTS_Leave);
         // 
         // cmbServPn
         // 
         this.cmbServPn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbServPn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbServPn.FormattingEnabled = true;
         this.cmbServPn.Location = new System.Drawing.Point(66, 8);
         this.cmbServPn.Name = "cmbServPn";
         this.cmbServPn.Size = new System.Drawing.Size(131, 25);
         this.cmbServPn.TabIndex = 4;
         this.toolTip1.SetToolTip(this.cmbServPn, "Nombre de servicio");
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label1.Location = new System.Drawing.Point(3, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(61, 17);
         this.label1.TabIndex = 0;
         this.label1.Text = "Servicio:";
         // 
         // btnGuardar
         // 
         this.btnGuardar.ActiveBorderThickness = 1;
         this.btnGuardar.ActiveCornerRadius = 10;
         this.btnGuardar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
         this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
         this.btnGuardar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
         this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnGuardar.BackColor = System.Drawing.Color.White;
         this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
         this.btnGuardar.ButtonText = "Guardar";
         this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnGuardar.IdleBorderThickness = 1;
         this.btnGuardar.IdleCornerRadius = 20;
         this.btnGuardar.IdleFillColor = System.Drawing.Color.White;
         this.btnGuardar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnGuardar.Location = new System.Drawing.Point(375, 486);
         this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(181, 41);
         this.btnGuardar.TabIndex = 30;
         this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnGuardar.Visible = false;
         this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
         // 
         // btnEditar
         // 
         this.btnEditar.ActiveBorderThickness = 1;
         this.btnEditar.ActiveCornerRadius = 10;
         this.btnEditar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
         this.btnEditar.ActiveForecolor = System.Drawing.Color.White;
         this.btnEditar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
         this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnEditar.BackColor = System.Drawing.Color.White;
         this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
         this.btnEditar.ButtonText = "Editar";
         this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEditar.IdleBorderThickness = 1;
         this.btnEditar.IdleCornerRadius = 20;
         this.btnEditar.IdleFillColor = System.Drawing.Color.White;
         this.btnEditar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEditar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEditar.Location = new System.Drawing.Point(375, 487);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(181, 41);
         this.btnEditar.TabIndex = 29;
         this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEditar.Visible = false;
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
         // 
         // btnEliminar
         // 
         this.btnEliminar.ActiveBorderThickness = 1;
         this.btnEliminar.ActiveCornerRadius = 10;
         this.btnEliminar.ActiveFillColor = System.Drawing.Color.Red;
         this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
         this.btnEliminar.ActiveLineColor = System.Drawing.Color.Red;
         this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnEliminar.BackColor = System.Drawing.Color.White;
         this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
         this.btnEliminar.ButtonText = "Eliminar";
         this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.IdleBorderThickness = 1;
         this.btnEliminar.IdleCornerRadius = 20;
         this.btnEliminar.IdleFillColor = System.Drawing.Color.White;
         this.btnEliminar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.Location = new System.Drawing.Point(375, 446);
         this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(181, 41);
         this.btnEliminar.TabIndex = 28;
         this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEliminar.Visible = false;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // btnAgregar
         // 
         this.btnAgregar.ActiveBorderThickness = 1;
         this.btnAgregar.ActiveCornerRadius = 10;
         this.btnAgregar.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
         this.btnAgregar.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnAgregar.BackColor = System.Drawing.Color.White;
         this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
         this.btnAgregar.ButtonText = "Agregar";
         this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleBorderThickness = 1;
         this.btnAgregar.IdleCornerRadius = 20;
         this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
         this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.Location = new System.Drawing.Point(375, 405);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(181, 41);
         this.btnAgregar.TabIndex = 27;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnAgregar.Visible = false;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnCancelar
         // 
         this.btnCancelar.ActiveBorderThickness = 1;
         this.btnCancelar.ActiveCornerRadius = 10;
         this.btnCancelar.ActiveFillColor = System.Drawing.Color.OrangeRed;
         this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
         this.btnCancelar.ActiveLineColor = System.Drawing.Color.OrangeRed;
         this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnCancelar.BackColor = System.Drawing.Color.White;
         this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
         this.btnCancelar.ButtonText = "Cancelar";
         this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCancelar.IdleBorderThickness = 1;
         this.btnCancelar.IdleCornerRadius = 20;
         this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
         this.btnCancelar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCancelar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCancelar.Location = new System.Drawing.Point(375, 528);
         this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(181, 41);
         this.btnCancelar.TabIndex = 31;
         this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnCancelar.Visible = false;
         this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
         // 
         // btnExpandir
         // 
         this.btnExpandir.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnExpandir.FlatAppearance.BorderSize = 0;
         this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
         this.btnExpandir.Location = new System.Drawing.Point(848, 57);
         this.btnExpandir.Name = "btnExpandir";
         this.btnExpandir.Size = new System.Drawing.Size(46, 29);
         this.btnExpandir.TabIndex = 32;
         this.btnExpandir.UseVisualStyleBackColor = true;
         this.btnExpandir.Visible = false;
         this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
         // 
         // btnMinimizar
         // 
         this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnMinimizar.FlatAppearance.BorderSize = 0;
         this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
         this.btnMinimizar.Location = new System.Drawing.Point(848, 57);
         this.btnMinimizar.Name = "btnMinimizar";
         this.btnMinimizar.Size = new System.Drawing.Size(46, 29);
         this.btnMinimizar.TabIndex = 33;
         this.btnMinimizar.UseVisualStyleBackColor = true;
         this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
         // 
         // dtgvServicios
         // 
         this.dtgvServicios.AllowUserToAddRows = false;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dtgvServicios.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvServicios.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
         this.dtgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServic,
            this.Nombre,
            this.Observacion,
            this.Estado});
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvServicios.DefaultCellStyle = dataGridViewCellStyle6;
         this.dtgvServicios.DoubleBuffered = true;
         this.dtgvServicios.EnableHeadersVisualStyles = false;
         this.dtgvServicios.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvServicios.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvServicios.Location = new System.Drawing.Point(12, 92);
         this.dtgvServicios.Name = "dtgvServicios";
         this.dtgvServicios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvServicios.Size = new System.Drawing.Size(882, 481);
         this.dtgvServicios.TabIndex = 34;
         this.dtgvServicios.Visible = false;
         // 
         // idServic
         // 
         this.idServic.HeaderText = "idS";
         this.idServic.Name = "idServic";
         this.idServic.ReadOnly = true;
         this.idServic.Visible = false;
         // 
         // Nombre
         // 
         this.Nombre.HeaderText = "Nombre";
         this.Nombre.Name = "Nombre";
         this.Nombre.ReadOnly = true;
         this.Nombre.Width = 300;
         // 
         // Observacion
         // 
         this.Observacion.HeaderText = "Observación";
         this.Observacion.Name = "Observacion";
         this.Observacion.ReadOnly = true;
         this.Observacion.Width = 400;
         // 
         // Estado
         // 
         this.Estado.HeaderText = "Estado";
         this.Estado.Name = "Estado";
         this.Estado.ReadOnly = true;
         this.Estado.Width = 140;
         // 
         // pnS
         // 
         this.pnS.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.pnS.BackColor = System.Drawing.Color.Gainsboro;
         this.pnS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pnS.Controls.Add(this.cmbEstado);
         this.pnS.Controls.Add(this.label3);
         this.pnS.Controls.Add(this.bunifuSeparator1);
         this.pnS.Controls.Add(this.txtObservacionServicio);
         this.pnS.Controls.Add(this.bunifuSeparator7);
         this.pnS.Controls.Add(this.txtNombreServicio);
         this.pnS.Location = new System.Drawing.Point(564, 403);
         this.pnS.Name = "pnS";
         this.pnS.Size = new System.Drawing.Size(330, 169);
         this.pnS.TabIndex = 26;
         this.pnS.Visible = false;
         // 
         // bunifuSeparator7
         // 
         this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator7.LineThickness = 3;
         this.bunifuSeparator7.Location = new System.Drawing.Point(5, 26);
         this.bunifuSeparator7.Name = "bunifuSeparator7";
         this.bunifuSeparator7.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator7.TabIndex = 29;
         this.bunifuSeparator7.Transparency = 255;
         this.bunifuSeparator7.Vertical = false;
         // 
         // bunifuSeparator1
         // 
         this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
         this.bunifuSeparator1.LineThickness = 3;
         this.bunifuSeparator1.Location = new System.Drawing.Point(5, 65);
         this.bunifuSeparator1.Name = "bunifuSeparator1";
         this.bunifuSeparator1.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator1.TabIndex = 31;
         this.bunifuSeparator1.Transparency = 255;
         this.bunifuSeparator1.Vertical = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label3.Location = new System.Drawing.Point(3, 92);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(56, 17);
         this.label3.TabIndex = 32;
         this.label3.Text = "Estado:";
         // 
         // cmbEstado
         // 
         this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbEstado.FormattingEnabled = true;
         this.cmbEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
         this.cmbEstado.Location = new System.Drawing.Point(62, 88);
         this.cmbEstado.Name = "cmbEstado";
         this.cmbEstado.Size = new System.Drawing.Size(135, 25);
         this.cmbEstado.TabIndex = 33;
         this.toolTip1.SetToolTip(this.cmbEstado, "Estado");
         // 
         // txtNombreServicio
         // 
         this.txtNombreServicio.BackColor = System.Drawing.Color.Gainsboro;
         this.txtNombreServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombreServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombreServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtNombreServicio.Location = new System.Drawing.Point(5, 8);
         this.txtNombreServicio.Name = "txtNombreServicio";
         this.txtNombreServicio.Size = new System.Drawing.Size(192, 16);
         this.txtNombreServicio.TabIndex = 28;
         this.txtNombreServicio.Text = "Nombre";
         this.toolTip1.SetToolTip(this.txtNombreServicio, "Nombre de servicio");
         this.txtNombreServicio.Click += new System.EventHandler(this.txtNombreTS_Click);
         this.txtNombreServicio.Leave += new System.EventHandler(this.txtNombreTS_Leave);
         // 
         // txtObservacionServicio
         // 
         this.txtObservacionServicio.BackColor = System.Drawing.Color.Gainsboro;
         this.txtObservacionServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtObservacionServicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtObservacionServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtObservacionServicio.Location = new System.Drawing.Point(5, 47);
         this.txtObservacionServicio.Name = "txtObservacionServicio";
         this.txtObservacionServicio.Size = new System.Drawing.Size(192, 16);
         this.txtObservacionServicio.TabIndex = 30;
         this.txtObservacionServicio.Text = "Observación";
         this.toolTip1.SetToolTip(this.txtObservacionServicio, "Observación");
         this.txtObservacionServicio.Click += new System.EventHandler(this.txtNombreTS_Click);
         this.txtObservacionServicio.Leave += new System.EventHandler(this.txtNombreTS_Leave);
         // 
         // frmServicios
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(906, 585);
         this.Controls.Add(this.dtgvServicios);
         this.Controls.Add(this.btnMinimizar);
         this.Controls.Add(this.btnExpandir);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnGuardar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.pnS);
         this.Controls.Add(this.pnTS);
         this.Controls.Add(this.bunifuSeparator2);
         this.Controls.Add(this.btnTipoS);
         this.Controls.Add(this.btnServicio);
         this.Controls.Add(this.dtgvTipoServicios);
         this.Controls.Add(this.cmbServicios);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmServicios";
         this.Text = "frmServicios";
         this.Load += new System.EventHandler(this.frmServicios_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTipoServicios)).EndInit();
         this.pnTS.ResumeLayout(false);
         this.pnTS.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvServicios)).EndInit();
         this.pnS.ResumeLayout(false);
         this.pnS.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ComboBox cmbServicios;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTipoServicios;
      private Bunifu.Framework.UI.BunifuThinButton2 btnServicio;
      private Bunifu.Framework.UI.BunifuThinButton2 btnTipoS;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.Panel pnTS;
      private System.Windows.Forms.ComboBox cmbServPn;
      private System.Windows.Forms.Label label1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
      private System.Windows.Forms.TextBox txtNombreTS;
      private System.Windows.Forms.Label label2;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
      private System.Windows.Forms.MaskedTextBox txtDuracionTS;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
      private System.Windows.Forms.TextBox txtObservacionTS;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
      private System.Windows.Forms.TextBox txtPrecio;
      private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
      private System.Windows.Forms.Button btnExpandir;
      private System.Windows.Forms.Button btnMinimizar;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvServicios;
      private System.Windows.Forms.DataGridViewTextBoxColumn idServic;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
      private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
      private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.ComboBox cmbEstadoTS;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.DataGridViewTextBoxColumn idS;
      private System.Windows.Forms.DataGridViewTextBoxColumn idTS;
      private System.Windows.Forms.DataGridViewTextBoxColumn Serv;
      private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Servicio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
      private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
      private System.Windows.Forms.DataGridViewTextBoxColumn EstadoTS;
      private System.Windows.Forms.Panel pnS;
      private System.Windows.Forms.ComboBox cmbEstado;
      private System.Windows.Forms.Label label3;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
      private System.Windows.Forms.TextBox txtObservacionServicio;
      private System.Windows.Forms.TextBox txtNombreServicio;
   }
}