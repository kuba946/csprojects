using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaSamochodow
{
    [Table("Wynajmy")]
    public class Wynajem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string ClientName { get; set; }
        [MaxLength(20)]
        public string ClientContact { get; set; }
        public int NumberOfDays { get; set; }
        public int Payment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool isFinishedOrNotStarted { get; set; }

        public Auto Auto { get; set; }
        [ForeignKey("Auto")]
        public int IdSamochodu { get; set; }
    }
}
