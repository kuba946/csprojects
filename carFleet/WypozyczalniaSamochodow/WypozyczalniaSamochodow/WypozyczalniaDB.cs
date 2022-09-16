namespace WypozyczalniaSamochodow
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WypozyczalniaDB : DbContext
    {
        // Your context has been configured to use a 'WypozyczalniaDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'WypozyczalniaSamochodow.WypozyczalniaDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WypozyczalniaDB' 
        // connection string in the application configuration file.
        public WypozyczalniaDB()
            : base("name=WypozyczalniaDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Auto> Auta { get; set; }
        public virtual DbSet<Wynajem> Wynajmy { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}