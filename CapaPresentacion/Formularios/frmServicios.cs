using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
   public partial class frmServicios : Form
   {
      public frmServicios()
      {
         InitializeComponent();
      }

      private void btnExpandir_Click(object sender, EventArgs e)
      {
         btnExpandir.Visible = false;
         btnMinimizar.Visible = true;
         pnTS.Visible = true;
         pnS.Visible = true;

         btnAgregar.Visible = true;
         btnCancelar.Visible = true;
         btnEditar.Visible = true;
         btnEliminar.Visible = true;

         dtgvTipoServicios.Size = new Size(882, 301); //882; 301 minimazado
      }

      private void btnMinimizar_Click(object sender, EventArgs e)
      {
         btnExpandir.Visible = true;
         btnMinimizar.Visible = false;
         pnTS.Visible = false;
         pnS.Visible = false;

         btnAgregar.Visible = false;
         btnCancelar.Visible = false;
         btnEditar.Visible = false;
         btnEliminar.Visible = false;

         dtgvTipoServicios.Size = new Size(882, 481); //882; 301 minimazado
      }

      private void btnServicio_Click(object sender, EventArgs e)
      {
         if (pnS.Visible)
         {
            pnS.Visible = false;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;

            dtgvTipoServicios.Size = new Size(882, 481);
         }
         else
         {
            pnS.Visible = true;

            btnAgregar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;

            dtgvTipoServicios.Size = new Size(882, 301);
         }
      }

      private void btnTipoS_Click(object sender, EventArgs e)
      {
         if (pnTS.Visible)
         {
            pnTS.Visible = false;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;

            dtgvTipoServicios.Size = new Size(882, 481);
         }
         else
         {
            pnTS.Visible = true;

            btnAgregar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;

            dtgvTipoServicios.Size = new Size(882, 301);
         }
      }
   }
}
