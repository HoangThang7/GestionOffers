using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionOffers.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public  DateTime date { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string mail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int numberTel { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [ForeignKey("Address")]
        public Address addressUser { get; set; }

        [Required]
        public Usertype type { get; set; }
    }
}
