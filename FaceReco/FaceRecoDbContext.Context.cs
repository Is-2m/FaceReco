﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FaceReco
{
    using System;
    using System.Data.Entity;
    using System.Data.Objects.DataClasses;
    using System.Data.Entity.Infrastructure;
    
    public partial class FaceRecoDbContext : DbContext
    {
        public FaceRecoDbContext()
            : base("name=FaceRecoDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        [System.Data.Entity.DbFunction("FaceRecModel", "ParseInt32")]
        public static Int32 ParseInt32(string stringvalue)
        {
            return int.Parse(stringvalue);
        }
        public virtual DbSet<Filier> Filiers { get; set; }
        public virtual DbSet<Groupe> Groupes { get; set; }
        public virtual DbSet<presenceHistory> presenceHistories { get; set; }
        public virtual DbSet<Stagiaire> Stagiaires { get; set; }
        public virtual DbSet<stagiaireEncod> stagiaireEncods { get; set; }
    }
}
