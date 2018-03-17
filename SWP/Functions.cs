using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SWP
{
    public class Functions
    {
        public static T DeepClone<T>(T obj)
        {
            T objResult;
            using (var ms = new MemoryStream())
            {
                var bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                ms.Position = 0;
                objResult = (T)bf.Deserialize(ms);
            }
            return objResult;
        }
    }
}
