﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivosFijos.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ActivosEntities : DbContext
    {
        public ActivosEntities()
            : base("name=ActivosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Activos_Fijos> Activos_Fijos { get; set; }
        public virtual DbSet<Calculo_Depreciacion> Calculo_Depreciacion { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Parametro> Parametro { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tipo_Activo> Tipo_Activo { get; set; }
        public virtual DbSet<Tipo_Pago> Tipo_Pago { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
