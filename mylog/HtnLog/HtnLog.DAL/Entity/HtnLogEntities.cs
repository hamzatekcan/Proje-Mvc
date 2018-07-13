namespace HtnLog.DAL.Entity
{
    using HtnLog.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class HtnLogEntities : DbContext
    {
        // Your context has been configured to use a 'HtnLogEntities' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'HtnLog.DAL.Entity.HtnLogEntities' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HtnLogEntities' 
        // connection string in the application configuration file.
        public HtnLogEntities()
            : base("name=HtnLogEntities")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Contents> Contents { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }

    public class MyDb: CreateDatabaseIfNotExists<HtnLogEntities>
    {
        protected override void Seed(HtnLogEntities context)
        {
            base.Seed(context);
        }
    }
}