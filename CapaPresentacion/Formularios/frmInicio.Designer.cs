namespace CapaPresentacion
{
  partial class frmInicio
  {
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
      this.pnPrincipal = new System.Windows.Forms.Panel();
      this.pnSubRep = new System.Windows.Forms.Panel();
      this.btnRepServicios = new System.Windows.Forms.Button();
      this.btnRepClientes = new System.Windows.Forms.Button();
      this.btnRepFinanzas = new System.Windows.Forms.Button();
      this.line = new Bunifu.Framework.UI.BunifuSeparator();
      this.lblSistema = new System.Windows.Forms.Label();
      this.btnRep = new System.Windows.Forms.Button();
      this.btnCaja = new System.Windows.Forms.Button();
      this.btnPromociones = new System.Windows.Forms.Button();
      this.btnServicios = new System.Windows.Forms.Button();
      this.btnPersonal = new System.Windows.Forms.Button();
      this.btnClientes = new System.Windows.Forms.Button();
      this.pnPosicion = new System.Windows.Forms.Panel();
      this.btnTurnos = new System.Windows.Forms.Button();
      this.pcLogo = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnCerrarSesion = new System.Windows.Forms.Button();
      this.lblUsuario = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSlide = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.pnContenedor = new System.Windows.Forms.Panel();
      this.pnPrincipal.SuspendLayout();
      this.pnSubRep.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnPrincipal
      // 
      this.pnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.pnPrincipal.Controls.Add(this.pnSubRep);
      this.pnPrincipal.Controls.Add(this.line);
      this.pnPrincipal.Controls.Add(this.lblSistema);
      this.pnPrincipal.Controls.Add(this.btnRep);
      this.pnPrincipal.Controls.Add(this.btnCaja);
      this.pnPrincipal.Controls.Add(this.btnPromociones);
      this.pnPrincipal.Controls.Add(this.btnServicios);
      this.pnPrincipal.Controls.Add(this.btnPersonal);
      this.pnPrincipal.Controls.Add(this.btnClientes);
      this.pnPrincipal.Controls.Add(this.pnPosicion);
      this.pnPrincipal.Controls.Add(this.btnTurnos);
      this.pnPrincipal.Controls.Add(this.pcLogo);
      this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
      this.pnPrincipal.Name = "pnPrincipal";
      this.pnPrincipal.Size = new System.Drawing.Size(220, 535);
      this.pnPrincipal.TabIndex = 0;
      // 
      // pnSubRep
      // 
      this.pnSubRep.Controls.Add(this.btnRepServicios);
      this.pnSubRep.Controls.Add(this.btnRepClientes);
      this.pnSubRep.Controls.Add(this.btnRepFinanzas);
      this.pnSubRep.Location = new System.Drawing.Point(12, 389);
      this.pnSubRep.Name = "pnSubRep";
      this.pnSubRep.Size = new System.Drawing.Size(208, 132);
      this.pnSubRep.TabIndex = 2;
      this.pnSubRep.Visible = false;
      // 
      // btnRepServicios
      // 
      this.btnRepServicios.FlatAppearance.BorderSize = 0;
      this.btnRepServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRepServicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRepServicios.ForeColor = System.Drawing.Color.White;
      this.btnRepServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnRepServicios.Image")));
      this.btnRepServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRepServicios.Location = new System.Drawing.Point(7, 90);
      this.btnRepServicios.Name = "btnRepServicios";
      this.btnRepServicios.Size = new System.Drawing.Size(201, 34);
      this.btnRepServicios.TabIndex = 10;
      this.btnRepServicios.Text = "Servicios";
      this.btnRepServicios.UseVisualStyleBackColor = true;
      this.btnRepServicios.Click += new System.EventHandler(this.btnRepServicios_Click);
      // 
      // btnRepClientes
      // 
      this.btnRepClientes.FlatAppearance.BorderSize = 0;
      this.btnRepClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRepClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRepClientes.ForeColor = System.Drawing.Color.White;
      this.btnRepClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnRepClientes.Image")));
      this.btnRepClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRepClientes.Location = new System.Drawing.Point(7, 50);
      this.btnRepClientes.Name = "btnRepClientes";
      this.btnRepClientes.Size = new System.Drawing.Size(201, 34);
      this.btnRepClientes.TabIndex = 9;
      this.btnRepClientes.Text = "Clientes";
      this.btnRepClientes.UseVisualStyleBackColor = true;
      this.btnRepClientes.Click += new System.EventHandler(this.btnRepClientes_Click);
      // 
      // btnRepFinanzas
      // 
      this.btnRepFinanzas.FlatAppearance.BorderSize = 0;
      this.btnRepFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRepFinanzas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRepFinanzas.ForeColor = System.Drawing.Color.White;
      this.btnRepFinanzas.Image = ((System.Drawing.Image)(resources.GetObject("btnRepFinanzas.Image")));
      this.btnRepFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRepFinanzas.Location = new System.Drawing.Point(7, 10);
      this.btnRepFinanzas.Name = "btnRepFinanzas";
      this.btnRepFinanzas.Size = new System.Drawing.Size(201, 34);
      this.btnRepFinanzas.TabIndex = 8;
      this.btnRepFinanzas.Text = "Finanzas";
      this.btnRepFinanzas.UseVisualStyleBackColor = true;
      this.btnRepFinanzas.Click += new System.EventHandler(this.btnRepFinanzas_Click);
      // 
      // line
      // 
      this.line.BackColor = System.Drawing.Color.Transparent;
      this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
      this.line.LineThickness = 1;
      this.line.Location = new System.Drawing.Point(4, 53);
      this.line.Name = "line";
      this.line.Size = new System.Drawing.Size(210, 10);
      this.line.TabIndex = 2;
      this.line.Transparency = 255;
      this.line.Vertical = false;
      // 
      // lblSistema
      // 
      this.lblSistema.AutoSize = true;
      this.lblSistema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblSistema.ForeColor = System.Drawing.Color.White;
      this.lblSistema.Location = new System.Drawing.Point(62, 9);
      this.lblSistema.Name = "lblSistema";
      this.lblSistema.Size = new System.Drawing.Size(101, 21);
      this.lblSistema.TabIndex = 4;
      this.lblSistema.Text = "MOSTACHE";
      // 
      // btnRep
      // 
      this.btnRep.FlatAppearance.BorderSize = 0;
      this.btnRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnRep.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRep.ForeColor = System.Drawing.Color.White;
      this.btnRep.Image = ((System.Drawing.Image)(resources.GetObject("btnRep.Image")));
      this.btnRep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnRep.Location = new System.Drawing.Point(4, 351);
      this.btnRep.Name = "btnRep";
      this.btnRep.Size = new System.Drawing.Size(216, 34);
      this.btnRep.TabIndex = 7;
      this.btnRep.Text = "Reportes";
      this.btnRep.UseVisualStyleBackColor = true;
      this.btnRep.Click += new System.EventHandler(this.btnRep_Click);
      // 
      // btnCaja
      // 
      this.btnCaja.FlatAppearance.BorderSize = 0;
      this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCaja.ForeColor = System.Drawing.Color.White;
      this.btnCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCaja.Image")));
      this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCaja.Location = new System.Drawing.Point(4, 311);
      this.btnCaja.Name = "btnCaja";
      this.btnCaja.Size = new System.Drawing.Size(216, 34);
      this.btnCaja.TabIndex = 6;
      this.btnCaja.Text = "Caja";
      this.btnCaja.UseVisualStyleBackColor = true;
      this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
      // 
      // btnPromociones
      // 
      this.btnPromociones.FlatAppearance.BorderSize = 0;
      this.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPromociones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPromociones.ForeColor = System.Drawing.Color.White;
      this.btnPromociones.Image = ((System.Drawing.Image)(resources.GetObject("btnPromociones.Image")));
      this.btnPromociones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPromociones.Location = new System.Drawing.Point(4, 271);
      this.btnPromociones.Name = "btnPromociones";
      this.btnPromociones.Size = new System.Drawing.Size(216, 34);
      this.btnPromociones.TabIndex = 5;
      this.btnPromociones.Text = "Promociones";
      this.btnPromociones.UseVisualStyleBackColor = true;
      this.btnPromociones.Click += new System.EventHandler(this.btnPromociones_Click);
      // 
      // btnServicios
      // 
      this.btnServicios.FlatAppearance.BorderSize = 0;
      this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnServicios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnServicios.ForeColor = System.Drawing.Color.White;
      this.btnServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnServicios.Image")));
      this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnServicios.Location = new System.Drawing.Point(4, 231);
      this.btnServicios.Name = "btnServicios";
      this.btnServicios.Size = new System.Drawing.Size(216, 34);
      this.btnServicios.TabIndex = 4;
      this.btnServicios.Text = "Servicios";
      this.btnServicios.UseVisualStyleBackColor = true;
      this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
      // 
      // btnPersonal
      // 
      this.btnPersonal.FlatAppearance.BorderSize = 0;
      this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPersonal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPersonal.ForeColor = System.Drawing.Color.White;
      this.btnPersonal.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonal.Image")));
      this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnPersonal.Location = new System.Drawing.Point(4, 191);
      this.btnPersonal.Name = "btnPersonal";
      this.btnPersonal.Size = new System.Drawing.Size(216, 34);
      this.btnPersonal.TabIndex = 3;
      this.btnPersonal.Text = "Personal";
      this.btnPersonal.UseVisualStyleBackColor = true;
      this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
      // 
      // btnClientes
      // 
      this.btnClientes.FlatAppearance.BorderSize = 0;
      this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClientes.ForeColor = System.Drawing.Color.White;
      this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
      this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClientes.Location = new System.Drawing.Point(4, 151);
      this.btnClientes.Name = "btnClientes";
      this.btnClientes.Size = new System.Drawing.Size(216, 34);
      this.btnClientes.TabIndex = 2;
      this.btnClientes.Text = "Clientes";
      this.btnClientes.UseVisualStyleBackColor = true;
      this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
      // 
      // pnPosicion
      // 
      this.pnPosicion.BackColor = System.Drawing.Color.LightSeaGreen;
      this.pnPosicion.Location = new System.Drawing.Point(0, 111);
      this.pnPosicion.Name = "pnPosicion";
      this.pnPosicion.Size = new System.Drawing.Size(4, 34);
      this.pnPosicion.TabIndex = 1;
      // 
      // btnTurnos
      // 
      this.btnTurnos.FlatAppearance.BorderSize = 0;
      this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTurnos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTurnos.ForeColor = System.Drawing.Color.White;
      this.btnTurnos.Image = ((System.Drawing.Image)(resources.GetObject("btnTurnos.Image")));
      this.btnTurnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTurnos.Location = new System.Drawing.Point(4, 111);
      this.btnTurnos.Name = "btnTurnos";
      this.btnTurnos.Size = new System.Drawing.Size(216, 34);
      this.btnTurnos.TabIndex = 1;
      this.btnTurnos.Text = "Turnos";
      this.btnTurnos.UseVisualStyleBackColor = true;
      this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
      // 
      // pcLogo
      // 
      this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
      this.pcLogo.Location = new System.Drawing.Point(39, -1);
      this.pcLogo.Name = "pcLogo";
      this.pcLogo.Size = new System.Drawing.Size(145, 82);
      this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pcLogo.TabIndex = 8;
      this.pcLogo.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
      this.panel2.Controls.Add(this.btnCerrarSesion);
      this.panel2.Controls.Add(this.lblUsuario);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.btnSlide);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(220, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(868, 48);
      this.panel2.TabIndex = 1;
      // 
      // btnCerrarSesion
      // 
      this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
      this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
      this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
      this.btnCerrarSesion.Location = new System.Drawing.Point(828, 6);
      this.btnCerrarSesion.Name = "btnCerrarSesion";
      this.btnCerrarSesion.Size = new System.Drawing.Size(35, 34);
      this.btnCerrarSesion.TabIndex = 3;
      this.toolTip1.SetToolTip(this.btnCerrarSesion, "Cerrar sesión.");
      this.btnCerrarSesion.UseVisualStyleBackColor = true;
      // 
      // lblUsuario
      // 
      this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblUsuario.AutoSize = true;
      this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUsuario.ForeColor = System.Drawing.Color.LightSeaGreen;
      this.lblUsuario.Location = new System.Drawing.Point(735, 14);
      this.lblUsuario.Name = "lblUsuario";
      this.lblUsuario.Size = new System.Drawing.Size(66, 21);
      this.lblUsuario.TabIndex = 4;
      this.lblUsuario.Text = "Usuario";
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(639, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 21);
      this.label1.TabIndex = 3;
      this.label1.Text = "Bienvenido:";
      // 
      // btnSlide
      // 
      this.btnSlide.FlatAppearance.BorderSize = 0;
      this.btnSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSlide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSlide.ForeColor = System.Drawing.Color.White;
      this.btnSlide.Image = ((System.Drawing.Image)(resources.GetObject("btnSlide.Image")));
      this.btnSlide.Location = new System.Drawing.Point(3, 7);
      this.btnSlide.Name = "btnSlide";
      this.btnSlide.Size = new System.Drawing.Size(35, 34);
      this.btnSlide.TabIndex = 2;
      this.btnSlide.UseVisualStyleBackColor = true;
      this.btnSlide.Click += new System.EventHandler(this.btnSlide_Click);
      // 
      // pnContenedor
      // 
      this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnContenedor.Location = new System.Drawing.Point(220, 48);
      this.pnContenedor.Name = "pnContenedor";
      this.pnContenedor.Size = new System.Drawing.Size(868, 487);
      this.pnContenedor.TabIndex = 2;
      // 
      // frmInicio
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1088, 535);
      this.Controls.Add(this.pnContenedor);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.pnPrincipal);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmInicio";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form1";
      this.pnPrincipal.ResumeLayout(false);
      this.pnPrincipal.PerformLayout();
      this.pnSubRep.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnPrincipal;
    private System.Windows.Forms.Panel pnPosicion;
    private System.Windows.Forms.Button btnTurnos;
    private System.Windows.Forms.Button btnCaja;
    private System.Windows.Forms.Button btnPromociones;
    private System.Windows.Forms.Button btnServicios;
    private System.Windows.Forms.Button btnPersonal;
    private System.Windows.Forms.Button btnClientes;
    private System.Windows.Forms.Button btnRep;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnSlide;
    private System.Windows.Forms.Button btnCerrarSesion;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblSistema;
    private Bunifu.Framework.UI.BunifuSeparator line;
    private System.Windows.Forms.PictureBox pcLogo;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Panel pnSubRep;
    private System.Windows.Forms.Button btnRepServicios;
    private System.Windows.Forms.Button btnRepClientes;
    private System.Windows.Forms.Button btnRepFinanzas;
    private System.Windows.Forms.Panel pnContenedor;
  }
}

