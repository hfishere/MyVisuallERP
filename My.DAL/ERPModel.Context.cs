﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPEntities : DbContext
    {
        public ERPEntities()
            : base("name=ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dbbuilding> dbbuildings { get; set; }
        public virtual DbSet<dbcourier> dbcouriers { get; set; }
        public virtual DbSet<dbemployee> dbemployees { get; set; }
        public virtual DbSet<dbempstat> dbempstats { get; set; }
        public virtual DbSet<dbroom> dbrooms { get; set; }
        public virtual DbSet<dbtodelarea> dbtodelareas { get; set; }
        public virtual DbSet<dbtodept> dbtodepts { get; set; }
        public virtual DbSet<dbtoflag> dbtoflags { get; set; }
        public virtual DbSet<dbtogender> dbtogenders { get; set; }
        public virtual DbSet<dbtograde> dbtogrades { get; set; }
        public virtual DbSet<dbtojob> dbtojobs { get; set; }
        public virtual DbSet<dbtolasteducation> dbtolasteducations { get; set; }
        public virtual DbSet<dbtomaritalstat> dbtomaritalstats { get; set; }
        public virtual DbSet<dbtoreligion> dbtoreligions { get; set; }
        public virtual DbSet<dbtovhcl> dbtovhcls { get; set; }
        public virtual DbSet<dbtutorial> dbtutorials { get; set; }
        public virtual DbSet<dbempstat> dbempstats { get; set; }
    }
}
