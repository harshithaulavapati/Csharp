using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Saledetails
    {
      public   int Salesno;
      public   int Productno;
      public  float Price;
     public  int Qty ;
     public  double TotalAmount;
        
        public Saledetails(int sno,int pno,float p,int qty)
        {
            Salesno = sno;
            Productno = pno;
            Price = p;
            Qty = qty;
            
        }
        public void sales()
        {
            
            TotalAmount = Qty * Price;
            
         }
        public void display()
        {
            Console.WriteLine($" Sale number { Salesno} , product number {Productno}  , price: {Price}, quantity : {Qty} ,  the total amount is : {TotalAmount}");
        }
    }
    class Detail
    {
       
        public static void Main(String [] args)
        {
            Saledetails s = new Saledetails(3,12,200,4);
            s.sales();
            s.display();
            Console.ReadLine();
        }
    }
}
