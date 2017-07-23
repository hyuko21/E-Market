using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class User
    {
        private static readonly string file = "I:\\Documentos\\projeto_poo\\E-Market\\database\\usersReg.json";

        public List<Model.User> Select()
        {
            return File<Model.User>.Select(file);
        }

        public void Insert(Model.User u)
        {
            File<Model.User>.Insert(file, u);
        }

        public void Update(Model.User u)
        {
            File<Model.User>.Update(file, u);
        }

        public void Delete(Model.User u)
        {
            File<Model.User>.Delete(file, u);
        }

        public void Clear()
        {
            File<Model.User>.Clear(file);
        }
    }
}
