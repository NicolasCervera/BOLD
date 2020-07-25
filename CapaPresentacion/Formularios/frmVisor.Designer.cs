namespace CapaPresentacion.Formularios
{
   partial class frmVisor
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisor));
         this.crVisor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
         this.SuspendLayout();
         // 
         // crVisor
         // 
         this.crVisor.ActiveViewIndex = -1;
         this.crVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.crVisor.Cursor = System.Windows.Forms.Cursors.Default;
         this.crVisor.Dock = System.Windows.Forms.DockStyle.Fill;
         this.crVisor.Location = new System.Drawing.Point(0, 0);
         this.crVisor.Name = "crVisor";
         this.crVisor.Size = new System.Drawing.Size(898, 548);
         this.crVisor.TabIndex = 0;
         this.crVisor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
         // 
         // frmVisor
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(898, 548);
         this.Controls.Add(this.crVisor);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "frmVisor";
         this.Text = "Visor";
         this.ResumeLayout(false);

      }

      #endregion

      public CrystalDecisions.Windows.Forms.CrystalReportViewer crVisor;
   }
}