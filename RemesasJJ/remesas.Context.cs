﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemesasJJ
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class remesasEntities : DbContext
    {
        public remesasEntities()
            : base("name=remesasEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<clientes> clientes { get; set; }
        public DbSet<country> country { get; set; }
        public DbSet<estatus> estatus { get; set; }
        public DbSet<beneficiarios> beneficiarios { get; set; }
        public DbSet<cambio> cambio { get; set; }
        public DbSet<remesatype> remesatype { get; set; }
        public DbSet<pagotype> pagotype { get; set; }
        public DbSet<pagosremesa> pagosremesa { get; set; }
        public DbSet<sendgrid> sendgrid { get; set; }
        public DbSet<cedulatype> cedulatype { get; set; }
        public DbSet<bancos> bancos { get; set; }
        public DbSet<cuentastype> cuentastype { get; set; }
        public DbSet<moneda> moneda { get; set; }
        public DbSet<bancosempre> bancosempre { get; set; }
        public DbSet<bancostrans> bancostrans { get; set; }
        public DbSet<remesas> remesas { get; set; }
        public DbSet<acesos> acesos { get; set; }
        public DbSet<roleacess> roleacess { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<users> users { get; set; }
    }
}
