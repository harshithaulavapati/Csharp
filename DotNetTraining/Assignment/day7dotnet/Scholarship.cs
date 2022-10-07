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
        float fees =100000f;
        float amount;
        float per;
        
        public float Merit(int m, float f)
        {
            Console.WriteLine("enter the totalmarks");
            Totalmarks = Convert.ToInt32(Console.ReadLine());
            per = Totalmarks / 3f;
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
            Console.WriteLine($" total marks {Totalmarks},percentage: {per}, schloarshipe amount :{amount}" );


        }
        class Scholar
        {
            static void Main(string[] args)
            {
                Scholarship sc = new Scholarship();
                sc.Merit(300, 100000);
                sc.Scholardisplay();
                Console.ReadLine();


            }

        }
    }
}
