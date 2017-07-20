using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class User : IIdentify
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
