using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Domain.Components;

namespace E_Shop.Domain.Entities
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set;}
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Order")]
        public List<Order> Orders { get; set; }

    }
}