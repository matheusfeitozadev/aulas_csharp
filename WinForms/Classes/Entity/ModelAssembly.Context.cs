//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinForms.Classes.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CursoDEVEntities : DbContext
    {
        public CursoDEVEntities()
            : base("name=CursoDEVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assembly> Assemblies { get; set; }
        public virtual DbSet<AssemblyProperty> AssemblyProperties { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
