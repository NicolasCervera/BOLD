using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
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

      #region Variables
      string text;
      bool editar = false;
      int idC;
      #endregion

      #region Cargas y Metodos
      private void CargarClientes()
      {
         clsClientes clien = new clsClientes();
         Cliente c = new Cliente();

         List<Cliente> lstClie = clien.LeerListado();

         foreach (Cliente item in lstClie)
         {
            this.dtgvClientes.Rows.Add(item.Id_Clie, item.Nombre, item.Apellido, item.Dni, item.E_mail, item.Fecha_Nacimiento, item.Detalle, item.Telefono);
         }
      }

      private void BusquedaClientes(string filt)
      {
         //clsClientes clien = new clsClientes();

         //List<V_Clientes> lstClie = clien.LeerPorNumero(filt);

         //foreach (V_Clientes item in lstClie)
         //{
         //   this.dtgvClientes.Rows.Add(item.Id_Clie, item.Nombre, item.Apellido, item.Dni, item.E_mail);
         //}
      }

      private void ReseteoTextos()
      {
         txtApellido.Text = "Apellido";
         txtBusqueda.text = "Buscar";
         txtDni.Text = "DNI";
         txtEmail.Text = "E-Mail";
         txtNombre.Text = "Nombre";
         txtObservacion.Text = "Observación";
         txtTelefono.Text = "Teléfono";
         dtmFechaNac.ResetText();
      }
      #endregion

      private void frmClientes_Load(object sender, EventArgs e)
      {
         CargarClientes();
      }

      private void swNocturno_Click(object sender, EventArgs e)
      {
         bool band = swNocturno.Value;

         if (swNocturno.Value == false)
         {
            this.BackColor = Color.FromArgb(63, 63, 70);
            btnAgregar.IdleFillColor = Color.White;
            btnCancelar.IdleFillColor = Color.White;
            btnEditar.IdleFillColor = Color.White;
            btnEliminar.IdleFillColor = Color.White;
            btnGuardar.IdleFillColor = Color.White;
            
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

            txtApellido.ForeColor = Color.FromArgb(63, 63, 70);
            txtDni.ForeColor = Color.FromArgb(63, 63, 70);
            txtEmail.ForeColor = Color.FromArgb(63, 63, 70);
            txtNombre.ForeColor = Color.FromArgb(63, 63, 70);
            txtObservacion.ForeColor = Color.FromArgb(63, 63, 70);

            lblNoct.ForeColor = Color.Gray;
         }
      }

      private void txtBusqueda_OnTextChange(object sender, EventArgs e)
      {
         if (txtBusqueda.text.Contains("Bu") || txtBusqueda.text.Contains("qu"))
         {
            txtBusqueda.text = "";

            string busqueda;

            busqueda = txtBusqueda.text;

            this.dtgvClientes.Rows.Clear();
            BusquedaClientes(busqueda);
         }
         else
         {
            string busqueda;

            busqueda = txtBusqueda.text;

            this.dtgvClientes.Rows.Clear();
            BusquedaClientes(busqueda);
         }
      }

      private void btnAgregar_Click_1(object sender, EventArgs e)
      {
         try
         {
            if (!editar)
            {
               clsClientes cli = new clsClientes();
               Cliente c = new Cliente();

               c.Nombre = txtNombre.Text;
               c.Apellido = txtApellido.Text;
               c.Dni = Convert.ToInt32(txtDni.Text);
               c.E_mail = txtEmail.Text;
               c.Detalle = txtObservacion.Text;
               c.Fecha_Inscrip = Convert.ToDateTime(DateTime.Now.ToShortDateString());
               c.Telefono = txtTelefono.Text;
               c.Fecha_Nacimiento = Convert.ToDateTime(dtmFechaNac.Value.ToShortDateString());
               c.Estado = "Disponible";

               int crearcli = cli.Crear(c);

               if (crearcli == 1)
               {
                  dtgvClientes.Rows.Clear();
                  CargarClientes();
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
         }
         catch (DbUpdateException)
         {
            MessageBox.Show("Se ha producido un error al enviar actualizaciones a la base de datos.");
         }
         catch (DbEntityValidationException)
         {
            MessageBox.Show("La operación de guardar se anuló debido a que la validación de los valores de propiedad de la entidad falló.");
         }
         catch (NotSupportedException)
         {
            MessageBox.Show("Se intentó utilizar un comportamiento no compatible, como ejecutar varios comandos asíncronos simultáneamente en la misma instancia de contexto.");
         }
         catch (ObjectDisposedException)
         {
            MessageBox.Show("El contexto o la conexión han sido eliminados.");
         }
         catch (InvalidOperationException)
         {
            MessageBox.Show("Se produjo un error al intentar procesar las entidades en el contexto antes o después de enviar comandos a la base de datos.");
         }
         catch (SqlException ex)
         {
            MessageBox.Show("Error número: " + ex.Number + " - " + ex.Message);
         }
         catch (FormatException)
         {
            MessageBox.Show("El formato de un dato no corresponde con sus especificaciones");
         }
         catch (OutOfMemoryException)
         {
            MessageBox.Show("No hay suficiente espacio de memoria para crear un objeto");
         }
         catch (IndexOutOfRangeException)
         {
            MessageBox.Show("Error al intentar acceder a una celda de un arreglo cuyo índice está fuera de rango");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      private void txtNombre_Click_1(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;
         text = t.Text;

         t.Clear();
      }

      private void txtNombre_Leave(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;

         if(t.Text=="")
         {
            t.Text = text;
         }
      }

      private void btnEditar_Click(object sender, EventArgs e)
      {
         if (dtgvClientes.Rows.Count > 0)
         {
            if (dtgvClientes.SelectedRows.Count > 0)
            {
               editar = true;

               idC = Convert.ToInt32(dtgvClientes.CurrentRow.Cells["IdClie"].Value);
               txtNombre.Text = dtgvClientes.CurrentRow.Cells["Nombre"].Value.ToString();
               txtApellido.Text = dtgvClientes.CurrentRow.Cells["Apellido"].Value.ToString();
               txtDni.Text = dtgvClientes.CurrentRow.Cells["DNI"].Value.ToString();
               txtEmail.Text = dtgvClientes.CurrentRow.Cells["E_Mail"].Value.ToString();
               txtObservacion.Text = dtgvClientes.CurrentRow.Cells["Observación"].Value.ToString();
               txtTelefono.Text = dtgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
               dtmFechaNac.Value = Convert.ToDateTime(dtgvClientes.CurrentRow.Cells["Edad"].Value.ToString());

               btnEditar.Visible = false;
               btnGuardar.Visible = true;
            }
            else
            {
               MessageBox.Show("Debe de seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            if (editar)
            {
               clsClientes client = new clsClientes();
               Cliente c = new Cliente();

               c.Id_Clie = idC;
               c.Nombre = txtNombre.Text;
               c.Apellido = txtApellido.Text;
               c.Dni = Convert.ToInt32(txtDni.Text);
               c.E_mail = txtEmail.Text;
               c.Telefono = txtTelefono.Text;
               c.Detalle = txtObservacion.Text;
               c.Fecha_Nacimiento = dtmFechaNac.Value;

               int ActualizarCliente = client.Actualizar(c);

               if (ActualizarCliente == 1)
               {
                  dtgvClientes.Rows.Clear();
                  CargarClientes();
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
                  ReseteoTextos();
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
                  ReseteoTextos();
               }
            }
         }
         catch (DbUpdateException)
         {
            MessageBox.Show("Se ha producido un error al enviar actualizaciones a la base de datos.");
         }
         catch (DbEntityValidationException)
         {
            MessageBox.Show("La operación de guardar se anuló debido a que la validación de los valores de propiedad de la entidad falló.");
         }
         catch (NotSupportedException)
         {
            MessageBox.Show("Se intentó utilizar un comportamiento no compatible, como ejecutar varios comandos asíncronos simultáneamente en la misma instancia de contexto.");
         }
         catch (ObjectDisposedException)
         {
            MessageBox.Show("El contexto o la conexión han sido eliminados.");
         }
         catch (InvalidOperationException)
         {
            MessageBox.Show("Se produjo un error al intentar procesar las entidades en el contexto antes o después de enviar comandos a la base de datos.");
         }
         catch (SqlException ex)
         {
            MessageBox.Show("Error número: " + ex.Number + " - " + ex.Message);
         }
         catch (FormatException)
         {
            MessageBox.Show("El formato de un dato no corresponde con sus especificaciones");
         }
         catch (OutOfMemoryException)
         {
            MessageBox.Show("No hay suficiente espacio de memoria para crear un objeto");
         }
         catch (IndexOutOfRangeException)
         {
            MessageBox.Show("Error al intentar acceder a una celda de un arreglo cuyo índice está fuera de rango");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }


      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {
         try
         {
            Cliente c = new Cliente();
            clsClientes client = new clsClientes();
            List<Cliente> lst = client.LeerListado();

            if (dtgvClientes.Rows.Count > 0)
            {
               if (dtgvClientes.SelectedRows.Count > 0)
               {
                  editar = true;

                  c.Id_Clie = Convert.ToInt32(dtgvClientes.CurrentRow.Cells["IdClie"].Value);

                  foreach (Cliente item in lst)
                  {
                     if (item.Id_Clie == c.Id_Clie)
                     {
                        c.Nombre = item.Nombre;
                        c.Apellido = item.Apellido;
                        c.Dni = item.Dni;
                        c.E_mail = item.E_mail;
                        c.Telefono = item.Telefono;
                        c.Detalle = item.Detalle;
                        c.Fecha_Nacimiento = item.Fecha_Nacimiento;
                        c.Estado = "No Disponible";
                        c.Fecha_Inscrip = item.Fecha_Inscrip;
                     }
                  }

                  int ActualizarCliente = client.Actualizar(c);

                  if (ActualizarCliente == 1)
                  {
                     dtgvClientes.Rows.Clear();
                     CargarClientes();
                     btnGuardar.Visible = false;
                     btnEditar.Visible = true;
                     ReseteoTextos();
                  }
                  else
                  {
                     MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     btnGuardar.Visible = false;
                     btnEditar.Visible = true;
                     ReseteoTextos();
                  }
               }
            }
         }
         catch (DbUpdateException)
         {
            MessageBox.Show("Se ha producido un error al enviar actualizaciones a la base de datos.");
         }
         catch (DbEntityValidationException)
         {
            MessageBox.Show("La operación de guardar se anuló debido a que la validación de los valores de propiedad de la entidad falló.");
         }
         catch (NotSupportedException)
         {
            MessageBox.Show("Se intentó utilizar un comportamiento no compatible, como ejecutar varios comandos asíncronos simultáneamente en la misma instancia de contexto.");
         }
         catch (ObjectDisposedException)
         {
            MessageBox.Show("El contexto o la conexión han sido eliminados.");
         }
         catch (InvalidOperationException)
         {
            MessageBox.Show("Se produjo un error al intentar procesar las entidades en el contexto antes o después de enviar comandos a la base de datos.");
         }
         catch (SqlException ex)
         {
            MessageBox.Show("Error número: " + ex.Number + " - " + ex.Message);
         }
         catch (FormatException)
         {
            MessageBox.Show("El formato de un dato no corresponde con sus especificaciones");
         }
         catch (OutOfMemoryException)
         {
            MessageBox.Show("No hay suficiente espacio de memoria para crear un objeto");
         }
         catch (IndexOutOfRangeException)
         {
            MessageBox.Show("Error al intentar acceder a una celda de un arreglo cuyo índice está fuera de rango");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
   }
}
