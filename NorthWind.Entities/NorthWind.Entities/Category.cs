﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWind.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }

    }
}
