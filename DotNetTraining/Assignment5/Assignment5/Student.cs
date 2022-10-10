using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    abstract class Student
    {
       abstract public bool isPassed();
      public  void members(int studentid, String name, double grade)
        {
            
        }
       

    }
      class UnderGrade : Student
        {
        string name;
        int studentid;
        float grade;
        public UnderGrade(string n,int id,float g)
        {
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("enter the studentid");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the grade");
            grade = Convert.ToSingle(Console.ReadLine());
        }
        
        public override bool isPassed()
        {
            if (grade > 70)
                return true;
            else
                return false;

        }

        class Graduate : Student
        {
            float grade ;
            public override bool isPassed()
            {
               

                if (grade > 80)
                    return true;
                else
                    return false;

            }

        }
        class Display
        {
            static void Main(String [] args)
            {
                 UnderGrade underGrade = new UnderGrade("anu",23,90);
                Console.WriteLine(underGrade.isPassed());

                Console.ReadLine();
               
            }
        }
    }
}


