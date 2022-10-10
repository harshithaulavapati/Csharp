using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Count
    {
        public static void count()
        {
            Console.WriteLine("enter the  a name");
            string str = Console.ReadLine();
            Console.WriteLine("enter the any one charcter");
            char ch = Convert.ToChar(Console.ReadLine());
            int freq = str.Count(f => (f == ch));
            Console.WriteLine(freq);
        }

        public static void Main()
        {
            Count count = new Count();
            count.count();
            Console.ReadLine();

        }
        
        
    }
}
