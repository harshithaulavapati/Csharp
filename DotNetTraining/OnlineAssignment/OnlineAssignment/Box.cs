using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a class Box that has Length and breadth as its members.
 Write a function that adds 2 box objects and stores in the 3rd. 
 Create a Test class to execute the above*/


namespace OnlineAssignment
{
    class Box
    {
        public delegate void delmethod(int l, int b);

        public class Test
        {
            public void  method1(int x, int y)
            {
                Console.WriteLine(" the length and breadth");
                int r1 = x * y;
                Console.WriteLine($"{r1}");
            }

            
         }
        
        static void Main()
        {
            Test t = new Test();
            t.method1(5, 8);
            delmethod del = new delmethod(t.method1);
            Console.Read();
        }

    }
}
