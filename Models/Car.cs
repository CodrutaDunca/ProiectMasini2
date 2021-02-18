using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMasini.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Display(Name = "Car Model")]
        public string Model { get; set; }
        public string Producer { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
