﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gmail
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class socialnetworkEntities : DbContext
    {
        public socialnetworkEntities()
            : base("name=socialnetworkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<comment_like> comment_like { get; set; }
        public virtual DbSet<education> educations { get; set; }
        public virtual DbSet<friend> friends { get; set; }
        public virtual DbSet<friend_request> friend_request { get; set; }
        public virtual DbSet<hobby> hobbies { get; set; }
        public virtual DbSet<notification> notifications { get; set; }
        public virtual DbSet<otp_table> otp_table { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<post_like> post_like { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
