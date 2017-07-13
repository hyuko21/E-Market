using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class AccessLog
    {
        private static readonly string file = "files\\accesslog.txt";

        public List<Model.AccessLog> Select()
        {
            return File<Model.AccessLog>.Select(file);
        }

        public void Insert(Model.AccessLog log)
        {
            File<Model.AccessLog>.Insert(file, log);
        }

        public void Update(Model.AccessLog log)
        {
            File<Model.AccessLog>.Update(file, log);
        }

        public void Delete(Model.AccessLog log)
        {
            File<Model.AccessLog>.Delete(file, log);
        }
    }
}
