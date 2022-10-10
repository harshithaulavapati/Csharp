using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Customer
    {
       public   static int Customerid;
      public    static string Name;
      public   static  int Age;
       public  static double Phone;
       public static string City;
        public  Customer(int cid, string name , int age,double phone,string city)
        {
            Customerid = cid;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;

        }

        static  Customer()
        {
            Console.WriteLine("Enter Customer  ID:");
            Customerid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Phone Number");
            Phone = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Name of City");
            City = Console.ReadLine();
            
        }
       public  static void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {Customerid}, Name:{Name}, Age :{Age},Phone :{Phone},City :{City}");
        }
        ~Customer()
        {
            Console.WriteLine("Bye from customer");
            Console.Read();
        }
        public  static void Main()
        {
            Customer c = new Customer(234, "hima", 23, 4567890767, "nellore");
            //Console.WriteLine(c);
            DisplayCustomer();
           c = null;
            GC.Collect();
            Console.ReadLine();
        }

    }
    
    
}
