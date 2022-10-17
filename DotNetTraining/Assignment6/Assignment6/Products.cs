using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
sort them based on the price, and display the sorted Products*/
namespace Assignment6
{
   class Products
    {
          int Prodctid=456;
          string ProductName = "Paint Brush";
           int Price=50;

        public void order()
        {
            Console.WriteLine($"the productid :-{Prodctid} the product name :-{ProductName} the price :-{Price}");
        }
        public void sorting()
        {
           
            SortedList newlist = new SortedList();
            newlist.Add(35000,"electronics");
            newlist.Add(40000,"Appliances");
            newlist.Add(7000,"Bicycles");
            newlist.Add(5000,"Toys");
            newlist.Add(10000,"Video game");
            newlist.Add(50000,"Gold");
            newlist.Add(2000,"Paper");
            newlist.Add(20000,"Handcrafted Items");
            newlist.Add(3000,"Cosmetics");
            newlist.Add(1000,"Chocolates");
            
            foreach (DictionaryEntry dt in newlist)
            {
                Console.WriteLine(dt.Key + "  " + dt.Value);
            }


        }

    }
    class productsorting
    {
        static void Main(string [] args)
        {
            Products products = new Products();
            products.order();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("the sorting order products");
            products.sorting();
            Console.Read();
        }
    }
        
        
 }

