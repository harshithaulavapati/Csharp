using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5dotnet
{
    class Account
    {
        public int AccnId;
        public   string CustomName;
        public  string AccnType;
        
        public Account(int accnid ,string custname,string accntype)
        {
            AccnId = accnid;
            CustomName = custname;
            AccnType = accntype;
           
        }
        public void details()
        {
            int amount = 2034, deposit, withdraw;
            int choice;
          
                Console.WriteLine("***************\n\n");
              Console.WriteLine("ENTER YOUR TRANSACTION TYPE  AND CHOOSE BELOW YOUR CHOICE : ");
                 Console.WriteLine("1. Current Balance\n");
                 Console.WriteLine("2. Withdraw \n");
                  Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("“YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..”");
                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU…”");  
                            break;
                }
                 
           
           
            
        }
        public void display()
        {
            Console.WriteLine("WELCOME TO ACCOUNT DETAILS \n");

            Console.WriteLine($"Account id : {AccnId}, Customer name :{CustomName}, Account Type :{AccnType}");
        }
        public static void Main(string[] args)
        {
            Account a = new Account(345677890,"kumari","savingsaccount");
            a.display();
            a.details();
            Console.ReadLine();
        }
    }
}

