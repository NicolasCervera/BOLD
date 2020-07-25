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

namespace CapaPresentacion.Formularios
{
   public partial class frmTurnos : Form
   {
      public frmTurnos()
      {
         InitializeComponent();
      }

      #region Instaciaciones
      clsClientes objclie = new clsClientes();
      clsPersonal objpers = new clsPersonal();
      clsServicios objserv = new clsServicios();
      clsTurnos objturn = new clsTurnos();

      Servicio s = new Servicio();
      TipoServicio ts = new TipoServicio();
      Cliente c = new Cliente();
      Personal p = new Personal();
      Turno t = new Turno();
      DetalleTurno dt = new DetalleTurno();

      #endregion

      #region Variables 
      string servic;
      int? total=0;
      int idTur;
      ///Variable para comparar si ya esta el tipo de servicio cargado
      int idts;
      int cont;
      int cantidadTS;
      #endregion

      #region Cargas

      private void CargaProfesionales()
      {
         List<Personal> lst = objpers.LeerListadoPersonalDisponible();
         lst.Add(new Personal { Id_Pers = 0, Nombre = "" });

         cmbPersonal.ValueMember = "Id_Pers";
         cmbPersonal.DisplayMember = "Nombre";
         cmbPersonal.DataSource = lst;

         cmbPersonal.SelectedIndex = lst.Count - 1;
      }

      private void CargaTurnos()
      {
         
      }

      private void CargaServicios()
      {
         List<Servicio> lst = objserv.LeerListadoServicioDisponibles();
         lst.Add(new Servicio { Id_Serv = 0, Nombre = "" });

         cmbServicio.ValueMember = "Id_Serv";
         cmbServicio.DisplayMember = "Nombre";
         cmbServicio.DataSource = lst;

         cmbServicio.SelectedIndex = lst.Count - 1;

         servic = cmbServicio.Items.ToString();
      }

      private void CargaClientes()
      {
         List<Cliente> lst = objclie.LeerListadoDisponibles();
         lst.Add(new Cliente { Id_Clie = 0, Nombre = "" });

         cmbClientes.ValueMember = "Id_Clie";
         cmbClientes.DisplayMember = "Nombre";
         cmbClientes.DataSource = lst;

         cmbClientes.SelectedIndex = lst.Count - 1;
      }

      #endregion

      private void frmTurnos_Load(object sender, EventArgs e)
      {
         CargaClientes();
         CargaProfesionales();
         CargaServicios();
         CargaTurnos();
      }

