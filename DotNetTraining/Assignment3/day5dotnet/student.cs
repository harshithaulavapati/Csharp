using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5dotnet
{
    class student
    {
        public int[] mark = new int[5];
        public int Rollno;
        public string Name;
        public string Cls;
        public int Semester;
        public string Branch;
        public student(int rollno, string name, string cls, int sem, string branch)
            {
            Rollno = rollno;
            Name = name;
            Cls = cls;
            Semester = sem;
            Branch = branch;
            }


        public void getmarks()
        {


            Console.WriteLine("Enter the marks of five subjects");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Subject {0}-", i + 1);
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void getdata()
        { 
            int total = 0;
            float per;
            for (int i = 0; i < 5; i++)
            {
                total = total + mark[i];
            }
             per = total / 5;
            if (per < 35 || per < 50)
                Console.WriteLine("failed");
            else 
                Console.WriteLine("passed");

            Console.WriteLine("total marks {0}", total);
            Console.WriteLine("Percentage {0}", per);
            
        }
        public void details()
        {
            Console.WriteLine($"student id : {Rollno}, student name :{Name}, class :{Cls},semester :{Semester},Branch :{Branch}");
        }
    
        static void Main(string [] args)
        {
            student s = new student(11,"anuhya","engineering",5,"Electronic");
            s.details();
            s.getmarks();
            Console.ReadLine();
        }
    }
}

