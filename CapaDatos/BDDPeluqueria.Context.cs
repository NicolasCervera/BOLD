﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDDPeluqueriaEntities1 : DbContext
    {
        public BDDPeluqueriaEntities1()
            : base("name=BDDPeluqueriaEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<DetalleTurno> DetalleTurno { get; set; }
        public virtual DbSet<Dia> Dia { get; set; }
        public virtual DbSet<DiaxPromocion> DiaxPromocion { get; set; }
        public virtual DbSet<Mes> Mes { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Promocion> Promocion { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TiempoEspera> TiempoEspera { get; set; }
        public virtual DbSet<TipoServicio> TipoServicio { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }
        public virtual DbSet<Labor> Labor { get; set; }
        public virtual DbSet<V_Clientes> V_Clientes { get; set; }
    }
}