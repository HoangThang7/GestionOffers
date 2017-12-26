using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestionOffers.Models
{
    public class Offer
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int code { get; set; }

        [Required]
        public string description { get; set;}


        
    
    }
}
