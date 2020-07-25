namespace CapaPresentacion.Formularios
{
   partial class frmTurnos
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurnos));
         this.cmbClientes = new System.Windows.Forms.ComboBox();
         this.lblNoct = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cmbPersonal = new System.Windows.Forms.ComboBox();
         this.label2 = new System.Windows.Forms.Label();
         this.cmbServicio = new System.Windows.Forms.ComboBox();
         this.label3 = new System.Windows.Forms.Label();
         this.cmbTS = new System.Windows.Forms.ComboBox();
         this.dtmFechaTurno = new System.Windows.Forms.DateTimePicker();
         this.label4 = new System.Windows.Forms.Label();
         this.txtHora = new System.Windows.Forms.MaskedTextBox();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.dtgvTurnoActual = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.idTurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.idClie = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.idTipS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.idPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Profesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.TipoS = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.dtgvTurnero = new Bunifu.Framework.UI.BunifuCustomDataGrid();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEditar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnCargarTuno = new Bunifu.Framework.UI.BunifuThinButton2();
         this.toolTip = new System.Windows.Forms.ToolTip(this.components);
         this.lblValorTS = new System.Windows.Forms.Label();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnoActual)).BeginInit();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnero)).BeginInit();
         this.SuspendLayout();
         // 
         // cmbClientes
         // 
         this.cmbClientes.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbClientes.FormattingEnabled = true;
         this.cmbClientes.Location = new System.Drawing.Point(9, 35);
         this.cmbClientes.Name = "cmbClientes";
         this.cmbClientes.Size = new System.Drawing.Size(211, 28);
         this.cmbClientes.TabIndex = 1;
         // 
         // lblNoct
         // 
         this.lblNoct.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.lblNoct.AutoSize = true;
         this.lblNoct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNoct.ForeColor = System.Drawing.Color.Gray;
         this.lblNoct.Location = new System.Drawing.Point(11, 12);
         this.lblNoct.Name = "lblNoct";
         this.lblNoct.Size = new System.Drawing.Size(71, 20);
         this.lblNoct.TabIndex = 18;
         this.lblNoct.Text = "Clientes:";
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Gray;
         this.label1.Location = new System.Drawing.Point(9, 77);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(75, 20);
         this.label1.TabIndex = 20;
         this.label1.Text = "Personal:";
         // 
         // cmbPersonal
         // 
         this.cmbPersonal.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbPersonal.FormattingEnabled = true;
         this.cmbPersonal.Location = new System.Drawing.Point(9, 100);
         this.cmbPersonal.Name = "cmbPersonal";
         this.cmbPersonal.Size = new System.Drawing.Size(211, 28);
         this.cmbPersonal.TabIndex = 19;
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Gray;
         this.label2.Location = new System.Drawing.Point(9, 147);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(71, 20);
         this.label2.TabIndex = 22;
         this.label2.Text = "Servicio:";
         // 
         // cmbServicio
         // 
         this.cmbServicio.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbServicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbServicio.FormattingEnabled = true;
         this.cmbServicio.Location = new System.Drawing.Point(9, 170);
         this.cmbServicio.Name = "cmbServicio";
         this.cmbServicio.Size = new System.Drawing.Size(211, 28);
         this.cmbServicio.TabIndex = 21;
         this.cmbServicio.DropDownClosed += new System.EventHandler(this.cmbServicio_DropDownClosed);
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gray;
         this.label3.Location = new System.Drawing.Point(9, 217);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(127, 20);
         this.label3.TabIndex = 24;
         this.label3.Text = "Tipo de Servicio:";
         // 
         // cmbTS
         // 
         this.cmbTS.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbTS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbTS.FormattingEnabled = true;
         this.cmbTS.Location = new System.Drawing.Point(9, 240);
         this.cmbTS.Name = "cmbTS";
         this.cmbTS.Size = new System.Drawing.Size(211, 28);
         this.cmbTS.TabIndex = 23;
         this.cmbTS.SelectedValueChanged += new System.EventHandler(this.cmbTS_SelectedValueChanged);
         // 
         // dtmFechaTurno
         // 
         this.dtmFechaTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.dtmFechaTurno.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtmFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtmFechaTurno.Location = new System.Drawing.Point(9, 312);
         this.dtmFechaTurno.MinDate = new System.DateTime(1773, 11, 12, 0, 0, 0, 0);
         this.dtmFechaTurno.Name = "dtmFechaTurno";
         this.dtmFechaTurno.Size = new System.Drawing.Size(211, 26);
         this.dtmFechaTurno.TabIndex = 25;
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.Gray;
         this.label4.Location = new System.Drawing.Point(9, 289);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(59, 20);
         this.label4.TabIndex = 26;
         this.label4.Text = "Fecha:";
         // 
         // txtHora
         // 
         this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtHora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtHora.ForeColor = System.Drawing.Color.Gray;
         this.txtHora.Location = new System.Drawing.Point(60, 368);
         this.txtHora.Mask = "00:00";
         this.txtHora.Name = "txtHora";
         this.txtHora.Size = new System.Drawing.Size(38, 16);
         this.txtHora.TabIndex = 27;
         this.txtHora.ValidatingType = typeof(System.DateTime);
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator2.LineThickness = 3;
         this.bunifuSeparator2.Location = new System.Drawing.Point(9, 384);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(211, 15);
         this.bunifuSeparator2.TabIndex = 28;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = false;
         // 
         // label6
         // 
         this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.Gray;
         this.label6.Location = new System.Drawing.Point(226, 243);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(25, 20);
         this.label6.TabIndex = 30;
         this.label6.Text = "(*)";
         // 
         // label7
         // 
         this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.ForeColor = System.Drawing.Color.Gray;
         this.label7.Location = new System.Drawing.Point(226, 315);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(25, 20);
         this.label7.TabIndex = 31;
         this.label7.Text = "(*)";
         // 
         // label8
         // 
         this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label8.ForeColor = System.Drawing.Color.Gray;
         this.label8.Location = new System.Drawing.Point(226, 368);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(25, 20);
         this.label8.TabIndex = 32;
         this.label8.Text = "(*)";
         // 
         // label9
         // 
         this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label9.AutoSize = true;
         this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label9.ForeColor = System.Drawing.Color.Gray;
         this.label9.Location = new System.Drawing.Point(9, 365);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(48, 20);
         this.label9.TabIndex = 33;
         this.label9.Text = "Hora:";
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.dtgvTurnoActual);
         this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.Gray;
         this.groupBox1.Location = new System.Drawing.Point(266, 26);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(634, 260);
         this.groupBox1.TabIndex = 34;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Turno Actual:";
         // 
         // dtgvTurnoActual
         // 
         this.dtgvTurnoActual.AllowUserToAddRows = false;
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvTurnoActual.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
         this.dtgvTurnoActual.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvTurnoActual.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvTurnoActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvTurnoActual.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvTurnoActual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
         this.dtgvTurnoActual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvTurnoActual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurn,
            this.idClie,
            this.idTipS,
            this.idPers,
            this.Nombre_cliente,
            this.Profesional,
            this.TipoS,
            this.Fecha,
            this.Hora,
            this.Cantidad});
         dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvTurnoActual.DefaultCellStyle = dataGridViewCellStyle9;
         this.dtgvTurnoActual.DoubleBuffered = true;
         this.dtgvTurnoActual.EnableHeadersVisualStyles = false;
         this.dtgvTurnoActual.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvTurnoActual.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvTurnoActual.Location = new System.Drawing.Point(6, 23);
         this.dtgvTurnoActual.Name = "dtgvTurnoActual";
         this.dtgvTurnoActual.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvTurnoActual.Size = new System.Drawing.Size(622, 231);
         this.dtgvTurnoActual.TabIndex = 20;
         // 
         // idTurn
         // 
         this.idTurn.HeaderText = "idTurn";
         this.idTurn.Name = "idTurn";
         this.idTurn.Visible = false;
         // 
         // idClie
         // 
         this.idClie.HeaderText = "idClie";
         this.idClie.Name = "idClie";
         this.idClie.Visible = false;
         // 
         // idTipS
         // 
         this.idTipS.HeaderText = "idTipS";
         this.idTipS.Name = "idTipS";
         this.idTipS.ReadOnly = true;
         this.idTipS.Visible = false;
         // 
         // idPers
         // 
         this.idPers.HeaderText = "idPers";
         this.idPers.Name = "idPers";
         this.idPers.Visible = false;
         // 
         // Nombre_cliente
         // 
         this.Nombre_cliente.HeaderText = "Nombre de Cliente";
         this.Nombre_cliente.Name = "Nombre_cliente";
         this.Nombre_cliente.ReadOnly = true;
         this.Nombre_cliente.Width = 300;
         // 
         // Profesional
         // 
         this.Profesional.HeaderText = "Profesional";
         this.Profesional.Name = "Profesional";
         this.Profesional.ReadOnly = true;
         this.Profesional.Width = 200;
         // 
         // TipoS
         // 
         this.TipoS.HeaderText = "Tipo de Servicio";
         this.TipoS.Name = "TipoS";
         this.TipoS.ReadOnly = true;
         this.TipoS.Width = 300;
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
         // Cantidad
         // 
         this.Cantidad.HeaderText = "Cantidad";
         this.Cantidad.Name = "Cantidad";
         this.Cantidad.ReadOnly = true;
         this.Cantidad.Width = 120;
         // 
         // groupBox2
         // 
         this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox2.Controls.Add(this.dtgvTurnero);
         this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.ForeColor = System.Drawing.Color.Gray;
         this.groupBox2.Location = new System.Drawing.Point(266, 315);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(634, 260);
         this.groupBox2.TabIndex = 35;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Turnero:";
         // 
         // dtgvTurnero
         // 
         this.dtgvTurnero.AllowUserToAddRows = false;
         dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
         this.dtgvTurnero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
         this.dtgvTurnero.Anchor = System.Windows.Forms.AnchorStyles.Right;
         this.dtgvTurnero.BackgroundColor = System.Drawing.Color.Gainsboro;
         this.dtgvTurnero.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.dtgvTurnero.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen;
         dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dtgvTurnero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
         this.dtgvTurnero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dtgvTurnero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Estado});
         dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkGray;
         dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gray;
         dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
         dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
         dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dtgvTurnero.DefaultCellStyle = dataGridViewCellStyle12;
         this.dtgvTurnero.DoubleBuffered = true;
         this.dtgvTurnero.EnableHeadersVisualStyles = false;
         this.dtgvTurnero.HeaderBgColor = System.Drawing.Color.LightSeaGreen;
         this.dtgvTurnero.HeaderForeColor = System.Drawing.Color.White;
         this.dtgvTurnero.Location = new System.Drawing.Point(6, 25);
         this.dtgvTurnero.Name = "dtgvTurnero";
         this.dtgvTurnero.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         this.dtgvTurnero.Size = new System.Drawing.Size(622, 229);
         this.dtgvTurnero.TabIndex = 21;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.HeaderText = "idTurn";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.Visible = false;
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.HeaderText = "idClie";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.Visible = false;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.HeaderText = "idTS";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.Visible = false;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.HeaderText = "idPers";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.Visible = false;
         // 
         // dataGridViewTextBoxColumn5
         // 
         this.dataGridViewTextBoxColumn5.HeaderText = "Nombre de Cliente";
         this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
         this.dataGridViewTextBoxColumn5.ReadOnly = true;
         this.dataGridViewTextBoxColumn5.Width = 300;
         // 
         // dataGridViewTextBoxColumn6
         // 
         this.dataGridViewTextBoxColumn6.HeaderText = "Profesional";
         this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
         this.dataGridViewTextBoxColumn6.ReadOnly = true;
         this.dataGridViewTextBoxColumn6.Width = 200;
         // 
         // dataGridViewTextBoxColumn7
         // 
         this.dataGridViewTextBoxColumn7.HeaderText = "Tipo de Servicio";
         this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
         this.dataGridViewTextBoxColumn7.ReadOnly = true;
         this.dataGridViewTextBoxColumn7.Width = 300;
         // 
         // dataGridViewTextBoxColumn8
         // 
         this.dataGridViewTextBoxColumn8.HeaderText = "Fecha";
         this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
         this.dataGridViewTextBoxColumn8.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn9
         // 
         this.dataGridViewTextBoxColumn9.HeaderText = "Hora";
         this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
         this.dataGridViewTextBoxColumn9.ReadOnly = true;
         // 
         // Estado
         // 
         this.Estado.HeaderText = "Estado";
         this.Estado.Name = "Estado";
         this.Estado.ReadOnly = true;
         this.Estado.Width = 150;
         // 
         // btnGuardar
         // 
         this.btnGuardar.ActiveBorderThickness = 1;
         this.btnGuardar.ActiveCornerRadius = 10;
         this.btnGuardar.ActiveFillColor = System.Drawing.Color.CornflowerBlue;
         this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
         this.btnGuardar.ActiveLineColor = System.Drawing.Color.CornflowerBlue;
         this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
         this.btnGuardar.Location = new System.Drawing.Point(9, 535);
         this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
         this.btnGuardar.Name = "btnGuardar";
         this.btnGuardar.Size = new System.Drawing.Size(211, 41);
         this.btnGuardar.TabIndex = 39;
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
         this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
         this.btnEditar.Location = new System.Drawing.Point(9, 535);
         this.btnEditar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEditar.Name = "btnEditar";
         this.btnEditar.Size = new System.Drawing.Size(211, 41);
         this.btnEditar.TabIndex = 38;
         this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnEliminar
         // 
         this.btnEliminar.ActiveBorderThickness = 1;
         this.btnEliminar.ActiveCornerRadius = 10;
         this.btnEliminar.ActiveFillColor = System.Drawing.Color.Red;
         this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
         this.btnEliminar.ActiveLineColor = System.Drawing.Color.Red;
         this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnEliminar.BackColor = System.Drawing.Color.White;
         this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
         this.btnEliminar.ButtonText = "Cancelar Turno";
         this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.IdleBorderThickness = 1;
         this.btnEliminar.IdleCornerRadius = 20;
         this.btnEliminar.IdleFillColor = System.Drawing.Color.White;
         this.btnEliminar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnEliminar.Location = new System.Drawing.Point(9, 494);
         this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(211, 41);
         this.btnEliminar.TabIndex = 37;
         this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnAgregar
         // 
         this.btnAgregar.ActiveBorderThickness = 1;
         this.btnAgregar.ActiveCornerRadius = 10;
         this.btnAgregar.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
         this.btnAgregar.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnAgregar.BackColor = System.Drawing.Color.White;
         this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
         this.btnAgregar.ButtonText = "Aceptar";
         this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleBorderThickness = 1;
         this.btnAgregar.IdleCornerRadius = 20;
         this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
         this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.Location = new System.Drawing.Point(9, 453);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(211, 41);
         this.btnAgregar.TabIndex = 36;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnCargarTuno
         // 
         this.btnCargarTuno.ActiveBorderThickness = 1;
         this.btnCargarTuno.ActiveCornerRadius = 10;
         this.btnCargarTuno.ActiveFillColor = System.Drawing.Color.DarkGoldenrod;
         this.btnCargarTuno.ActiveForecolor = System.Drawing.Color.White;
         this.btnCargarTuno.ActiveLineColor = System.Drawing.Color.DarkGoldenrod;
         this.btnCargarTuno.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnCargarTuno.BackColor = System.Drawing.Color.White;
         this.btnCargarTuno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargarTuno.BackgroundImage")));
         this.btnCargarTuno.ButtonText = "Cargar";
         this.btnCargarTuno.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCargarTuno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCargarTuno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCargarTuno.IdleBorderThickness = 1;
         this.btnCargarTuno.IdleCornerRadius = 20;
         this.btnCargarTuno.IdleFillColor = System.Drawing.Color.White;
         this.btnCargarTuno.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCargarTuno.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCargarTuno.Location = new System.Drawing.Point(9, 409);
         this.btnCargarTuno.Margin = new System.Windows.Forms.Padding(5);
         this.btnCargarTuno.Name = "btnCargarTuno";
         this.btnCargarTuno.Size = new System.Drawing.Size(211, 41);
         this.btnCargarTuno.TabIndex = 40;
         this.btnCargarTuno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.btnCargarTuno.Click += new System.EventHandler(this.btnCargarTuno_Click);
         // 
         // lblValorTS
         // 
         this.lblValorTS.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.lblValorTS.AutoSize = true;
         this.lblValorTS.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblValorTS.ForeColor = System.Drawing.Color.Red;
         this.lblValorTS.Location = new System.Drawing.Point(808, 7);
         this.lblValorTS.Name = "lblValorTS";
         this.lblValorTS.Size = new System.Drawing.Size(0, 18);
         this.lblValorTS.TabIndex = 41;
         this.toolTip.SetToolTip(this.lblValorTS, "Valor de tipo de servicio seleccionado");
         // 
         // frmTurnos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(914, 587);
         this.Controls.Add(this.lblValorTS);
         this.Controls.Add(this.btnCargarTuno);
         this.Controls.Add(this.btnGuardar);
         this.Controls.Add(this.btnEditar);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.bunifuSeparator2);
         this.Controls.Add(this.txtHora);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.dtmFechaTurno);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.cmbTS);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.cmbServicio);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.cmbPersonal);
         this.Controls.Add(this.lblNoct);
         this.Controls.Add(this.cmbClientes);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmTurnos";
         this.Text = "frmTurnos";
         this.Load += new System.EventHandler(this.frmTurnos_Load);
         this.groupBox1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnoActual)).EndInit();
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dtgvTurnero)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox cmbClientes;
      private System.Windows.Forms.Label lblNoct;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbPersonal;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox cmbServicio;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.ComboBox cmbTS;
      private System.Windows.Forms.DateTimePicker dtmFechaTurno;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.MaskedTextBox txtHora;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTurnoActual;
      private Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEditar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
      public Bunifu.Framework.UI.BunifuCustomDataGrid dtgvTurnero;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
      private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
      private Bunifu.Framework.UI.BunifuThinButton2 btnCargarTuno;
      private System.Windows.Forms.DataGridViewTextBoxColumn idTurn;
      private System.Windows.Forms.DataGridViewTextBoxColumn idClie;
      private System.Windows.Forms.DataGridViewTextBoxColumn idTipS;
      private System.Windows.Forms.DataGridViewTextBoxColumn idPers;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_cliente;
      private System.Windows.Forms.DataGridViewTextBoxColumn Profesional;
      private System.Windows.Forms.DataGridViewTextBoxColumn TipoS;
      private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
      private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
      private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
      private System.Windows.Forms.ToolTip toolTip;
      private System.Windows.Forms.Label lblValorTS;
   }
}