      private void cmbServicio_DropDownClosed(object sender, EventArgs e)
      {
         servic = cmbServicio.Text.ToString();

         List<TipoServicio> lst = objserv.FiltroTipoServicio(servic);
         List<TipoServicio> lstTS = objserv.LeerListadoTipoServicioDisponible();

         lst.Add(new TipoServicio { Id_TS = 0, Nombre = "" });

         cmbTS.ValueMember = "Id_TS";
         cmbTS.DisplayMember = "Nombre";
         cmbTS.DataSource = lst;

         cmbTS.SelectedIndex = lst.Count - 1;
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         List<TipoServicio> lst = objserv.LeerListadoTipoServicioDisponible();

         t.Estado = "Pendiente";
         t.Id_TS = Convert.ToInt32(cmbServicio.SelectedValue);
         t.Id_Clie = Convert.ToInt32(cmbClientes.SelectedValue);
         t.Fecha = Convert.ToDateTime(dtmFechaTurno.Value.ToShortDateString());

         //En caso de que no haya cargado la hora..
         if (txtHora.Text == "  :")
         {
            txtHora.Text = "00:00";
         }

         t.Hora = TimeSpan.Parse(txtHora.Text);

         foreach (TipoServicio item in lst)
         {
            if (t.Id_TS == item.Id_TS)
            {
               total = total + item.Precio;
            }
         }

         t.Total = total;

         int CrearTurno = objturn.Crear(t);

         if (CrearTurno == 1)
         {
            idTur = t.Id_Tur;
         }
         else
         {
            MessageBox.Show("Ocurrió un error, por favor vuelva a intentarlo o comuníquese con el soporte técnico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LimpiarCampos();
         }

         foreach (DataGridViewRow a in this.dtgvTurnoActual.Rows)
         {
            if (Convert.ToInt32(a.Cells["Cantidad"].Value) > 1)
            {
               dt.Id_Tur = t.Id_Tur;
               dt.Id_Pers = Convert.ToInt32(cmbPersonal.SelectedValue);
               dt.Cantidad = Convert.ToInt32(dtgvTurnoActual[9, a.Index].Value);
               dt.Id_TS= Convert.ToInt32(dtgvTurnoActual[2, a.Index].Value);
               dt.Estado = "Pendiente";

               int CrearDetalleTurno = objturn.CrearDetalleTurno(dt);
            }
         }
         LimpiarCampos();
      }

      private void btnCargarTuno_Click(object sender, EventArgs e)
      {
         bool band = true;

         if(dtgvTurnoActual.Rows.Count>0)
         {
            foreach (DataGridViewRow g in this.dtgvTurnoActual.Rows)
            {
               int compIdTS = Convert.ToInt32(cmbTS.SelectedValue);

               foreach (DataGridViewRow a in this.dtgvTurnoActual.Rows)
               {
                  if(Convert.ToInt32(a.Cells["idTipS"].Value)==compIdTS)
                  {

                     cont = cont + 1;

                     int cont2;
                     cont2 = Convert.ToInt32(g.Cells["Cantidad"].Value);
                     cont2 = cont2 + 1;

                     a.Cells["Cantidad"].Value = cont;

                     ///Aca extraigo la cantidad que voy a tener de un tipo de servicio
                     cantidadTS = Convert.ToInt32(g.Cells["Cantidad"].Value.ToString());
                     //Al contador le asigno la cantidad de cortes que tengo
                     cont2 = cantidadTS;

                     band = false;
                  }
                  else
                  {
                     band = true;
                  }
               }

               if(band)
               {
                  cont = 0;
                  cont = cont + 1;

                  dtgvTurnoActual.Rows.Add(0, cmbClientes.SelectedValue, cmbTS.SelectedValue, cmbPersonal.SelectedValue, cmbClientes.Text, cmbPersonal.Text, cmbTS.Text, dtmFechaTurno.Value.ToShortDateString(), txtHora.Text, cont);
               }

               break;
            }
         }
         else
         {
            ////Agrego al datagrid los respectivos datos
            dtgvTurnoActual.Rows.Add(0, cmbClientes.SelectedValue, cmbTS.SelectedValue, cmbPersonal.SelectedValue, cmbClientes.Text, cmbPersonal.Text, cmbTS.Text, dtmFechaTurno.Value.ToShortDateString(), txtHora.Text, 1);
           
            ///Almaceno el id del tipo de servicio para despues comprarar
            idts = Convert.ToInt32(cmbTS.SelectedValue);
         }
      }

      private void LimpiarCampos()
      {
         txtHora.ResetText();
         cmbClientes.DataSource=null;
         cmbPersonal.DataSource = null;
         cmbServicio.DataSource = null;
         cmbTS.DataSource = null;
         dtmFechaTurno.ResetText();
         dtgvTurnoActual.Rows.Clear();

         CargaClientes();
         CargaProfesionales();
         CargaServicios();
      }

      private void cmbTS_SelectedValueChanged(object sender, EventArgs e)
      {
         List<TipoServicio> lstTS = objserv.LeerListadoTipoServicioDisponible();
         int idTS = Convert.ToInt32(cmbTS.SelectedValue);

         foreach (TipoServicio item in lstTS)
         {
            if (idTS == item.Id_TS)
            {
               lblValorTS.ResetText();
               lblValorTS.Text = "Valor: $" + item.Precio.ToString();
            }
         }
      }
   }
}
