using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_Shop.Domain.Components;
using E_Shop.Domain.Enums;

namespace E_Shop.Domain.Entities
{
    public class Manager
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set;}
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Permission Permissions { get; set; }
    }
}
