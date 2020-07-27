namespace CapaPresentacion.Formularios
{
   partial class frmCaja
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaja));
         this.dtgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.IdClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.IdTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Tipo_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dtmFechaNac = new System.Windows.Forms.DateTimePicker();
         this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
         this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.SuspendLayout();
         // 
         // dtgvClientes
         // 
         this.dtgvClientes.AllowUserToAddRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.dtgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClie,
            this.IdTurn,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Telefono,
            this.Servicio,
            this.Tipo_servicio,
            this.Fecha,
            this.Hora,
            this.Total});
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
         this.dtgvClientes.DoubleBuffered = true;
         this.dtgvClientes.EnableHeadersVisualStyles = false;
         this.dtgvClientes.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvClientes.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvClientes.Location = new System.Drawing.Point(12, 22);
         this.dtgvClientes.Name = "dtgvClientes";
         this.dtgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvClientes.Size = new System.Drawing.Size(890, 430);
         this.dtgvClientes.TabIndex = 20;
         // 
         // IdClie
         // 
         this.IdClie.HeaderText = "IdClie";
         this.IdClie.Name = "IdClie";
         this.IdClie.ReadOnly = true;
         this.IdClie.Visible = false;
         // 
         // IdTurn
         // 
         this.IdTurn.HeaderText = "IdTurn";
         this.IdTurn.Name = "IdTurn";
         this.IdTurn.ReadOnly = true;
         this.IdTurn.Visible = false;
         // 
         // Nombre
         // 
         this.Nombre.HeaderText = "Nombre";
         this.Nombre.Name = "Nombre";
         this.Nombre.ReadOnly = true;
         this.Nombre.Width = 150;
         // 
         // Apellido
         // 
         this.Apellido.HeaderText = "Apellido";
         this.Apellido.Name = "Apellido";
         this.Apellido.ReadOnly = true;
         this.Apellido.Width = 150;
         // 
         // DNI
         // 
         this.DNI.HeaderText = "DNI";
         this.DNI.Name = "DNI";
         this.DNI.ReadOnly = true;
         this.DNI.Width = 150;
         // 
         // Telefono
         // 
         this.Telefono.HeaderText = "Teléfono";
         this.Telefono.Name = "Telefono";
         this.Telefono.ReadOnly = true;
         this.Telefono.Width = 150;
         // 
         // Servicio
         // 
         this.Servicio.HeaderText = "Servicio";
         this.Servicio.Name = "Servicio";
         this.Servicio.ReadOnly = true;
         // 
         // Tipo_servicio
         // 
         this.Tipo_servicio.HeaderText = "Tipo de Servicio";
         this.Tipo_servicio.Name = "Tipo_servicio";
         this.Tipo_servicio.ReadOnly = true;
         this.Tipo_servicio.Width = 200;
         // 
         // Fecha
         // 
         this.Fecha.HeaderText = "Fecha";
         this.Fecha.Name = "Fecha";
         this.Fecha.ReadOnly = true;
         // 
         // Hora
         // 
         this.Hora.HeaderText = "Hora";
         this.Hora.Name = "Hora";
         this.Hora.ReadOnly = true;
         // 
         // Total
         // 
         this.Total.HeaderText = "Total";
         this.Total.Name = "Total";
         this.Total.ReadOnly = true;
         // 
         // dtmFechaNac
         // 
         this.dtmFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtmFechaNac.Location = new System.Drawing.Point(80, 30);
         this.dtmFechaNac.MinDate = new System.DateTime(1773, 11, 12, 0, 0, 0, 0);
         this.dtmFechaNac.Name = "dtmFechaNac";
         this.dtmFechaNac.Size = new System.Drawing.Size(119, 26);
         this.dtmFechaNac.TabIndex = 26;
         // 
         // dateTimePicker1
         // 
         this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dateTimePicker1.Location = new System.Drawing.Point(80, 76);
         this.dateTimePicker1.MinDate = new System.DateTime(1773, 11, 12, 0, 0, 0, 0);
         this.dateTimePicker1.Name = "dateTimePicker1";
         this.dateTimePicker1.Size = new System.Drawing.Size(119, 26);
         this.dateTimePicker1.TabIndex = 27;
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Gray;
         this.label2.Location = new System.Drawing.Point(6, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(60, 20);
         this.label2.TabIndex = 28;
         this.label2.Text = "Desde:";
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Gray;
         this.label1.Location = new System.Drawing.Point(6, 79);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(54, 20);
         this.label1.TabIndex = 29;
         this.label1.Text = "Hasta:";
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gray;
         this.label3.Location = new System.Drawing.Point(226, 33);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(60, 20);
         this.label3.TabIndex = 30;
         this.label3.Text = "Desde:";
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.Gray;
         this.label4.Location = new System.Drawing.Point(226, 79);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(54, 20);
         this.label4.TabIndex = 31;
         this.label4.Text = "Hasta:";
         // 
         // maskedTextBox1
         // 
         this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.maskedTextBox1.ForeColor = System.Drawing.Color.Gray;
         this.maskedTextBox1.Location = new System.Drawing.Point(304, 34);
         this.maskedTextBox1.Mask = "00:00";
         this.maskedTextBox1.Name = "maskedTextBox1";
         this.maskedTextBox1.Size = new System.Drawing.Size(42, 19);
         this.maskedTextBox1.TabIndex = 32;
         this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
         // 
         // maskedTextBox2
         // 
         this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.maskedTextBox2.ForeColor = System.Drawing.Color.Gray;
         this.maskedTextBox2.Location = new System.Drawing.Point(304, 80);
         this.maskedTextBox2.Mask = "00:00";
         this.maskedTextBox2.Name = "maskedTextBox2";
         this.maskedTextBox2.Size = new System.Drawing.Size(42, 19);
         this.maskedTextBox2.TabIndex = 33;
         this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.btnAgregar);
         this.groupBox1.Controls.Add(this.maskedTextBox2);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.dtmFechaNac);
         this.groupBox1.Controls.Add(this.maskedTextBox1);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.dateTimePicker1);
         this.groupBox1.Controls.Add(this.label4);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.Gray;
         this.groupBox1.Location = new System.Drawing.Point(12, 458);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(482, 110);
         this.groupBox1.TabIndex = 35;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Filtro por fecha y hora:";
         // 
         // btnAgregar
         // 
         this.btnAgregar.ActiveBorderThickness = 1;
         this.btnAgregar.ActiveCornerRadius = 10;
         this.btnAgregar.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
         this.btnAgregar.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.BackColor = System.Drawing.Color.White;
         this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
         this.btnAgregar.ButtonText = "Buscar";
         this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleBorderThickness = 1;
         this.btnAgregar.IdleCornerRadius = 20;
         this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
         this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.Location = new System.Drawing.Point(354, 54);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(120, 41);
         this.btnAgregar.TabIndex = 37;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.bunifuSeparator1);
         this.groupBox2.Controls.Add(this.textBox1);
         this.groupBox2.Controls.Add(this.bunifuSeparator2);
         this.groupBox2.Controls.Add(this.txtNombre);
         this.groupBox2.Controls.Add(this.bunifuThinButton21);
         this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.ForeColor = System.Drawing.Color.Gray;
         this.groupBox2.Location = new System.Drawing.Point(500, 458);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(402, 110);
         this.groupBox2.TabIndex = 36;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Filtro por cliente:";
         // 
         // bunifuThinButton21
         // 
         this.bunifuThinButton21.ActiveBorderThickness = 1;
         this.bunifuThinButton21.ActiveCornerRadius = 10;
         this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkOrange;
         this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
         this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.DarkOrange;
         this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
         this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
         this.bunifuThinButton21.ButtonText = "Buscar";
         this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
         this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.bunifuThinButton21.IdleBorderThickness = 1;
         this.bunifuThinButton21.IdleCornerRadius = 20;
         this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
         this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.bunifuThinButton21.Location = new System.Drawing.Point(258, 52);
         this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
         this.bunifuThinButton21.Name = "bunifuThinButton21";
         this.bunifuThinButton21.Size = new System.Drawing.Size(120, 41);
         this.bunifuThinButton21.TabIndex = 37;
         this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator2.LineThickness = 5;
         this.bunifuSeparator2.Location = new System.Drawing.Point(7, 46);
         this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(242, 10);
         this.bunifuSeparator2.TabIndex = 39;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = false;
         // 
         // txtNombre
         // 
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.Gray;
         this.txtNombre.Location = new System.Drawing.Point(7, 25);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(242, 19);
         this.txtNombre.TabIndex = 38;
         this.txtNombre.Text = "Nombre";
         // 
         // textBox1
         // 
         this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.textBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBox1.ForeColor = System.Drawing.Color.Gray;
         this.textBox1.Location = new System.Drawing.Point(6, 67);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(242, 19);
         this.textBox1.TabIndex = 40;
         this.textBox1.Text = "DNI";
         // 
         // bunifuSeparator1
         // 
         this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator1.LineThickness = 5;
         this.bunifuSeparator1.Location = new System.Drawing.Point(7, 90);
         this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
         this.bunifuSeparator1.Name = "bunifuSeparator1";
         this.bunifuSeparator1.Size = new System.Drawing.Size(242, 10);
         this.bunifuSeparator1.TabIndex = 41;
         this.bunifuSeparator1.Transparency = 255;
         this.bunifuSeparator1.Vertical = false;
         // 
         // frmCaja
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(914, 587);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dtgvClientes);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmCaja";
         this.Text = "frmCaja";
         ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvClientes;
      private System.Windows.Forms.DataGridViewTextBoxColumn IdClie;
      private System.Windows.Forms.DataGridViewTextBoxColumn IdTurn;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
      private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
      private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
      private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
      private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_servicio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
      private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
      private System.Windows.Forms.DataGridViewTextBoxColumn Total;
      private System.Windows.Forms.DateTimePicker dtmFechaNac;
      private System.Windows.Forms.DateTimePicker dateTimePicker1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.MaskedTextBox maskedTextBox1;
      private System.Windows.Forms.MaskedTextBox maskedTextBox2;
      private System.Windows.Forms.GroupBox groupBox1;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
      private System.Windows.Forms.GroupBox groupBox2;
      private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.TextBox txtNombre;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
      private System.Windows.Forms.TextBox textBox1;
   }
}