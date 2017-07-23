using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class System : IIdentify
    {
        public bool UserLoged { get; set; }
        public User CurrentUser { get; set; }
        public string LastRecentlyUser { get; set; }
        public int Id { get; set; }
    }
}
