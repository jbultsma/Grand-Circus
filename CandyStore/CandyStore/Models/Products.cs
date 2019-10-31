﻿using System;
using System.Collections.Generic;

namespace CandyStore.Models
{
    public partial class Products
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }
    }
}
