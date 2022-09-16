    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSamochodow
{
    [Table("Auta")]
    public class Auto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Segment { get; set; }
        public int PricePerDay { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfCars{ get; set; }
    }
}
