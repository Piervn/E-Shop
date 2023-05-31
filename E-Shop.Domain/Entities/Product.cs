﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public string Specification { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal Review { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
    }
}
