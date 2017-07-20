using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AccessLog : IIdentify
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Id} - {UserId} - {Date.ToString("dd/MM/yyyy HH:mm")}";
        }
    }
}
