namespace CapaPresentacion.Formularios
{
   partial class frmInicioSesion
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
         this.lblSistema = new System.Windows.Forms.Label();
         this.pcLogo = new System.Windows.Forms.PictureBox();
         this.panel1 = new System.Windows.Forms.Panel();
         this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtApellido = new System.Windows.Forms.TextBox();
         this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
         ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblSistema
         // 
         this.lblSistema.AutoSize = true;
         this.lblSistema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSistema.ForeColor = System.Drawing.Color.White;
         this.lblSistema.Location = new System.Drawing.Point(28, 68);
         this.lblSistema.Name = "lblSistema";
         this.lblSistema.Size = new System.Drawing.Size(101, 21);
         this.lblSistema.TabIndex = 9;
         this.lblSistema.Text = "MOSTACHE";
         // 
         // pcLogo
         // 
         this.pcLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcLogo.Image")));
         this.pcLogo.Location = new System.Drawing.Point(5, 58);
         this.pcLogo.Name = "pcLogo";
         this.pcLogo.Size = new System.Drawing.Size(145, 82);
         this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
         this.pcLogo.TabIndex = 10;
         this.pcLogo.TabStop = false;
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.White;
         this.panel1.Controls.Add(this.btnAgregar);
         this.panel1.Controls.Add(this.bunifuSeparator3);
         this.panel1.Controls.Add(this.txtApellido);
         this.panel1.Controls.Add(this.bunifuSeparator2);
         this.panel1.Controls.Add(this.txtNombre);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
         this.panel1.Location = new System.Drawing.Point(156, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(241, 186);
         this.panel1.TabIndex = 11;
         // 
         // bunifuSeparator3
         // 
         this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator3.LineThickness = 3;
         this.bunifuSeparator3.Location = new System.Drawing.Point(19, 99);
         this.bunifuSeparator3.Name = "bunifuSeparator3";
         this.bunifuSeparator3.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator3.TabIndex = 31;
         this.bunifuSeparator3.Transparency = 255;
         this.bunifuSeparator3.Vertical = false;
         // 
         // txtApellido
         // 
         this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtApellido.ForeColor = System.Drawing.Color.Gray;
         this.txtApellido.Location = new System.Drawing.Point(19, 80);
         this.txtApellido.Name = "txtApellido";
         this.txtApellido.Size = new System.Drawing.Size(192, 19);
         this.txtApellido.TabIndex = 30;
         this.txtApellido.Text = "Contraseña";
         // 
         // bunifuSeparator2
         // 
         this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
         this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.bunifuSeparator2.LineThickness = 3;
         this.bunifuSeparator2.Location = new System.Drawing.Point(19, 51);
         this.bunifuSeparator2.Name = "bunifuSeparator2";
         this.bunifuSeparator2.Size = new System.Drawing.Size(192, 15);
         this.bunifuSeparator2.TabIndex = 29;
         this.bunifuSeparator2.Transparency = 255;
         this.bunifuSeparator2.Vertical = false;
         // 
         // txtNombre
         // 
         this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtNombre.ForeColor = System.Drawing.Color.Gray;
         this.txtNombre.Location = new System.Drawing.Point(19, 32);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(192, 19);
         this.txtNombre.TabIndex = 28;
         this.txtNombre.Text = "Usuario";
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
         this.btnAgregar.ButtonText = "Entrar";
         this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleBorderThickness = 1;
         this.btnAgregar.IdleCornerRadius = 20;
         this.btnAgregar.IdleFillColor = System.Drawing.Color.White;
         this.btnAgregar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAgregar.Location = new System.Drawing.Point(19, 131);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(192, 41);
         this.btnAgregar.TabIndex = 32;
         this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // frmInicioSesion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
         this.ClientSize = new System.Drawing.Size(397, 186);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.lblSistema);
         this.Controls.Add(this.pcLogo);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmInicioSesion";
         this.Text = "Inicio de Sesión";
         ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblSistema;
      private System.Windows.Forms.PictureBox pcLogo;
      private System.Windows.Forms.Panel panel1;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
      private System.Windows.Forms.TextBox txtApellido;
      private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
      private System.Windows.Forms.TextBox txtNombre;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
   }
}