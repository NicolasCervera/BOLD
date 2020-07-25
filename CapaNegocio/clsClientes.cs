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
        BDDPeluqueriaEntities BD = new BDDPeluqueriaEntities();
        return BD.Cliente.ToList();
      }

      public Cliente LeerPorNumero(int idCliente)
      {
        BDDPeluqueriaEntities BD = new BDDPeluqueriaEntities();
        return BD.Cliente.SingleOrDefault(b => b.Id_Clie == idCliente);
      }

      public int Crear(Cliente cliente)
      {
        BDDPeluqueriaEntities BD = new BDDPeluqueriaEntities();
        BD.Cliente.Add(cliente);
        return BD.SaveChanges();
      }

      public int Actualizar(Cliente cliente)
      {
        BDDPeluqueriaEntities BD = new BDDPeluqueriaEntities();
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

      public int Borrar(int numeroCliente)
      {
        BDDPeluqueriaEntities BD = new BDDPeluqueriaEntities();
        Cliente c = BD.Cliente.SingleOrDefault(b => b.Id_Clie == numeroCliente);
        if (c != null)
        {
          BD.Cliente.Remove(c);
          return BD.SaveChanges();
        }
        else
          return 0;
      }


    }
}
