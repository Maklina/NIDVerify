﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BKBNIDVerify.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class BKBNIDDBEntities : DbContext
    {
        public BKBNIDDBEntities()
            : base("name=BKBNIDDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AccessToken> AccessTokens { get; set; }
        public DbSet<SearchLog> SearchLogs { get; set; }
    
        public virtual ObjectResult<sp_TotalSearch_Result> sp_TotalSearch()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_TotalSearch_Result>("sp_TotalSearch");
        }
    }
}