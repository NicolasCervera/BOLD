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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicios));
         this.cmbServicios = new System.Windows.Forms.ComboBox();
         this.dtgvTipoServicios = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.idS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.idTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Tipo_de_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnServicio = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnTipoS = new Bunifu.Framework.UI.BunifuThinButton2();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.pnTS = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
         this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
         this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.cmbServPn = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.pnS = new System.Windows.Forms.Panel();
         this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
         this.textBox4 = new System.Windows.Forms.TextBox();
         this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnExpandir = new System.Windows.Forms.Button();
         this.btnMinimizar = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTipoServicios)).BeginInit();
         this.pnTS.SuspendLayout();
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
         this.cmbServicios.TabIndex = 0;
         // 
         // dtgvTipoServicios
         // 
         this.dtgvTipoServicios.AllowUserToAddRows = false;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvTipoServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dtgvTipoServicios.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvTipoServicios.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvTipoServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvTipoServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvTipoServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
         this.dtgvTipoServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvTipoServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idS,
            this.idTS,
            this.Tipo_de_Servicio,
            this.Duracion,
            this.Precio,
            this.Detalle});
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvTipoServicios.DefaultCellStyle = dataGridViewCellStyle6;
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
         this.pnTS.Controls.Add(this.label2);
         this.pnTS.Controls.Add(this.bunifuSeparator6);
         this.pnTS.Controls.Add(this.maskedTextBox1);
         this.pnTS.Controls.Add(this.bunifuSeparator5);
         this.pnTS.Controls.Add(this.textBox2);
         this.pnTS.Controls.Add(this.bunifuSeparator4);
         this.pnTS.Controls.Add(this.textBox1);
         this.pnTS.Controls.Add(this.bunifuSeparator3);
         this.pnTS.Controls.Add(this.txtNombre);
         this.pnTS.Controls.Add(this.cmbServPn);
         this.pnTS.Controls.Add(this.label1);
         this.pnTS.Location = new System.Drawing.Point(12, 403);
         this.pnTS.Name = "pnTS";
         this.pnTS.Size = new System.Drawing.Size(355, 169);
         this.pnTS.TabIndex = 25;
         this.pnTS.Visible = false;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.label2.Location = new System.Drawing.Point(236, 120);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 17);
         this.label2.TabIndex = 34;
         this.label2.Text = "Duración";
         // 
         // bunifuSeparator6
         // 
         this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator6.LineThickness = 3;
         this.bunifuSeparator6.Location = new System.Drawing.Point(239, 138);
         this.bunifuSeparator6.Name = "bunifuSeparator6";
         this.bunifuSeparator6.Size = new System.Drawing.Size(105, 15);
         this.bunifuSeparator6.TabIndex = 33;
         this.bunifuSeparator6.Transparency = 255;
         this.bunifuSeparator6.Vertical = false;
         // 
         // maskedTextBox1
         // 
         this.maskedTextBox1.BackColor = System.Drawing.Color.Gainsboro;
         this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.maskedTextBox1.Location = new System.Drawing.Point(309, 121);
         this.maskedTextBox1.Mask = "00:00";
         this.maskedTextBox1.Name = "maskedTextBox1";
         this.maskedTextBox1.Size = new System.Drawing.Size(35, 16);
         this.maskedTextBox1.TabIndex = 32;
         this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
         // 
         // bunifuSeparator5
         // 
         this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator5.LineThickness = 3;
         this.bunifuSeparator5.Location = new System.Drawing.Point(8, 138);
         this.bunifuSeparator5.Name = "bunifuSeparator5";
         this.bunifuSeparator5.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator5.TabIndex = 31;
         this.bunifuSeparator5.Transparency = 255;
         this.bunifuSeparator5.Vertical = false;
         // 
         // textBox2
         // 
         this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
         this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.textBox2.Location = new System.Drawing.Point(8, 120);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(192, 16);
         this.textBox2.TabIndex = 30;
         this.textBox2.Text = "Observación";
         // 
         // bunifuSeparator4
         // 
         this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator4.LineThickness = 3;
         this.bunifuSeparator4.Location = new System.Drawing.Point(8, 99);
         this.bunifuSeparator4.Name = "bunifuSeparator4";
         this.bunifuSeparator4.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator4.TabIndex = 29;
         this.bunifuSeparator4.Transparency = 255;
         this.bunifuSeparator4.Vertical = false;
         // 
         // textBox1
         // 
         this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.textBox1.Location = new System.Drawing.Point(8, 81);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(192, 16);
         this.textBox1.TabIndex = 28;
         this.textBox1.Text = "Precio";
         // 
         // bunifuSeparator3
         // 
         this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator3.LineThickness = 3;
         this.bunifuSeparator3.Location = new System.Drawing.Point(8, 60);
         this.bunifuSeparator3.Name = "bunifuSeparator3";
         this.bunifuSeparator3.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator3.TabIndex = 27;
         this.bunifuSeparator3.Transparency = 255;
         this.bunifuSeparator3.Vertical = false;
         // 
         // txtNombre
         // 
         this.txtNombre.BackColor = System.Drawing.Color.Gainsboro;
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtNombre.Location = new System.Drawing.Point(8, 42);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(192, 16);
         this.txtNombre.TabIndex = 26;
         this.txtNombre.Text = "Nombre";
         // 
         // cmbServPn
         // 
         this.cmbServPn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbServPn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbServPn.FormattingEnabled = true;
         this.cmbServPn.Location = new System.Drawing.Point(66, 8);
         this.cmbServPn.Name = "cmbServPn";
         this.cmbServPn.Size = new System.Drawing.Size(134, 25);
         this.cmbServPn.TabIndex = 4;
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
         // pnS
         // 
         this.pnS.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.pnS.BackColor = System.Drawing.Color.Gainsboro;
         this.pnS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.pnS.Controls.Add(this.bunifuSeparator1);
         this.pnS.Controls.Add(this.textBox4);
         this.pnS.Controls.Add(this.bunifuSeparator7);
         this.pnS.Controls.Add(this.textBox3);
         this.pnS.Location = new System.Drawing.Point(564, 403);
         this.pnS.Name = "pnS";
         this.pnS.Size = new System.Drawing.Size(330, 169);
         this.pnS.TabIndex = 26;
         this.pnS.Visible = false;
         // 
         // bunifuSeparator1
         // 
         this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator1.LineThickness = 3;
         this.bunifuSeparator1.Location = new System.Drawing.Point(5, 65);
         this.bunifuSeparator1.Name = "bunifuSeparator1";
         this.bunifuSeparator1.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator1.TabIndex = 31;
         this.bunifuSeparator1.Transparency = 255;
         this.bunifuSeparator1.Vertical = false;
         // 
         // textBox4
         // 
         this.textBox4.BackColor = System.Drawing.Color.Gainsboro;
         this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.textBox4.Location = new System.Drawing.Point(5, 47);
         this.textBox4.Name = "textBox4";
         this.textBox4.Size = new System.Drawing.Size(192, 16);
         this.textBox4.TabIndex = 30;
         this.textBox4.Text = "Observación";
         // 
         // bunifuSeparator7
         // 
         this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator7.LineThickness = 3;
         this.bunifuSeparator7.Location = new System.Drawing.Point(5, 26);
         this.bunifuSeparator7.Name = "bunifuSeparator7";
         this.bunifuSeparator7.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator7.TabIndex = 29;
         this.bunifuSeparator7.Transparency = 255;
         this.bunifuSeparator7.Vertical = false;
         // 
         // textBox3
         // 
         this.textBox3.BackColor = System.Drawing.Color.Gainsboro;
         this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.textBox3.Location = new System.Drawing.Point(5, 8);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(192, 16);
         this.textBox3.TabIndex = 28;
         this.textBox3.Text = "Nombre";
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
         this.btnCancelar.Location = new System.Drawing.Point(375, 529);
         this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(181, 41);
         this.btnCancelar.TabIndex = 31;
         this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnCancelar.Visible = false;
         // 
         // btnExpandir
         // 
         this.btnExpandir.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnExpandir.FlatAppearance.BorderSize = 0;
         this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
         this.btnExpandir.Location = new System.Drawing.Point(846, 57);
         this.btnExpandir.Name = "btnExpandir";
         this.btnExpandir.Size = new System.Drawing.Size(46, 29);
         this.btnExpandir.TabIndex = 32;
         this.btnExpandir.UseVisualStyleBackColor = true;
         this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
         // 
         // btnMinimizar
         // 
         this.btnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.btnMinimizar.FlatAppearance.BorderSize = 0;
         this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
         this.btnMinimizar.Location = new System.Drawing.Point(846, 57);
         this.btnMinimizar.Name = "btnMinimizar";
         this.btnMinimizar.Size = new System.Drawing.Size(46, 29);
         this.btnMinimizar.TabIndex = 33;
         this.btnMinimizar.UseVisualStyleBackColor = true;
         this.btnMinimizar.Visible = false;
         this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
         // 
         // frmServicios
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(906, 585);
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
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTipoServicios)).EndInit();
         this.pnTS.ResumeLayout(false);
         this.pnTS.PerformLayout();
         this.pnS.ResumeLayout(false);
         this.pnS.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ComboBox cmbServicios;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTipoServicios;
      private System.Windows.Forms.DataGridViewTextBoxColumn idS;
      private System.Windows.Forms.DataGridViewTextBoxColumn idTS;
      private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Servicio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
      private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
      private Bunifu.Framework.UI.BunifuThinButton2 btnServicio;
      private Bunifu.Framework.UI.BunifuThinButton2 btnTipoS;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.Panel pnTS;
      private System.Windows.Forms.Panel pnS;
      private System.Windows.Forms.ComboBox cmbServPn;
      private System.Windows.Forms.Label label1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.Label label2;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
      private System.Windows.Forms.MaskedTextBox maskedTextBox1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
      private System.Windows.Forms.TextBox textBox2;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
      private System.Windows.Forms.TextBox textBox1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
      private System.Windows.Forms.TextBox textBox3;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
      private System.Windows.Forms.TextBox textBox4;
      private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
      private System.Windows.Forms.Button btnExpandir;
      private System.Windows.Forms.Button btnMinimizar;
   }
}