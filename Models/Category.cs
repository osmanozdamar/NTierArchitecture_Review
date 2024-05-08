﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
