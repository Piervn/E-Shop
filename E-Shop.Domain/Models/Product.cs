using E_Shop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        [NotMapped]
        public Dictionary<string, string> Specification { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        public decimal Review { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
