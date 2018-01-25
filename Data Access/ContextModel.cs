namespace Data_Access
{
    using Core;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextModel : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Data_Access.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public ContextModel()
            : base("name=HomeContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Category> Categories { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Cd> Cds { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<UserTable> UserTables { get; set; }

    }
}