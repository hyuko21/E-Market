using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.Script.Serialization;

namespace Persistence
{
    static class File<T>
    {
        public static List<T> Open(string file)
        {
            List<T> content = null;
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                content = js.Deserialize<List<T>>(file);
            }
            catch
            {
                content = new List<T>();
            }
            return content;
        }

        public static void Save(string file, List<T> objs)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            file = js.Serialize(objs);
        }
    }
}
