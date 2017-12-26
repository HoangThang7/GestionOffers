using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionOffers.Models
{
    public class Address
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string street { get; set; }

        [Required]
        public int zip { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string region { get; set; }

        [Required]
        public string country { get; set; }
    }
}
