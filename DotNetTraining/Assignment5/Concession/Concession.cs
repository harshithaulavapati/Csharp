using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary
{
    public class Concession
    {
        int amount;
        int constant= 500;
       


        public int  CalculateConcession(int Age)
        {
            if (Age <= 5)
            {
                Console.WriteLine("little champs Free Ticket");
            }
            else if (Age > 60)
            {
                amount = (constant * 30) / 100;
                Console.WriteLine($"senior citizen {amount}");
                
            }

            else
                Console.WriteLine($"Print Ticket Booked {constant}");
            return Age;
            
        }
    }
}
