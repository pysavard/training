﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Product
{
    public class Item
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		
		public Category Category { get; set; }


    }
}
