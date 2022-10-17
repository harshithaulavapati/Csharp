using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12dotnet
{
    class Annonymous
    {
        static void Main()
        {
            var mytype = new
            {
                data1 = "csharp",
                data2 = 10,
                data3 = true,
                data4 = 35.55

            };
            //Console.WriteLine(mytype.GetType().ToString()));
            Console.ReadLine();
        }
    }
}
