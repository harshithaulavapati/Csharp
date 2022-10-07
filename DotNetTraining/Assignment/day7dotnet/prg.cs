using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Prg
    {
        public static string firstname;
        public static string lastname;

        public static void Display()
        {
            Console.WriteLine("Please enter your name firstname: ");
            firstname = Console.ReadLine();
            Console.WriteLine(" please enter your lastname" );
            lastname = Console.ReadLine();
            lastname = lastname.ToUpper();
            Console.WriteLine(""+firstname );
            Console.WriteLine(""+lastname);
        }
        public static void count()
        {
            Console.WriteLine("enter the  a name");
            string str = Console.ReadLine();
            Console.WriteLine("enter the any one charcter");
            char ch =Convert.ToChar(Console.ReadLine());
            int freq = str.Count(f => (f == ch));
            Console.WriteLine(freq);
        }
   
        static void Main(string[] args)
        {
            count();
            Display();
            Console.ReadLine();
        }
    }
}


