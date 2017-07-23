using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class System
    {
        private Persistence.System pSys = new Persistence.System();

        public List<Model.System> Select()
        {
            return pSys.Select();
        }

        public void Update(Model.System sys)
        {
            pSys.Update(sys);
        }

        public void Clear()
        {
            pSys.Clear();
        }

        public void Initialize(Model.System sys)
        {
            pSys.Initialize(sys);
        }
    }
}
