using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using CapaDatos;


namespace CapaNegocio
{
    public class clsClientes
    {

      public List<Cliente> LeerListado()
      {
        BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
        return BD.Cliente.ToList();
      }

      public V_Clientes LeerPorNumero(string filt)
      {

         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.V_Clientes.SingleOrDefault(b => b.Nombre.Contains(filt) || b.Apellido.Contains(filt) || b.Dni == Convert.ToInt32(filt));
      }

      public int Crear(Cliente cliente)
      {
        BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
        BD.Cliente.Add(cliente);
        return BD.SaveChanges();
      }

      public int Actualizar(Cliente cliente)
      {
        BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
        Cliente c = BD.Cliente.SingleOrDefault(b => b.Id_Clie == cliente.Id_Clie);
        if (c != null)
        {
          c.Id_Clie = cliente.Id_Clie;
          c.Nombre = cliente.Nombre;
          c.Apellido = cliente.Apellido;
          c.Detalle = cliente.Detalle;
          c.Dni = cliente.Dni;
          c.E_mail = cliente.E_mail;
          c.Estado = cliente.Estado;
          c.Fecha_Inscrip = cliente.Fecha_Inscrip;
          c.Fecha_Nacimiento = cliente.Fecha_Nacimiento;
          c.Telefono = cliente.Telefono;
          return BD.SaveChanges();
        }
        else
          return 0;
      }

      public V_Clientes Filtro(string filt)
      {
         BDDPeluqueriaEntities1 BD = new BDDPeluqueriaEntities1();
         return BD.V_Clientes.SingleOrDefault(b => b.Nombre.Contains(filt) || b.Apellido.Contains(filt) || b.Dni==Convert.ToInt32(filt));
      }


   }
}
