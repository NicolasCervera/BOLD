namespace CapaPresentacion.Formularios
{
   partial class frmCargo
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargo));
         this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtEstado = new System.Windows.Forms.TextBox();
         this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.dtgvCargo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.idC = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre_de_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Descripcion_de_Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvCargo)).BeginInit();
         this.SuspendLayout();
         // 
         // bunifuSeparator4
         // 
         this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator4.LineThickness = 3;
         this.bunifuSeparator4.Location = new System.Drawing.Point(12, 111);
         this.bunifuSeparator4.Name = "bunifuSeparator4";
         this.bunifuSeparator4.Size = new System.Drawing.Size(278, 15);
         this.bunifuSeparator4.TabIndex = 62;
         this.bunifuSeparator4.Transparency = 255;
         this.bunifuSeparator4.Vertical = false;
         // 
         // txtEstado
         // 
         this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEstado.ForeColor = System.Drawing.Color.Gray;
         this.txtEstado.Location = new System.Drawing.Point(12, 92);
         this.txtEstado.Name = "txtEstado";
         this.txtEstado.Size = new System.Drawing.Size(278, 19);
         this.txtEstado.TabIndex = 61;
         this.txtEstado.Text = "Estado";
         this.txtEstado.Click += new System.EventHandler(this.txtEstado_Click);
         this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
         // 
         // bunifuSeparator3
         // 
         this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator3.LineThickness = 3;
         this.bunifuSeparator3.Location = new System.Drawing.Point(12, 71);
         this.bunifuSeparator3.Name = "bunifuSeparator3";
         this.bunifuSeparator3.Size = new System.Drawing.Size(278, 15);
         this.bunifuSeparator3.TabIndex = 60;
         this.bunifuSeparator3.Transparency = 255;
         this.bunifuSeparator3.Vertical = false;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
         this.txtDescripcion.Location = new System.Drawing.Point(12, 52);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(278, 19);
         this.txtDescripcion.TabIndex = 59;
         this.txtDescripcion.Text = "Descripción";
         this.txtDescripcion.Click += new System.EventHandler(this.txtEstado_Click);
         this.txtDescripcion.Leave += new System.EventHandler(this.txtEstado_Leave);
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator2.LineThickness = 3;
         this.bunifuSeparator2.Location = new System.Drawing.Point(12, 31);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(278, 15);
         this.bunifuSeparator2.TabIndex = 58;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = false;
         // 
         // txtNombre
         // 
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.Gray;
         this.txtNombre.Location = new System.Drawing.Point(12, 12);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(278, 19);
         this.txtNombre.TabIndex = 57;
         this.txtNombre.Text = "Nombre";
         this.txtNombre.Click += new System.EventHandler(this.txtEstado_Click);
         this.txtNombre.Leave += new System.EventHandler(this.txtEstado_Leave);
         // 
         // dtgvCargo
         // 
         this.dtgvCargo.AllowUserToAddRows = false;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvCargo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.dtgvCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvCargo.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvCargo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvCargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.dtgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idC,
            this.Nombre_de_Cargo,
            this.Descripcion_de_Cargo,
            this.Estado});
         dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvCargo.DefaultCellStyle = dataGridViewCellStyle3;
         this.dtgvCargo.DoubleBuffered = true;
         this.dtgvCargo.EnableHeadersVisualStyles = false;
         this.dtgvCargo.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvCargo.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvCargo.Location = new System.Drawing.Point(12, 147);
         this.dtgvCargo.Name = "dtgvCargo";
         this.dtgvCargo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvCargo.Size = new System.Drawing.Size(890, 404);
         this.dtgvCargo.TabIndex = 63;
         // 
         // idC
         // 
         this.idC.HeaderText = "idC";
         this.idC.Name = "idC";
         this.idC.ReadOnly = true;
         this.idC.Visible = false;
         // 
         // Nombre_de_Cargo
         // 
         this.Nombre_de_Cargo.HeaderText = "Nombre de Cargo";
         this.Nombre_de_Cargo.Name = "Nombre_de_Cargo";
         this.Nombre_de_Cargo.ReadOnly = true;
         this.Nombre_de_Cargo.Width = 300;
         // 
         // Descripcion_de_Cargo
         // 
         this.Descripcion_de_Cargo.HeaderText = "Descripcion de Cargo";
         this.Descripcion_de_Cargo.Name = "Descripcion_de_Cargo";
         this.Descripcion_de_Cargo.ReadOnly = true;
         this.Descripcion_de_Cargo.Width = 350;
         // 
         // Estado
         // 
         this.Estado.HeaderText = "Estado";
         this.Estado.Name = "Estado";
         this.Estado.ReadOnly = true;
         this.Estado.Width = 198;
         // 
         // btnGuardar
         // 
         this.btnGuardar.ActiveBorderThickness = 1;
         this.btnGuardar.ActiveCornerRadius = 10;
         this.btnGuardar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
         this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
         this.btnGuardar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
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
         this.btnGuardar.Location = new System.Drawing.Point(303, 45);
         this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(181, 41);
         this.btnGuardar.TabIndex = 66;
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
         this.btnEditar.Location = new System.Drawing.Point(303, 44);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(181, 41);
         this.btnEditar.TabIndex = 65;
         this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
         this.btnAgregar.ButtonText = "Agregar";
         this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleBorderThickness = 1;
         this.btnAgregar.IdleCornerRadius = 20;
         this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
         this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.Location = new System.Drawing.Point(303, 5);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(181, 41);
         this.btnAgregar.TabIndex = 64;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnEliminar
         // 
         this.btnEliminar.ActiveBorderThickness = 1;
         this.btnEliminar.ActiveCornerRadius = 10;
         this.btnEliminar.ActiveFillColor = System.Drawing.Color.Red;
         this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
         this.btnEliminar.ActiveLineColor = System.Drawing.Color.Red;
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
         this.btnEliminar.Location = new System.Drawing.Point(303, 85);
         this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(181, 41);
         this.btnEliminar.TabIndex = 67;
         this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // frmCargo
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(914, 587);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnGuardar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.dtgvCargo);
         this.Controls.Add(this.bunifuSeparator4);
         this.Controls.Add(this.txtEstado);
         this.Controls.Add(this.bunifuSeparator3);
         this.Controls.Add(this.txtDescripcion);
         this.Controls.Add(this.bunifuSeparator2);
         this.Controls.Add(this.txtNombre);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmCargo";
         this.Text = "frmCargo";
         this.Load += new System.EventHandler(this.frmCargo_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvCargo)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
      private System.Windows.Forms.TextBox txtEstado;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
      private System.Windows.Forms.TextBox txtDescripcion;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.TextBox txtNombre;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvCargo;
      private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
      private System.Windows.Forms.DataGridViewTextBoxColumn idC;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_de_Cargo;
      private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_de_Cargo;
      private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
   }
}