using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set;}
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Orders { get; set; }

    }
}