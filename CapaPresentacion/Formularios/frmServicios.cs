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
   public partial class frmServicios : Form
   {
      public frmServicios()
      {
         InitializeComponent();
      }

      string text;
      int idServ;
      int idTSer;
      bool editar = false;

      private void CargarServiciosDisponibles()
      {
         clsServicios serv = new clsServicios();
         Servicio c = new Servicio();
         List<Servicio> lst = serv.LeerListadoServicioDisponibles();
         lst.Add(new Servicio { Id_Serv = 0, Nombre = "" });

         cmbServicios.ValueMember = "Id_Serv";
         cmbServicios.DisplayMember = "Nombre";
         cmbServicios.DataSource = lst;

         cmbServicios.SelectedIndex = lst.Count - 1;

         cmbServPn.ValueMember = "Id_Serv";
         cmbServPn.DisplayMember = "Nombre";
         cmbServPn.DataSource = lst;

         cmbServPn.SelectedIndex = lst.Count - 1;
      }

      private void CargarServicios()
      {
         clsServicios serv = new clsServicios();
         Servicio c = new Servicio();
         List<Servicio> lst = serv.LeerListadoServicio();
         
         foreach(Servicio item in lst)
         {
            dtgvServicios.Rows.Add(item.Id_Serv, item.Nombre, item.Observacion, item.Estado);
         }
      }

      private void CargarTiposServicio()
      {
         clsServicios serv = new clsServicios();
         List<TipoServicio> lst = serv.LeerListadoTipoServicio();
         
         foreach(TipoServicio item in lst)
         {
            dtgvTipoServicios.Rows.Add(item.Id_Serv, item.Id_TS, item.Servicio.Nombre, item.Nombre, item.Duracion, item.Precio, item.Detalle, item.Estado);
         }
      }

      private void Filtro()
      {
         dtgvTipoServicios.Rows.Clear();
         string ser="";

         if (cmbServicios.Text != "")
         {
            ser = cmbServicios.Text;
         }
         else
         {
            MessageBox.Show("Por favor debe se seleccionar un servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }

         clsServicios serv = new clsServicios();
         List<TipoServicio> lst = serv.FiltroTipoServicio(ser);
         
         foreach (TipoServicio item in lst)
         {
            dtgvTipoServicios.Rows.Add(item.Id_Serv, item.Id_TS, item.Servicio.Nombre, item.Nombre, item.Duracion, item.Precio, item.Detalle, item.Estado);
         }
      }

      private void ReseteoTextos()
      {
         txtNombreServicio.Text = "Nombre";
         txtNombreTS.Text = "Nombre";
         txtObservacionServicio.Text = "Observación";
         txtObservacionTS.Text = "Observación";
         txtPrecio.Text = "Precio";
         txtDuracionTS.ResetText();
      }

      private void btnExpandir_Click(object sender, EventArgs e)
      {
         btnExpandir.Visible = false;
         btnMinimizar.Visible = true;
         pnTS.Visible = false;
         pnS.Visible = false;

         btnAgregar.Visible = false;
         btnCancelar.Visible = false;
         btnEditar.Visible = false;
         btnEliminar.Visible = false;

         dtgvTipoServicios.Size = new Size(882, 481); //882; 301 minimazado
         dtgvServicios.Size = new Size(882, 481);
      }

      private void btnMinimizar_Click(object sender, EventArgs e)
      {
         btnExpandir.Visible = true;
         btnMinimizar.Visible = false;
         pnTS.Visible = true;
         pnS.Visible = true;

         btnAgregar.Visible = true;
         btnCancelar.Visible = true;
         btnEditar.Visible = true;
         btnEliminar.Visible = true;

         dtgvTipoServicios.Size = new Size(882, 301); //882; 301 minimazado
         dtgvServicios.Size=new Size(882, 301);
      }

      private void btnServicio_Click(object sender, EventArgs e)
      {
         if (pnS.Visible)
         {
            pnTS.Visible = false;
            pnS.Visible = false;

            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = false;
            btnEliminar.Visible = false;

            dtgvServicios.Size = new Size(882, 481);
         }
         else
         {
            dtgvServicios.Rows.Clear();
            CargarServicios();

            dtgvTipoServicios.Visible = false;
            dtgvServicios.Visible = true;

            pnTS.Visible = false;
            pnS.Visible = true;

            btnAgregar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;

            dtgvServicios.Size = new Size(882, 301);
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
            dtgvServicios.Visible = false;
            dtgvTipoServicios.Visible = true;

            pnS.Visible = false;
            pnTS.Visible = true;

            btnAgregar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = true;
            btnEliminar.Visible = true;

            dtgvTipoServicios.Size = new Size(882, 301);
         }
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         try
         {
            clsServicios serv = new clsServicios();
            Servicio s = new Servicio();
            TipoServicio ts = new TipoServicio();


            if (txtNombreTS.Text == "Nombre" && txtNombreServicio.Text == "Nombre")
            {
               MessageBox.Show("Por favor debe de agregar un servicio ó un tipo de servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               if (txtNombreTS.Text != "Nombre")
               {
                  if (txtDuracionTS.Text == "  :")
                  {
                     txtDuracionTS.Text = "00:00";
                  }

                  ts.Nombre = txtNombreTS.Text;
                  ts.Precio = Convert.ToInt32(txtPrecio.Text);
                  ts.Detalle = txtObservacionTS.Text;
                  ts.Duracion = TimeSpan.Parse(txtDuracionTS.Text);
                  ts.Estado = "Disponible";
                  ts.Id_Serv = cmbServPn.SelectedIndex + 1;

                  int CrearTipoServicio = serv.CrearTipoServicio(ts);

                  if (CrearTipoServicio == 1)
                  {
                     dtgvTipoServicios.Rows.Clear();
                     cmbServicios.DataSource = null;
                     cmbServPn.DataSource = null;
                     CargarServiciosDisponibles();
                     CargarTiposServicio();
                     ReseteoTextos();
                  }
                  else
                  {
                     MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     dtgvTipoServicios.Rows.Clear();
                     CargarServiciosDisponibles();
                     CargarTiposServicio();
                     ReseteoTextos();
                  }
               }
               else if (txtNombreServicio.Text != "Nombre")
               {
                  s.Nombre = txtNombreServicio.Text;
                  s.Observacion = txtObservacionServicio.Text;
                  s.Estado = "Disponible";

                  int CrearServicio = serv.CrearServicio(s);

                  if (CrearServicio == 1)
                  {
                     cmbServicios.DataSource = null;
                     CargarServicios();
                     CargarServiciosDisponibles();
                     ReseteoTextos();
                  }
                  else
                  {
                     MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      private void txtNombreTS_Click(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;
         text = t.Text;

         t.Clear();
      }

      private void txtNombreTS_Leave(object sender, EventArgs e)
      {
         TextBox t = (TextBox)sender;

         if (t.Text == "")
         {
            t.Text = text;
         }
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         ReseteoTextos();
         btnGuardar.Visible = false;
         btnEditar.Visible = true;
      }

      private void frmServicios_Load(object sender, EventArgs e)
      {
         CargarServiciosDisponibles();
         CargarServicios();
         CargarTiposServicio();
      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {
         try
         {
            clsServicios serv = new clsServicios();
            Servicio s = new Servicio();
            TipoServicio ts = new TipoServicio();

            if(dtgvServicios.Visible)
            {
               s.Estado = "No Disponible";
               s.Nombre = dtgvServicios.CurrentRow.Cells["Nombre"].Value.ToString();
               s.Observacion = dtgvServicios.CurrentRow.Cells["Observacion"].Value.ToString();
               s.Id_Serv = Convert.ToInt32(dtgvServicios.CurrentRow.Cells["idS"].Value.ToString());

               int ActualizarServicio = serv.ActualizarServicio(s);

               if (ActualizarServicio == 1)
               {
                  cmbServicios.DataSource = null;
                  CargarServicios();
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
            else if(dtgvTipoServicios.Visible)
            {
               string estado= dtgvTipoServicios.CurrentRow.Cells["EstadoTS"].Value.ToString();
               
               if(estado=="No Disponible")
               {
                  MessageBox.Show("Este tipo de servicio ya está inhabilitado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }
               else
               {
                  ts.Id_TS = Convert.ToInt32(dtgvTipoServicios.CurrentRow.Cells["idTS"].Value);
                  ts.Id_Serv = Convert.ToInt32(dtgvTipoServicios.CurrentRow.Cells["idS"].Value);
                  ts.Nombre = dtgvTipoServicios.CurrentRow.Cells["Tipo_de_Servicio"].Value.ToString();
                  ts.Detalle = dtgvTipoServicios.CurrentRow.Cells["Detalle"].Value.ToString();
                  ts.Precio = Convert.ToInt32(dtgvTipoServicios.CurrentRow.Cells["Precio"].Value.ToString());
                  ts.Duracion = TimeSpan.Parse(dtgvTipoServicios.CurrentRow.Cells["Duracion"].Value.ToString());
                  ts.Estado = "No Disponible";

                  int ActualizarTipServicio = serv.ActualizarTipoServicio(ts);

                  if (ActualizarTipServicio == 1)
                  {
                     this.dtgvTipoServicios.Rows.Clear();
                     cmbServicios.DataSource = null;
                     CargarServicios();
                     CargarTiposServicio();
                     ReseteoTextos();
                  }
                  else
                  {
                     MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      private void cmbServicios_DropDownClosed(object sender, EventArgs e)
      {
         idServ = cmbServicios.SelectedIndex + 1;

         clsServicios serv = new clsServicios();
         List<Servicio> lst = serv.LeerListadoServicio();

         foreach(Servicio item in lst)
         {
            if(item.Id_Serv==idServ)
            {
               txtNombreServicio.Text = item.Nombre;
               txtObservacionServicio.Text = item.Observacion;
            }
         }
      }

      private void btnEditar_Click(object sender, EventArgs e)
      {
         try
         {
            if (dtgvServicios.Visible)
            {
               if (dtgvServicios.Rows.Count > 0)
               {
                  if (dtgvServicios.SelectedRows.Count > 0)
                  {
                     editar = true;

                     idServ = Convert.ToInt32(dtgvServicios.CurrentRow.Cells["idServic"].Value);
                     txtNombreServicio.Text = dtgvServicios.CurrentRow.Cells["Nombre"].Value.ToString();
                     txtObservacionServicio.Text = dtgvServicios.CurrentRow.Cells["Observacion"].Value.ToString();
                     cmbEstado.Text = dtgvServicios.CurrentRow.Cells["Estado"].Value.ToString();

                     btnEditar.Visible = false;
                     btnGuardar.Visible = true;
                  }
                  else
                  {
                     MessageBox.Show("Debe de seleccionar al menos un servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
               }
            }
            else if (dtgvTipoServicios.Visible)
            {
               if (dtgvTipoServicios.Rows.Count > 0)
               {
                  if (dtgvTipoServicios.SelectedRows.Count > 0)
                  {
                     editar = true;
                     
                     idTSer = Convert.ToInt32(dtgvTipoServicios.CurrentRow.Cells["idTS"].Value);
                     idServ = Convert.ToInt32(dtgvTipoServicios.CurrentRow.Cells["idS"].Value);
                     txtNombreTS.Text = dtgvTipoServicios.CurrentRow.Cells["Tipo_de_Servicio"].Value.ToString();
                     txtObservacionTS.Text = dtgvTipoServicios.CurrentRow.Cells["Detalle"].Value.ToString();
                     txtPrecio.Text = dtgvTipoServicios.CurrentRow.Cells["Precio"].Value.ToString();
                     txtDuracionTS.Text = dtgvTipoServicios.CurrentRow.Cells["Duracion"].Value.ToString();
                     cmbServPn.Text= dtgvTipoServicios.CurrentRow.Cells["Serv"].Value.ToString();
                     cmbEstadoTS.Text = dtgvTipoServicios.CurrentRow.Cells["EstadoTS"].Value.ToString();

                     btnEditar.Visible = false;
                     btnGuardar.Visible = true;
                  }
                  else
                  {
                     MessageBox.Show("Debe de seleccionar al menos un servicio.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

      private void btnGuardar_Click(object sender, EventArgs e)
      {
         try
         {
            clsServicios serv = new clsServicios();
            Servicio s = new Servicio();
            TipoServicio ts = new TipoServicio();

            if(dtgvServicios.Visible)
            {
               s.Id_Serv = idServ;
               s.Nombre = txtNombreServicio.Text;
               s.Observacion = txtObservacionServicio.Text;
               s.Estado = cmbEstado.Text;

               int ActualizarServicio = serv.ActualizarServicio(s);

               if (ActualizarServicio == 1)
               {
                  cmbServicios.DataSource = null;
                  dtgvServicios.Rows.Clear();
                  CargarServicios();
                  CargarServiciosDisponibles();
                  ReseteoTextos();

                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
               }
               else
               {
                  MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
                  ReseteoTextos();
               }
            }
            else if(dtgvTipoServicios.Visible)
            {
               ts.Id_TS = idTSer;
               ts.Id_Serv = cmbServPn.SelectedIndex + 1;
               ts.Nombre = txtNombreTS.Text;
               ts.Precio = Convert.ToInt32(txtPrecio.Text);
               ts.Estado = cmbEstadoTS.Text;
               ts.Detalle = txtObservacionTS.Text;
               ts.Duracion = TimeSpan.Parse(txtDuracionTS.Text);

               int ActualizarTS = serv.ActualizarTipoServicio(ts);

               if (ActualizarTS == 1)
               {
                  cmbServicios.DataSource = null;
                  dtgvTipoServicios.Rows.Clear();
                  CargarServiciosDisponibles();
                  CargarTiposServicio();
                  ReseteoTextos();

                  btnGuardar.Visible = false;
                  btnEditar.Visible = true;
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

      private void cmbServicios_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            Filtro();
         }
      }
   }
}
