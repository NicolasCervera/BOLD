namespace CapaPresentacion
{
  partial class frmClientes
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.swNocturno = new Bunifu.Framework.UI.BunifuSwitch();
         this.lblNoct = new System.Windows.Forms.Label();
         this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
         this.dtgvClientes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.IdClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Observación = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.txtBusqueda = new Bunifu.Framework.UI.BunifuTextbox();
         this.dtmFechaNac = new System.Windows.Forms.DateTimePicker();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtApellido = new System.Windows.Forms.TextBox();
         this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtDni = new System.Windows.Forms.TextBox();
         this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtTelefono = new System.Windows.Forms.TextBox();
         this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtObservacion = new System.Windows.Forms.TextBox();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Gray;
         this.label1.Location = new System.Drawing.Point(211, 100);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(25, 20);
         this.label1.TabIndex = 6;
         this.label1.Text = "(*)";
         this.toolTip1.SetToolTip(this.label1, "Campo Obligatorio.");
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Gray;
         this.label2.Location = new System.Drawing.Point(211, 143);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(25, 20);
         this.label2.TabIndex = 7;
         this.label2.Text = "(*)";
         this.toolTip1.SetToolTip(this.label2, "Campo Obligatorio.");
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gray;
         this.label3.Location = new System.Drawing.Point(211, 186);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(25, 20);
         this.label3.TabIndex = 8;
         this.label3.Text = "(*)";
         this.toolTip1.SetToolTip(this.label3, "Campo Obligatorio.");
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
         this.btnAgregar.Location = new System.Drawing.Point(12, 450);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(195, 41);
         this.btnAgregar.TabIndex = 11;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
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
         this.btnEliminar.Location = new System.Drawing.Point(12, 491);
         this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(195, 41);
         this.btnEliminar.TabIndex = 12;
         this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
         this.btnCancelar.Location = new System.Drawing.Point(705, 532);
         this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
         this.btnCancelar.Name = "btnCancelar";
         this.btnCancelar.Size = new System.Drawing.Size(195, 41);
         this.btnCancelar.TabIndex = 13;
         this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
         this.btnEditar.Location = new System.Drawing.Point(12, 532);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(195, 41);
         this.btnEditar.TabIndex = 14;
         this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
         this.btnGuardar.Location = new System.Drawing.Point(12, 532);
         this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(195, 41);
         this.btnGuardar.TabIndex = 15;
         this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnGuardar.Visible = false;
         this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
         // 
         // swNocturno
         // 
         this.swNocturno.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.swNocturno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.swNocturno.BorderRadius = 0;
         this.swNocturno.Cursor = System.Windows.Forms.Cursors.Hand;
         this.swNocturno.Enabled = false;
         this.swNocturno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.swNocturno.Location = new System.Drawing.Point(719, 18);
         this.swNocturno.Name = "swNocturno";
         this.swNocturno.Oncolor = System.Drawing.Color.LightSeaGreen;
         this.swNocturno.Onoffcolor = System.Drawing.Color.DarkGray;
         this.swNocturno.Size = new System.Drawing.Size(51, 19);
         this.swNocturno.TabIndex = 16;
         this.swNocturno.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
         this.swNocturno.Value = true;
         this.swNocturno.Click += new System.EventHandler(this.swNocturno_Click);
         // 
         // lblNoct
         // 
         this.lblNoct.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.lblNoct.AutoSize = true;
         this.lblNoct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNoct.ForeColor = System.Drawing.Color.Gray;
         this.lblNoct.Location = new System.Drawing.Point(773, 19);
         this.lblNoct.Name = "lblNoct";
         this.lblNoct.Size = new System.Drawing.Size(127, 20);
         this.lblNoct.TabIndex = 17;
         this.lblNoct.Text = "Modo Nocturno";
         // 
         // bunifuSeparator1
         // 
         this.bunifuSeparator1.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.bunifuSeparator1.LineThickness = 3;
         this.bunifuSeparator1.Location = new System.Drawing.Point(719, 43);
         this.bunifuSeparator1.Name = "bunifuSeparator1";
         this.bunifuSeparator1.Size = new System.Drawing.Size(178, 10);
         this.bunifuSeparator1.TabIndex = 18;
         this.bunifuSeparator1.Transparency = 255;
         this.bunifuSeparator1.Vertical = false;
         // 
         // dtgvClientes
         // 
         this.dtgvClientes.AllowUserToAddRows = false;
         dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
         this.dtgvClientes.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvClientes.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
         this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdClie,
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.E_mail,
            this.Edad,
            this.Observación,
            this.Telefono});
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvClientes.DefaultCellStyle = dataGridViewCellStyle6;
         this.dtgvClientes.DoubleBuffered = true;
         this.dtgvClientes.EnableHeadersVisualStyles = false;
         this.dtgvClientes.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvClientes.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvClientes.Location = new System.Drawing.Point(262, 18);
         this.dtgvClientes.Name = "dtgvClientes";
         this.dtgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvClientes.Size = new System.Drawing.Size(638, 496);
         this.dtgvClientes.TabIndex = 19;
         // 
         // IdClie
         // 
         this.IdClie.HeaderText = "IdClie";
         this.IdClie.Name = "IdClie";
         this.IdClie.ReadOnly = true;
         this.IdClie.Visible = false;
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
         // E_mail
         // 
         this.E_mail.HeaderText = "E-Mail";
         this.E_mail.Name = "E_mail";
         this.E_mail.ReadOnly = true;
         this.E_mail.Width = 150;
         // 
         // Edad
         // 
         this.Edad.HeaderText = "Fecha de Nacimiento";
         this.Edad.Name = "Edad";
         this.Edad.ReadOnly = true;
         this.Edad.Width = 210;
         // 
         // Observación
         // 
         this.Observación.HeaderText = "Observación";
         this.Observación.Name = "Observación";
         this.Observación.ReadOnly = true;
         this.Observación.Width = 200;
         // 
         // Telefono
         // 
         this.Telefono.HeaderText = "Teléfono";
         this.Telefono.Name = "Telefono";
         this.Telefono.ReadOnly = true;
         this.Telefono.Width = 150;
         // 
         // txtBusqueda
         // 
         this.txtBusqueda.BackColor = System.Drawing.Color.White;
         this.txtBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBusqueda.BackgroundImage")));
         this.txtBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtBusqueda.Icon = ((System.Drawing.Image)(resources.GetObject("txtBusqueda.Icon")));
         this.txtBusqueda.Location = new System.Drawing.Point(12, 18);
         this.txtBusqueda.Name = "txtBusqueda";
         this.txtBusqueda.Size = new System.Drawing.Size(225, 38);
         this.txtBusqueda.TabIndex = 20;
         this.txtBusqueda.text = "Buscar";
         this.toolTip1.SetToolTip(this.txtBusqueda, "Búsqueda por dni, nombre o apellido.");
         this.txtBusqueda.OnTextChange += new System.EventHandler(this.txtBusqueda_OnTextChange);
         // 
         // dtmFechaNac
         // 
         this.dtmFechaNac.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtmFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtmFechaNac.Location = new System.Drawing.Point(13, 369);
         this.dtmFechaNac.MinDate = new System.DateTime(1773, 11, 12, 0, 0, 0, 0);
         this.dtmFechaNac.Name = "dtmFechaNac";
         this.dtmFechaNac.Size = new System.Drawing.Size(192, 26);
         this.dtmFechaNac.TabIndex = 22;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.Gray;
         this.label4.Location = new System.Drawing.Point(12, 346);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(167, 20);
         this.label4.TabIndex = 23;
         this.label4.Text = "Fecha de Nacimiento";
         // 
         // txtNombre
         // 
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.Gray;
         this.txtNombre.Location = new System.Drawing.Point(13, 98);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(192, 19);
         this.txtNombre.TabIndex = 24;
         this.txtNombre.Text = "Nombre";
         this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator2.LineThickness = 3;
         this.bunifuSeparator2.Location = new System.Drawing.Point(13, 117);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator2.TabIndex = 25;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = false;
         // 
         // bunifuSeparator3
         // 
         this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator3.LineThickness = 3;
         this.bunifuSeparator3.Location = new System.Drawing.Point(13, 157);
         this.bunifuSeparator3.Name = "bunifuSeparator3";
         this.bunifuSeparator3.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator3.TabIndex = 27;
         this.bunifuSeparator3.Transparency = 255;
         this.bunifuSeparator3.Vertical = false;
         // 
         // txtApellido
         // 
         this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtApellido.ForeColor = System.Drawing.Color.Gray;
         this.txtApellido.Location = new System.Drawing.Point(13, 138);
         this.txtApellido.Name = "txtApellido";
         this.txtApellido.Size = new System.Drawing.Size(192, 19);
         this.txtApellido.TabIndex = 26;
         this.txtApellido.Text = "Apellido";
         this.txtApellido.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtApellido.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // bunifuSeparator4
         // 
         this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator4.LineThickness = 3;
         this.bunifuSeparator4.Location = new System.Drawing.Point(13, 197);
         this.bunifuSeparator4.Name = "bunifuSeparator4";
         this.bunifuSeparator4.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator4.TabIndex = 29;
         this.bunifuSeparator4.Transparency = 255;
         this.bunifuSeparator4.Vertical = false;
         // 
         // txtDni
         // 
         this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtDni.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDni.ForeColor = System.Drawing.Color.Gray;
         this.txtDni.Location = new System.Drawing.Point(13, 178);
         this.txtDni.Name = "txtDni";
         this.txtDni.Size = new System.Drawing.Size(192, 19);
         this.txtDni.TabIndex = 28;
         this.txtDni.Text = "DNI";
         this.txtDni.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtDni.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // bunifuSeparator5
         // 
         this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator5.LineThickness = 3;
         this.bunifuSeparator5.Location = new System.Drawing.Point(13, 237);
         this.bunifuSeparator5.Name = "bunifuSeparator5";
         this.bunifuSeparator5.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator5.TabIndex = 31;
         this.bunifuSeparator5.Transparency = 255;
         this.bunifuSeparator5.Vertical = false;
         // 
         // txtTelefono
         // 
         this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
         this.txtTelefono.Location = new System.Drawing.Point(13, 218);
         this.txtTelefono.Name = "txtTelefono";
         this.txtTelefono.Size = new System.Drawing.Size(192, 19);
         this.txtTelefono.TabIndex = 30;
         this.txtTelefono.Text = "Teléfono";
         this.txtTelefono.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtTelefono.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // bunifuSeparator6
         // 
         this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator6.LineThickness = 3;
         this.bunifuSeparator6.Location = new System.Drawing.Point(13, 277);
         this.bunifuSeparator6.Name = "bunifuSeparator6";
         this.bunifuSeparator6.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator6.TabIndex = 33;
         this.bunifuSeparator6.Transparency = 255;
         this.bunifuSeparator6.Vertical = false;
         // 
         // txtEmail
         // 
         this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmail.ForeColor = System.Drawing.Color.Gray;
         this.txtEmail.Location = new System.Drawing.Point(13, 258);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(192, 19);
         this.txtEmail.TabIndex = 32;
         this.txtEmail.Text = "E-Mail";
         this.txtEmail.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtEmail.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // bunifuSeparator7
         // 
         this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator7.LineThickness = 3;
         this.bunifuSeparator7.Location = new System.Drawing.Point(13, 317);
         this.bunifuSeparator7.Name = "bunifuSeparator7";
         this.bunifuSeparator7.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator7.TabIndex = 35;
         this.bunifuSeparator7.Transparency = 255;
         this.bunifuSeparator7.Vertical = false;
         // 
         // txtObservacion
         // 
         this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtObservacion.ForeColor = System.Drawing.Color.Gray;
         this.txtObservacion.Location = new System.Drawing.Point(13, 298);
         this.txtObservacion.Name = "txtObservacion";
         this.txtObservacion.Size = new System.Drawing.Size(192, 19);
         this.txtObservacion.TabIndex = 34;
         this.txtObservacion.Text = "Observación";
         this.txtObservacion.Click += new System.EventHandler(this.txtNombre_Click_1);
         this.txtObservacion.Leave += new System.EventHandler(this.txtNombre_Leave);
         // 
         // frmClientes
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(914, 587);
         this.Controls.Add(this.bunifuSeparator7);
         this.Controls.Add(this.txtObservacion);
         this.Controls.Add(this.bunifuSeparator6);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.bunifuSeparator5);
         this.Controls.Add(this.txtTelefono);
         this.Controls.Add(this.bunifuSeparator4);
         this.Controls.Add(this.txtDni);
         this.Controls.Add(this.bunifuSeparator3);
         this.Controls.Add(this.txtApellido);
         this.Controls.Add(this.bunifuSeparator2);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.dtmFechaNac);
         this.Controls.Add(this.txtBusqueda);
         this.Controls.Add(this.dtgvClientes);
         this.Controls.Add(this.bunifuSeparator1);
         this.Controls.Add(this.lblNoct);
         this.Controls.Add(this.swNocturno);
         this.Controls.Add(this.btnGuardar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.btnCancelar);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmClientes";
         this.Text = "frmClientes";
         this.Load += new System.EventHandler(this.frmClientes_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
    private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
    private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
    private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
    private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
    private Bunifu.Framework.UI.BunifuSwitch swNocturno;
    private System.Windows.Forms.Label lblNoct;
    private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
      private Bunifu.Framework.UI.BunifuTextbox txtBusqueda;
      private System.Windows.Forms.DateTimePicker dtmFechaNac;
      private System.Windows.Forms.Label label4;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvClientes;
      private System.Windows.Forms.TextBox txtNombre;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
      private System.Windows.Forms.TextBox txtApellido;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
      private System.Windows.Forms.TextBox txtDni;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
      private System.Windows.Forms.TextBox txtTelefono;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
      private System.Windows.Forms.TextBox txtEmail;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
      private System.Windows.Forms.TextBox txtObservacion;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.DataGridViewTextBoxColumn IdClie;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
      private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
      private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
      private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
      private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
      private System.Windows.Forms.DataGridViewTextBoxColumn Observación;
      private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
   }
}