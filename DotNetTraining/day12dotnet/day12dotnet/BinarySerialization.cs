using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace day12dotnet
{
    [Serializable]
    class BinarySerialization
    {
        
            public int EId;
        public string Ename;
        static void Main(string[] args)
        {
            BinarySerialization bsout = new BinarySerialization();
            bsout.EId = 100;
            bsout.Ename = "Infinite";
            //can use IFormatter or BinaryFormatter to serialize and deserialize
            //serializing to a stream
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Csharp\Fileserialize.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, bsout);
            stream.Close();

            //deserializing from a stream
            stream = new FileStream(@"C:\Banu\infinite\Fileserialize.txt", FileMode.Open, FileAccess.Read);
            BinarySerialization bsin = (BinarySerialization)formatter.Deserialize(stream);
            Console.WriteLine($"The Id is :{bsin.EId}, and the name is :{bsin.Ename}");
            Console.Read();
        }
    }

}
    

