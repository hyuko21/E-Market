using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class System
    {
        private static readonly string file = "I:\\Documentos\\projeto_poo\\E-Market\\database\\system.json";

        public List<Model.System> Select()
        {
            return File<Model.System>.Select(file);
        }

        public void Update(Model.System sys)
        {
            File<Model.System>.Update(file, sys);
        }

        public void Clear()
        {
            File<Model.System>.Clear(file);
        }

        public void Initialize(Model.System sys)
        {
            sys.UserLoged = false;
            sys.CurrentUser = new Model.User()
            {
                Id = -1,
                Name = "visitante",
                Password = null,
                Admin = false
            };
            sys.Id = 0;
        }
    }
}
