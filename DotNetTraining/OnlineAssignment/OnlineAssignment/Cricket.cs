using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAssignment
{
   /* Write a program to find the Sum and the Average points scored by the teams in the IPL.
   Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that
    takes no.of matches as input and  accepts that many scores from the user.
    The function should then display the Average and Sum of the scores.*/
    class Cricket
    {
        
       
         public int Pointscalculation(int no_of_matches)
        {
           
            Console.WriteLine("enter the no of matches");
            no_of_matches = Convert.ToInt32(Console.ReadLine());
            ArrayList al = new ArrayList();
            al.Add(80);
            al.Add(90);
            al.Add(100);
            al.Add(178);
            al.Add(190);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }
            var total = al;
            
            return no_of_matches;
        }

        public void average()
        {
            
            int sum;
            float avg;
            sum= 80 + 90 + 100 + 178 + 190;
             avg= sum / 5;
            //avg = sum;
            Console.WriteLine($" the sum is :-  {sum}  the average is :-  {avg}");
        }


        static void Main(string[] args)
        {
            Cricket cricket = new Cricket();
            cricket.Pointscalculation(150);
            cricket.average();
            Console.Read();
        }
    }
}
