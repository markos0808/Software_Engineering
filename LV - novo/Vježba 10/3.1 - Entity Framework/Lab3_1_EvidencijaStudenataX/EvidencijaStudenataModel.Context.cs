﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab3_1_EvidencijaStudenataX
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EvidencijaStudenataEntities4 : DbContext
    {
        public EvidencijaStudenataEntities4()
            : base("name=EvidencijaStudenataEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Aktivnost> Aktivnosti { get; set; }
        public DbSet<AktivnostStudenta> AktivnostiStudenta { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Tim> Timovi { get; set; }
        public DbSet<TipAktivnosti> TipoviAktivnosti { get; set; }
    }
}
