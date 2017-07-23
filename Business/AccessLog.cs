using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class AccessLog
    {
        private Persistence.AccessLog pLog = new Persistence.AccessLog();

        public List<Model.AccessLog> Select()
        {
            return pLog.Select();
        }

        public void Insert(Model.AccessLog log)
        {
            pLog.Insert(log);
        }

        public void Update(Model.AccessLog log)
        {
            pLog.Update(log);
        }

        public void Delete(Model.AccessLog log)
        {
            pLog.Delete(log);
        }

        public void Clear()
        {
            pLog.Clear();
        }

        public int GetID() { return Select().Count(); }
    }
}
