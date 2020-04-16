using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ECommerce.Models
{
    public class ECommerceContext: DbContext
    {
        public ECommerceContext() :base("DefaultConnection")
        {

        }

        //Desabilitar Cascata

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<ECommerce.Models.Departments> Departments { get; set; }

        public System.Data.Entity.DbSet<ECommerce.Models.City> Cities { get; set; }
    }
}