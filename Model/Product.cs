using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"{Name} + {Maker}";
        }
    }
}
