using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Assignment5
{
    class Program
    {
        public int constant = 500;
        public string Name;
        public int Age;

        public void accept()
        {
            Console.WriteLine("enter the name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
    }

    class  prodetails
    {
         

        static void Main(string [] args)
        {
            
            Program p = new Program();
            p.accept();
            Concession concession = new Concession();
            concession.CalculateConcession(50);
            

            Console.ReadLine();
        }
    }
        
       
}
