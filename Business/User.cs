using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class User
    {
        private Persistence.User pUser = new Persistence.User();

        public List<Model.User> Select()
        {
            return pUser.Select();
        }

        public void Insert(Model.User u)
        {
            if (u == null)
                throw new ArgumentNullException();
            if (pUser.Select().Where(r => r.Name == u.Name).Count() > 0)
                throw new InvalidOperationException();
            pUser.Insert(u);
        }

        public void Update(Model.User u)
        {
            pUser.Update(u);
        }

        public void Delete(Model.User u)
        {
            pUser.Delete(u);
        }

        public int GetID() { return Select().Count(); }
    }
}
