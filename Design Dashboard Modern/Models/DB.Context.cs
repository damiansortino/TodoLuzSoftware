﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Design_Dashboard_Modern.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class todoluzdbEntities : DbContext
    {
        public todoluzdbEntities()
            : base("name=todoluzdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caja> Caja { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Comprobante> Comprobante { get; set; }
        public virtual DbSet<detalleFactura> detalleFactura { get; set; }
        public virtual DbSet<estadoComprobante> estadoComprobante { get; set; }
        public virtual DbSet<medioPago> medioPago { get; set; }
        public virtual DbSet<movimientoCaja> movimientoCaja { get; set; }
        public virtual DbSet<movimientoStock> movimientoStock { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tipoComprobante> tipoComprobante { get; set; }
        public virtual DbSet<tipoMovimientoCaja> tipoMovimientoCaja { get; set; }
        public virtual DbSet<tipoMovimientoStock> tipoMovimientoStock { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
