using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracownicy
{
    [Table("Pracownicy")]
    public class Pracownik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string Contact { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
    }
}
