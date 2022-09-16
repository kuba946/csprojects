using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BazaPojazdow
{
    public class BazaPojazdowDB : DbContext
    {
        // Your context has been configured to use a 'BazaPojazdowDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BazaPojazdow.BazaPojazdowDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BazaPojazdowDB' 
        // connection string in the application configuration file.
        public BazaPojazdowDB()
            : base("name=BazaPojazdowDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<PojazdDB> PojazdyDB { get; set; }
        public virtual DbSet<WynajemDB> WynajmyDB { get; set; }
        //public virtual DbSet<PojazdDB> MyEntities { get; set; }
    }
    [Table("Pojazdy")]
    public class PojazdDB
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        [MaxLength(10)]
        [Required]
        public string NrRej { get; set; }
        public string Typ { get; set; }
        public string Paliwo { get; set; }
        
        public double Moc { get; set; }
        public double PojSilnika{ get; set; }
        public double Masa { get; set; }
        public double Spalanie { get; set; }
        public double PojZb { get; set; }
        
        public double Zasieg
        {
            get
            {
                if (this.Spalanie == 0) {  return 0; }
                else { return PojZb / Spalanie * 100; }
            }
        }

        public bool CzyWynajety { get; set; }
        public virtual ICollection<WynajemDB> Wynajmy { get; set; }

    }
    [Table("Wynajmy")]
    public class WynajemDB
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RentId { get; set; }
        public DateTime OdDnia { get; set; }
        public DateTime DoDnia { get; set; }

        //[ForeignKey]
        public PojazdDB PojazdDB { get; set; }
        [ForeignKey("PojazdDB")]
        public int CarId { get; set; }
    }

    //public class PojazdDB
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}