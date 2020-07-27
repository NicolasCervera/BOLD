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

namespace CapaPresentacion.Formularios
{
   public partial class frmPersonal : Form
   {
      public frmPersonal()
      {
         InitializeComponent();
      }

      bool editar = false;
      string text;
      int idCa;
      int idPer;

      private void CargaCargo()
      {
         clsPersonal pers = new clsPersonal();
         Cargo c = new Cargo();
         List<Cargo> lst = pers.LeerListadoDisponibles();
         lst.Add(new Cargo { Id_Cargo = 0, Nombre = "" });

         cmbCargo.ValueMember = "Id_Cargo";
         cmbCargo.DisplayMember = "Nombre";
         cmbCargo.DataSource = lst;

         cmbCargo.SelectedIndex = lst.Count - 1;
      }

      private void CargaPersonal()
      {
         clsPersonal pers = new clsPersonal();
         Personal per = new Personal();
         List<Personal> lst = pers.LeerListadoPersonalDisponible();

         foreach (Personal item in lst)
         {
            dtgvPersonal.Rows.Add(item.Id_Pers, item.Id_Cargo, item.Cargo.Nombre, item.Nombre, item.Apellido, item.Dni, item.Fecha_Nacimiento /*item.Telefono*/,
            item.Sueldo, item.Detalle, item.Nick, item.Clave);
         }
      }

      private void ReseteoTexto()
      {
         txtApellido.Text = "Apellido";
         txtContraseña.Text = "Contraseña";
         txtDni.Text = "DNI";
         txtNick.Text = "Nick";
         txtNombre.Text = "Nombre";
         txtTelefono.Text = "Teléfono-Celular";
         txtSueldo.Text = "Sueldo";
         cmbCargo.ResetText();
         dtmFechaNac.ResetText();
      }

      private void frmPersonal_Load(object sender, EventArgs e)
      {
         CargaCargo();
         CargaPersonal();
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         try
         {
            if (!editar)
            {
               clsPersonal pers = new clsPersonal();
               Personal p = new Personal();

               p.Nombre = txtNombre.Text;
               p.Apellido = txtApellido.Text;
               p.Dni = txtDni.Text;
               p.Nick = txtNick.Text;
               p.Detalle = txtDetalle.Text;
               //p.Telefono = txtTelefono.Text;
               p.Sueldo = Convert.ToInt32(txtSueldo.Text);
               p.Clave = txtContraseña.Text;
               p.Fecha_Nacimiento = Convert.ToDateTime(dtmFechaNac.Value.ToShortDateString());
               p.Estado = "Disponible";
               p.Id_Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
               p.Fecha_Ingreso = Convert.ToDateTime(DateTime.Now.ToShortDateString());

               int crearcli = pers.CrearPersonal(p);

               if (crearcli == 1)
               {
                  dtgvPersonal.Rows.Clear();
                  CargaPersonal();
                  ReseteoTexto();
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  ReseteoTexto();
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

      private void txtNombre_Click(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;
         text = t.Text;

         t.Clear();
      }

      private void txtNombre_Leave(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;

         if (t.Text == "")
         {
            t.Text = text;
         }
      }

      private void btnEditar_Click(object sender, EventArgs e)
      {
         if (dtgvPersonal.Rows.Count > 0)
         {
            if (dtgvPersonal.SelectedRows.Count > 0)
            {
               editar = true;

               idCa = Convert.ToInt32(dtgvPersonal.CurrentRow.Cells["IdCarg"].Value);
               idPer = Convert.ToInt32(dtgvPersonal.CurrentRow.Cells["IdPers"].Value);
               txtNombre.Text = dtgvPersonal.CurrentRow.Cells["Nombre"].Value.ToString();
               txtApellido.Text = dtgvPersonal.CurrentRow.Cells["Apellido"].Value.ToString();
               txtDni.Text = dtgvPersonal.CurrentRow.Cells["DNI"].Value.ToString();
               txtTelefono.Text = dtgvPersonal.CurrentRow.Cells["Telefono"].Value.ToString();
               txtSueldo.Text = dtgvPersonal.CurrentRow.Cells["Sueldo"].Value.ToString();
               dtmFechaNac.Value = Convert.ToDateTime(dtgvPersonal.CurrentRow.Cells["Edad"].Value.ToString());
               txtNick.Text= dtgvPersonal.CurrentRow.Cells["Nick"].Value.ToString();
               txtContraseña.Text= dtgvPersonal.CurrentRow.Cells["Clave"].Value.ToString();
               cmbCargo.Text= dtgvPersonal.CurrentRow.Cells["Cargo"].Value.ToString();

               btnEditar.Visible = false;
               btnGuardar.Visible = true;
            }
            else
            {
               MessageBox.Show("Debe de seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
         else
         {
            MessageBox.Show("No existe ningún personal. Por favor cree uno nuevo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            if (editar)
            {
               clsPersonal pers = new clsPersonal();
               Personal p = new Personal();

               p.Id_Cargo = Convert.ToInt32(cmbCargo.SelectedValue);
               p.Id_Pers = idPer;
               p.Nombre = txtNombre.Text;
               p.Apellido = txtApellido.Text;
               p.Dni = txtDni.Text;
               p.Sueldo = Convert.ToInt32(txtSueldo.Text);
               //p.Telefono = txtTelefono.Text;
               p.Detalle = txtDetalle.Text;
               p.Fecha_Nacimiento = dtmFechaNac.Value;
               p.Nick = txtNick.Text;
               p.Clave = txtContraseña.Text;
               p.Estado = "Disponible";

               int ActualizarCliente = pers.ActualizarPersonal(p);

               if (ActualizarCliente == 1)
               {
                  dtgvPersonal.Rows.Clear();
                  CargaPersonal();
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
                  ReseteoTexto();
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
                  ReseteoTexto();
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
