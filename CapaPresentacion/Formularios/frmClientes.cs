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
  public partial class frmClientes : Form
  {
    public frmClientes()
    {
      InitializeComponent();
    }

    private void CargarClientes()
    {
      clsClientes clien = new clsClientes();
      Cliente c = new Cliente();

      List<Cliente> lstClie = clien.LeerListado();

      foreach(Cliente item in lstClie)
      {
        this.dtgvClientes.Rows.Add(item.Id_Clie, item.Nombre, item.Apellido, item.Dni, item.E_mail);
      }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      clsClientes cli = new clsClientes();
      Cliente c = new Cliente();

      //c.Nombre = txtNombre.Text;
      //c.Apellido = txtApellido.Text;
      //c.Dni = Convert.ToInt32(txtDni.Text);
      //c.E_mail = txtemail.Text;

      int crearcli=cli.Crear(c);

      if (crearcli == 1)
      {
        MessageBox.Show("Hoadfa");
      }
      else
      {
        MessageBox.Show("sdgsdggddgsdgsd");
      }
    }

    private void frmClientes_Load(object sender, EventArgs e)
    {
      CargarClientes();
    }

    private void swNocturno_Click(object sender, EventArgs e)
    {
      bool band=swNocturno.Value;

      if (swNocturno.Value == false)
      {
        this.BackColor = Color.FromArgb(63, 63, 70);
        btnAgregar.IdleFillColor = Color.White;
        btnCancelar.IdleFillColor = Color.White;
        btnEditar.IdleFillColor = Color.White;
        btnEliminar.IdleFillColor = Color.White;
        btnGuardar.IdleFillColor = Color.White;

        txtApellido.LineIdleColor = Color.White;
        txtDni.LineIdleColor = Color.White;
        txtEmail.LineIdleColor = Color.White;
        txtNombre.LineIdleColor = Color.White;
        txtObservacion.LineIdleColor = Color.White;

        txtApellido.ForeColor = Color.White;
        txtDni.ForeColor = Color.White;
        txtEmail.ForeColor = Color.White;
        txtNombre.ForeColor = Color.White;
        txtObservacion.ForeColor = Color.White;

        lblNoct.ForeColor = Color.White;
      }
      else if (swNocturno.Value == true)
      {
        this.BackColor = Color.White;

        btnAgregar.IdleFillColor = Color.White;
        btnCancelar.IdleFillColor = Color.White;
        btnEditar.IdleFillColor = Color.White;
        btnEliminar.IdleFillColor = Color.White;
        btnGuardar.IdleFillColor = Color.White;

        txtApellido.LineIdleColor = Color.FromArgb(63, 63, 70);
        txtDni.LineIdleColor = Color.FromArgb(63, 63, 70);
        txtEmail.LineIdleColor = Color.FromArgb(63, 63, 70);
        txtNombre.LineIdleColor = Color.FromArgb(63, 63, 70);
        txtObservacion.LineIdleColor = Color.FromArgb(63, 63, 70);

        txtApellido.ForeColor = Color.FromArgb(63, 63, 70);
        txtDni.ForeColor = Color.FromArgb(63, 63, 70);
        txtEmail.ForeColor = Color.FromArgb(63, 63, 70);
        txtNombre.ForeColor = Color.FromArgb(63, 63, 70);
        txtObservacion.ForeColor = Color.FromArgb(63, 63, 70);

        lblNoct.ForeColor = Color.Gray;
      }
    }

    private void BorrarContenido(Control c)
    {
        c.Text = "";
    }

    private void txtNombre_MouseClick(object sender, MouseEventArgs e)
    {
        BorrarContenido(txtNombre);   
    }

    private void txtNombre_Click(object sender, EventArgs e)
    {

    }
  }
}
