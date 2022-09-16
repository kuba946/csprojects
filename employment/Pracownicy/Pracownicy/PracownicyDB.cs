using System;
using System.Data.Entity;
using System.Linq;

namespace Pracownicy
{
    public class PracownicyDB : DbContext
    {
        // Your context has been configured to use a 'PracownicyDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Pracownicy.PracownicyDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PracownicyDB' 
        // connection string in the application configuration file.
        public PracownicyDB()
            : base("name=PracownicyDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Pracownik> Pracownicy { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}