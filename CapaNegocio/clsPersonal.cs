using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
  public class clsPersonal
  {
      ///////////////////////////////Personal
      public List<Personal> LeerListadoPersonalDisponible()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Personal.Include("Cargo").Where(x => x.Estado == "Disponible").ToList();
      }

      public List<Personal> LeerListadoPersonal()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Personal.ToList();
      }

      public Personal LeerPorNumero(int idPer)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Personal.SingleOrDefault(b => b.Id_Pers == idPer);
      }

      public int CrearPersonal(Personal persona)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.Personal.Add(persona);
         return BD.SaveChanges();
      }

      public int ActualizarPersonal(Personal pers)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         Personal p = BD.Personal.SingleOrDefault(b => b.Id_Pers == pers.Id_Pers);
         if (p != null)
         {
            p.Id_Pers = pers.Id_Pers;
            p.Nombre = pers.Nombre;
            p.Apellido = pers.Apellido;
            p.Detalle = pers.Detalle;
            p.Dni = pers.Dni;
            //p.Telefono = pers.Telefono;
            p.Nick = pers.Nick;
            p.Estado = pers.Estado;
            p.Fecha_Nacimiento = pers.Fecha_Nacimiento;
            p.Id_Cargo = pers.Id_Cargo;
            p.Clave = pers.Clave;
            p.Sueldo = pers.Sueldo;

            return BD.SaveChanges();
         }
         else
            return 0;
      }


      /// <summary>
      /// /////////////Cargos abajo, cargo todos los metodos para la carga de los cargos, sus ABM
      /// </summary>
      /// <returns></returns>
      public List<Cargo> LeerListado()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Cargo.ToList();
      }

      public List<Cargo> LeerListadoDisponibles()
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.Cargo.Where(x=> x.Estado=="Disponible").ToList();
      }

      public int Crear(Cargo carg)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         BD.Cargo.Add(carg);
         return BD.SaveChanges();
      }

      public int Actualizar(Cargo carg)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         Cargo c = BD.Cargo.SingleOrDefault(b => b.Id_Cargo == carg.Id_Cargo);
         if (c != null)
         {
            c.Id_Cargo = carg.Id_Cargo;
            c.Nombre = carg.Nombre;
            c.Descripcion = carg.Descripcion;
            c.Estado = carg.Estado;

            return BD.SaveChanges();
         }
         else
            return 0;
      }
   }
}
