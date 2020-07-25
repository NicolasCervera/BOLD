using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
  public partial class frmInicio : Form
  {
    public frmInicio()
    {
      InitializeComponent();
    }

    private void PosicionBoton(Control c, bool band)
    {
        int h;
        int t;

        h = c.Height;
        t = c.Top;

        if (band)
        {
            if (c.Focused)
            {
                pnPosicion.Height = h;
                pnPosicion.Top = t;
            }
        }
        else
        {
            pnPosicion.Height = c.Height;
            pnPosicion.Top = c.Top;
        }
    }

    private void BorrarContenido(Control c)
    {
        c.Text = "";
    }

    #region Posicion Dash

    private void btnClientes_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnClientes, false);

      AbrirFormHijo(new frmClientes());
    }

    private void btnPersonal_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnPersonal, false);

      AbrirFormHijo(new Formularios.frmPersonal());
    }

    private void btnServicios_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnServicios, false);
    }

    private void btnPromociones_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnPromociones, false);
    }

    private void btnCaja_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnCaja, false);
    }

    private void btnRep_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnRep, false);

      if (pnSubRep.Visible == false)
      {
        pnSubRep.Visible = true;
      }
      else
      {
        pnSubRep.Visible = false;
      }
      
    }

    private void btnTurnos_Click(object sender, EventArgs e)
    {
      PosicionBoton(btnTurnos, false);
    }

    private void btnRepFinanzas_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnRepFinanzas, true);
    }

    private void btnRepClientes_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnRepClientes, true);
    }

    private void btnRepServicios_Click(object sender, EventArgs e)
    {
        PosicionBoton(btnRepServicios, true);
    }

    #endregion

    private void btnSlide_Click(object sender, EventArgs e)
    {
      if (pnPrincipal.Width == 220)
      {
        pnPrincipal.Size = new Size(56, 535);
        pcLogo.Location = new Point(-45, 0);
        line.Location = new Point(-1, 53);
      }
      else
      {
        pnPrincipal.Size = new Size(220, 535);
        pcLogo.Location = new Point(39, -1);
        line.Location=new Point(4, 53);
      }
    }

    private void AbrirFormHijo(object formhijo)
    {
      if (this.pnContenedor.Controls.Count > 0)
        this.pnContenedor.Controls.RemoveAt(0);
      
        Form fh = formhijo as Form;
        fh.TopLevel = false;
        fh.Dock = DockStyle.Fill;
        this.pnContenedor.Controls.Add(fh);
        fh.Show();
    }
  }
}
