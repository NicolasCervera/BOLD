using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class clsServicios
   {
      public List<Servicio> LeerListadoServicioDisponibles()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Servicio.Where(x => x.Estado == "Disponible").ToList();
      }

      public List<Servicio> LeerListadoServicio()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Servicio.ToList();
      }

      public int CrearServicio(Servicio serv)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.Servicio.Add(serv);
         return BD.SaveChanges();
      }

      public int ActualizarServicio(Servicio serv)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         Servicio c = BD.Servicio.SingleOrDefault(b => b.Id_Serv == serv.Id_Serv);
         if (c != null)
         {
            c.Id_Serv = serv.Id_Serv;
            c.Estado = serv.Estado;
            c.Nombre = serv.Nombre;
            //c.Observacion = serv.Observacion;

            return BD.SaveChanges();
         }
         else
            return 0;
      }


      ///////////////////////////////////Tipos de servicios
     
      public List<TipoServicio> LeerListadoTipoServicio()
      {

         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.TipoServicio.Where(x => x.Estado == "Disponible").ToList();
      }

      public List<TipoServicio> FiltroTipoServicio(string s)
      {

         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.TipoServicio.Include("Servicio").Where(x => x.Estado == "Disponible" && x.Servicio.Nombre==s).ToList();
      }

      public int CrearTipoServicio(TipoServicio tserv)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.TipoServicio.Add(tserv);
         return BD.SaveChanges();
      }

      public int ActualizarTipoServicio(TipoServicio tserv)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         TipoServicio c = BD.TipoServicio.SingleOrDefault(b => b.Id_TS == tserv.Id_TS);
         if (c != null)
         {
            c.Id_TS = tserv.Id_TS;
            c.Id_Serv = tserv.Id_Serv;
            c.Precio = tserv.Precio;
            c.Nombre = tserv.Nombre;
            c.Estado = tserv.Estado;
            c.Detalle = tserv.Detalle;
            c.Duracion = tserv.Duracion;

            return BD.SaveChanges();
         }
         else
            return 0;
      }
   }
}
