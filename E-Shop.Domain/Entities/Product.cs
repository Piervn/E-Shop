﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shop.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Description { get; set; }
        public string Specification { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public short Review { get; set; }
        public int Quantity { get; set; }
    }
}