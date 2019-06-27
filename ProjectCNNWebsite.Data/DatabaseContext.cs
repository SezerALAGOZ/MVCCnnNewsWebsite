using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCNNWebsite.Domain;

namespace ProjectCNNWebsite.Data
{
    public class DatabaseContext : DbContext
    {
      public DatabaseContext()
      {
         Database.Connection.ConnectionString = @"Server=SEZER-EV\SQLEXPRESS;Database=CNNDatabase;Integrated Security=true;";
      }

      public DbSet<News> News { get; set; }  

      public DbSet<Category> Category { get; set; }

      public DbSet<Admin> Admin { get; set; }   

      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
         //base.OnModelCreating(modelBuilder);
      }

      public override int SaveChanges()
      {
         return base.SaveChanges();
      }
   }
}
