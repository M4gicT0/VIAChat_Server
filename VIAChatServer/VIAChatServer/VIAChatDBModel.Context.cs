﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIAChatServer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;

    public partial class VIAChatEntities : DbContext
    {
        public VIAChatEntities()
            : base("name=viachatEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
