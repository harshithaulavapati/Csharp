using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7dotnet
{
    class Scholarship
    {
        int Totalmarks;
        float fees ;
        float amount;
        float per;
        
        public float Merit(int m, float f)
        {
            Totalmarks = m;
            fees = f;
            if(Totalmarks >= 70 && Totalmarks<= 80)
                    amount = (fees * 20) / 100;
            else if (Totalmarks > 80 && Totalmarks <= 90) 
                   amount = (fees * 30) / 100;
            else if (Totalmarks > 90)
                amount = (fees * 50) / 100;
            else
                Console.WriteLine("invalid");
            
            return 0;

        }
        public void Scholardisplay()
        {
            Console.WriteLine($" the marks {Totalmarks} , schloarshipe amount :{amount}" );


        }
        class Scholar
        {
            static void Main(string[] args)
            {
                Scholarship sc = new Scholarship();
                sc.Merit(300, 50000);
                sc.Scholardisplay();
                Console.ReadLine();


            }

        }
    }
}
