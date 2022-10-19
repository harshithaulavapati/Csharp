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
        public int length { get; set; }
        public int breadth { get; set; }


        
            public static Box operator +(Box rect1, Box rect2)
            {
                Box temp = new Box();
                temp.length = rect1.length + rect2.length;
                temp.breadth = rect1.breadth + rect2.breadth;
                return temp;
                
            }

        
        
        static void Main()
        {
            Box r1 = new Box();
            Box r2 = new Box();
            r1.length = 5; r1.breadth = 2;
            r2.length = 6; r2.breadth = 3;
            Box r3 = r1 + r2;
            Console.WriteLine("The Total Length and Breadth is {0} {1}", r3.length, r3.breadth);
            Console.Read();
        }

    }
}
