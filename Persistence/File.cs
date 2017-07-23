using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Persistence
{
    static class File<T> where T : Model.IIdentify
    {
        public static List<T> Open(string file)
        {
            List<T> content = null;
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.Default))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    JsonSerializer js = new JsonSerializer();
                    content = js.Deserialize<List<T>>(reader);
                }
            }
            catch
            {
                content = new List<T>();
            }
            return content;
        }

        public static void Save(string file, List<T> objs)
        {
            using (StreamWriter sw = new StreamWriter(file, false, Encoding.Default))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(writer, objs);
            }
        }

        public static List<T> Select(string file)
        {
            return Open(file);
        }

        public static void Insert(string file, T obj)
        {
            List<T> objs = Select(file);
            objs.Add(obj);
            Save(file, objs);
        }

        public static void Update(string file, T obj)
        {
            List<T> objs = Select(file);
            T x = objs.Where(r => r.Id == obj.Id).Single();
            objs.Remove(x);
            objs.Add(obj);
            Save(file, objs);
        }

        public static void Delete(string file, T obj)
        {
            List<T> objs = Select(file);
            T x = objs.Where(r => r.Id == obj.Id).Single();
            objs.Remove(x);
            Save(file, objs);
        }

        public static void Clear(string file)
        {
            Select(file).RemoveAll(r => r.Id >= 0);
        }
    }
}
