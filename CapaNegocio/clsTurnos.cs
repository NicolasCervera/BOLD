using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
   public class clsTurnos
   {
      public List<Turno> LeerListadoDisponibles()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Turno.Where(x => x.Estado == "Disponible").OrderBy(x => x.Fecha).ToList();
      }

      public List<Turno> LeerListado()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Turno.OrderBy(x => x.Fecha).ToList();
      }

      public List<Turno> LeerListadoNoDisponibles()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Turno.Where(x => x.Estado == "No Disponible").OrderBy(x => x.Fecha).ToList();
      }

      public int Crear(Turno turn)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.Turno.Add(turn);
         return BD.SaveChanges();
      }

      public int Actualizar(Turno turn)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         Turno c = BD.Turno.SingleOrDefault(b => b.Id_Tur == turn.Id_Tur);
         if (c != null)
         {
            c.Id_Clie = turn.Id_Clie;
            c.Id_Tur = turn.Id_Tur;
            c.Id_TS = turn.Id_TS;
            c.Hora = turn.Hora;
            c.Fecha = turn.Fecha;
            c.Estado = turn.Estado;
            c.Total = turn.Total;

            return BD.SaveChanges();
         }
         else
            return 0;
      }


      ///////////////////////Tablas intermedias --Detalle Turno
      ///

      public List<DetalleTurno> LeerListadoDisponiblesDetalle()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.DetalleTurno.Where(x => x.Estado == "Disponible").ToList();
      }

      public List<DetalleTurno> LeerListadoDetalle()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.DetalleTurno.ToList();
      }

      public List<DetalleTurno> LeerListadoNoDisponiblesDetalle()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.DetalleTurno.Where(x => x.Estado == "No Disponible").ToList();
      }

      public int CrearDetalleTurno(DetalleTurno dturn)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.DetalleTurno.Add(dturn);
         return BD.SaveChanges();
      }

      public int ActualizarDetalleTurno(DetalleTurno dt)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         DetalleTurno c = BD.DetalleTurno.SingleOrDefault(b => b.Id_DetTur == dt.Id_DetTur);
         if (c != null)
         {
            c.Id_DetTur = dt.Id_DetTur;
            c.Id_Tur = dt.Id_Tur;
            c.Id_TS = dt.Id_TS;
            c.Id_Pers = dt.Id_Pers;
            c.Estado = dt.Estado;

            return BD.SaveChanges();
         }
         else
            return 0;
      }

   }
}
