﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Depo.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TolmachevDepoEntities : DbContext
    {
        public TolmachevDepoEntities()
            : base("name=TolmachevDepoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Floor> Floor { get; set; }
        public virtual DbSet<PreventiveWork> PreventiveWork { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<Van> Van { get; set; }
        public virtual DbSet<Work> Work { get; set; }
    }
}