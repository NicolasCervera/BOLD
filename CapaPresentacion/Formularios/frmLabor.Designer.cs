namespace CapaPresentacion.Formularios
{
   partial class frmLabor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLabor));
         this.gpbFavoritos = new System.Windows.Forms.GroupBox();
         this.btnCorte = new Bunifu.Framework.UI.BunifuThinButton2();
         this.btnCorteBarba = new Bunifu.Framework.UI.BunifuThinButton2();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.numericCant = new System.Windows.Forms.NumericUpDown();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.cmbTS = new System.Windows.Forms.ComboBox();
         this.btnAceptar = new Bunifu.Framework.UI.BunifuThinButton2();
         this.gpbFavoritos.SuspendLayout();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericCant)).BeginInit();
         this.SuspendLayout();
         // 
         // gpbFavoritos
         // 
         this.gpbFavoritos.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.gpbFavoritos.Controls.Add(this.btnCorteBarba);
         this.gpbFavoritos.Controls.Add(this.btnCorte);
         this.gpbFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gpbFavoritos.ForeColor = System.Drawing.Color.Gray;
         this.gpbFavoritos.Location = new System.Drawing.Point(12, 12);
         this.gpbFavoritos.Name = "gpbFavoritos";
         this.gpbFavoritos.Size = new System.Drawing.Size(214, 325);
         this.gpbFavoritos.TabIndex = 38;
         this.gpbFavoritos.TabStop = false;
         this.gpbFavoritos.Text = "Accesos Rápidos:";
         // 
         // btnCorte
         // 
         this.btnCorte.ActiveBorderThickness = 1;
         this.btnCorte.ActiveCornerRadius = 10;
         this.btnCorte.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnCorte.ActiveForecolor = System.Drawing.Color.White;
         this.btnCorte.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnCorte.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnCorte.BackColor = System.Drawing.Color.White;
         this.btnCorte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorte.BackgroundImage")));
         this.btnCorte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCorte.ButtonText = "Corte";
         this.btnCorte.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCorte.ForeColor = System.Drawing.Color.Black;
         this.btnCorte.IdleBorderThickness = 1;
         this.btnCorte.IdleCornerRadius = 20;
         this.btnCorte.IdleFillColor = System.Drawing.Color.White;
         this.btnCorte.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCorte.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCorte.Location = new System.Drawing.Point(9, 83);
         this.btnCorte.Margin = new System.Windows.Forms.Padding(5);
         this.btnCorte.Name = "btnCorte";
         this.btnCorte.Size = new System.Drawing.Size(194, 89);
         this.btnCorte.TabIndex = 37;
         this.btnCorte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnCorteBarba
         // 
         this.btnCorteBarba.ActiveBorderThickness = 1;
         this.btnCorteBarba.ActiveCornerRadius = 10;
         this.btnCorteBarba.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnCorteBarba.ActiveForecolor = System.Drawing.Color.White;
         this.btnCorteBarba.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnCorteBarba.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnCorteBarba.BackColor = System.Drawing.Color.White;
         this.btnCorteBarba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorteBarba.BackgroundImage")));
         this.btnCorteBarba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnCorteBarba.ButtonText = "Corte + Barba";
         this.btnCorteBarba.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnCorteBarba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCorteBarba.ForeColor = System.Drawing.Color.Black;
         this.btnCorteBarba.IdleBorderThickness = 1;
         this.btnCorteBarba.IdleCornerRadius = 20;
         this.btnCorteBarba.IdleFillColor = System.Drawing.Color.White;
         this.btnCorteBarba.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCorteBarba.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnCorteBarba.Location = new System.Drawing.Point(9, 171);
         this.btnCorteBarba.Margin = new System.Windows.Forms.Padding(5);
         this.btnCorteBarba.Name = "btnCorteBarba";
         this.btnCorteBarba.Size = new System.Drawing.Size(194, 89);
         this.btnCorteBarba.TabIndex = 38;
         this.btnCorteBarba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.groupBox1.Controls.Add(this.btnAceptar);
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.numericCant);
         this.groupBox1.Controls.Add(this.txtDescripcion);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.cmbTS);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.Gray;
         this.groupBox1.Location = new System.Drawing.Point(420, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(466, 325);
         this.groupBox1.TabIndex = 39;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Favoritos:";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Gray;
         this.label3.Location = new System.Drawing.Point(12, 254);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(77, 20);
         this.label3.TabIndex = 32;
         this.label3.Text = "Cantidad:";
         // 
         // numericCant
         // 
         this.numericCant.Location = new System.Drawing.Point(12, 277);
         this.numericCant.Name = "numericCant";
         this.numericCant.Size = new System.Drawing.Size(287, 26);
         this.numericCant.TabIndex = 31;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.Location = new System.Drawing.Point(12, 114);
         this.txtDescripcion.Multiline = true;
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(287, 123);
         this.txtDescripcion.TabIndex = 30;
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Gray;
         this.label2.Location = new System.Drawing.Point(12, 91);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(96, 20);
         this.label2.TabIndex = 29;
         this.label2.Text = "Descripción:";
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Gray;
         this.label1.Location = new System.Drawing.Point(12, 28);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(102, 20);
         this.label1.TabIndex = 28;
         this.label1.Text = "Tipo Servicio:";
         // 
         // cmbTS
         // 
         this.cmbTS.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbTS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cmbTS.FormattingEnabled = true;
         this.cmbTS.Location = new System.Drawing.Point(12, 51);
         this.cmbTS.Name = "cmbTS";
         this.cmbTS.Size = new System.Drawing.Size(287, 26);
         this.cmbTS.TabIndex = 27;
         // 
         // btnAceptar
         // 
         this.btnAceptar.ActiveBorderThickness = 1;
         this.btnAceptar.ActiveCornerRadius = 10;
         this.btnAceptar.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
         this.btnAceptar.ActiveForecolor = System.Drawing.Color.White;
         this.btnAceptar.ActiveLineColor = System.Drawing.Color.LightSeaGreen;
         this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnAceptar.BackColor = System.Drawing.Color.White;
         this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
         this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnAceptar.ButtonText = "Aceptar";
         this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAceptar.ForeColor = System.Drawing.Color.Black;
         this.btnAceptar.IdleBorderThickness = 1;
         this.btnAceptar.IdleCornerRadius = 20;
         this.btnAceptar.IdleFillColor = System.Drawing.Color.White;
         this.btnAceptar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAceptar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
         this.btnAceptar.Location = new System.Drawing.Point(331, 18);
         this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(127, 40);
         this.btnAceptar.TabIndex = 40;
         this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // frmLabor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(898, 548);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.gpbFavoritos);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmLabor";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmLabor";
         this.gpbFavoritos.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.numericCant)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.GroupBox gpbFavoritos;
      private Bunifu.Framework.UI.BunifuThinButton2 btnCorte;
      private Bunifu.Framework.UI.BunifuThinButton2 btnCorteBarba;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown numericCant;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.ComboBox cmbTS;
      private Bunifu.Framework.UI.BunifuThinButton2 btnAceptar;
   }
}