using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a simple Stationery application to add items and display added items using Generic List collections*/
namespace Assignment6
{
    class Stationary
    {
        public void simplestationery()
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("NoteBooks");
            stringlist.Add("Pens");
            stringlist.Add("TextBooks");
            stringlist.Add("RoughBooks");
            stringlist.Add("Pencils");
            foreach (string  s in stringlist)
            {
                Console.WriteLine(s);
            }
        }
    }
    class Details
    {
        static void Main()
        {
            Stationary stationary = new Stationary();
            Console.WriteLine("the list of stationary items");
            stationary.simplestationery();
            Console.Read();
        }
    }
}
