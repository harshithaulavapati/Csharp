using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7dotNet
{
    class Rectangle
    {
        public int length { get; set; }
        public int breadth { get; set; }


        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)
        {
            Rectangle temp = new Rectangle();
            temp.length = rect1.length + rect2.length;
            temp.breadth = rect1.breadth + rect2.breadth;
            return temp;
            //rect1.length = rect1.length + rect2.length;
            //return rect1;
        }
        public static Rectangle operator ++(Rectangle r)
        {

            r.length++;
            r.breadth++;
            return r;

        }
        class OperatorOverload
        {
            static void Main()
            {
                Rectangle r1 = new Rectangle();
                Rectangle r2 = new Rectangle();
                r1.length = 5; r1.breadth = 2;
                r2.length = 6; r2.breadth = 3;
                Rectangle r= r1 + r2;
                r.length = 11;r.breadth = 5;
                r++;  //handson
                //string s = "AA";
                //string s1 = "BB";
                //string s2 = s + s1;
                //Console.WriteLine(s2);
                Console.WriteLine("The Total Length and Breadth is {0} {1}", r.length, r.breadth);
                Console.Read();
            }
        }
    }
}