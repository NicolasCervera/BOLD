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
   public partial class frmCargo : Form
   {
      public frmCargo()
      {
         InitializeComponent();
      }

      bool editar = false;
      int idCarg;
      string text;

      private void CargarCargos()
      {
         clsPersonal pers = new clsPersonal();
         List<Cargo> lst = pers.LeerListado();

         foreach (Cargo item in lst)
         {
            dtgvCargo.Rows.Add(item.Id_Cargo, item.Nombre, item.Descripcion, item.Estado);
         }
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         try
         {

            clsPersonal pers = new clsPersonal();
            Cargo c = new Cargo();

            c.Nombre = txtNombre.Text;
            c.Descripcion = txtDescripcion.Text;
            c.Estado = "Disponible";

            int crearcli = pers.Crear(c);

            if (crearcli == 1)
            {
               dtgvCargo.Rows.Clear();
               CargarCargos();

               txtDescripcion.Text = "Descripción";
               txtEstado.Text = "Estado";
               txtNombre.Text = "Nombre";

            }
            else
            {
               MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      private void btnEditar_Click(object sender, EventArgs e)
      {
         if (dtgvCargo.Rows.Count > 0)
         {
            if (dtgvCargo.SelectedRows.Count > 0)
            {
               editar = true;

               idCarg = Convert.ToInt32(dtgvCargo.CurrentRow.Cells["idC"].Value);
               txtNombre.Text = dtgvCargo.CurrentRow.Cells["Nombre_de_Cargo"].Value.ToString();
               txtDescripcion.Text = dtgvCargo.CurrentRow.Cells["Descripcion_de_Cargo"].Value.ToString();
               txtEstado.Text = dtgvCargo.CurrentRow.Cells["Estado"].Value.ToString();

               btnEditar.Visible = false;
               btnGuardar.Visible = true;
            }
            else
            {
               MessageBox.Show("Debe de seleccionar un cargo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         }
      }

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            if (editar)
            {
               clsPersonal carg = new clsPersonal();
               Cargo c = new Cargo();

               c.Id_Cargo = idCarg;
               c.Nombre = txtNombre.Text;
               c.Descripcion = txtDescripcion.Text;
               c.Estado = txtEstado.Text;

               int ActualizarCliente = carg.Actualizar(c);

               if (ActualizarCliente == 1)
               {
                  dtgvCargo.Rows.Clear();
                  CargarCargos();
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;

                  txtDescripcion.Text = "Descripción";
                  txtEstado.Text = "Estado";
                  txtNombre.Text = "Nombre";
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;

                  txtDescripcion.Text = "Descripción";
                  txtEstado.Text = "Estado";
                  txtNombre.Text = "Nombre";
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
            Cargo c = new Cargo();
            clsPersonal pers = new clsPersonal();
            List<Cargo> lst = pers.LeerListado();

            if (dtgvCargo.Rows.Count > 0)
            {
               if (dtgvCargo.SelectedRows.Count > 0)
               {
                  editar = true;

                  c.Id_Cargo = Convert.ToInt32(dtgvCargo.CurrentRow.Cells["idC"].Value);

                  foreach (Cargo item in lst)
                  {
                     if (item.Id_Cargo == c.Id_Cargo)
                     {
                        c.Nombre = item.Nombre;
                        c.Descripcion = item.Descripcion;
                        c.Estado = "No Disponible";
                     }
                  }

                  int ActualizarCliente = pers.Actualizar(c);

                  if (ActualizarCliente == 1)
                  {
                     dtgvCargo.Rows.Clear();
                     CargarCargos();
                     btnGuardar.Visible = false;
                     btnEditar.Visible = true;

                     txtDescripcion.Text = "Descripción";
                     txtEstado.Text = "Estado";
                     txtNombre.Text = "Nombre";
                  }
                  else
                  {
                     MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     btnGuardar.Visible = false;
                     btnEditar.Visible = true;

                     txtDescripcion.Text = "Descripción";
                     txtEstado.Text = "Estado";
                     txtNombre.Text = "Nombre";
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

      private void txtEstado_Click(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;
         text = t.Text;

         t.Clear();
      }

      private void txtEstado_Leave(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;

         if (t.Text == "")
         {
            t.Text = text;
         }
      }

      private void frmCargo_Load(object sender, EventArgs e)
      {
         CargarCargos();
      }
   }
}
