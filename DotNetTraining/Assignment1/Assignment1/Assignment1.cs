using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the numbers:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Are equal");
            else
                Console.WriteLine("not equal");
            Console.ReadLine();
            positive positive = new positive();
            positive.values();
            Console.ReadKey();
            Operation op = new Operation();
            op.test();
            Console.ReadKey();
            Celsius ce = new Celsius();
            ce.temp();
            Console.ReadKey();
            ce.student();
            Console.ReadKey();



        }
    }
    class positive
    {
        int a;
        public void values()
        {

            Console.WriteLine("Enter the numbers:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
                Console.WriteLine("is a positive number");
            else
                Console.WriteLine("  is a negitive number");
            Console.ReadLine();

        }
    }

    class Operation
    {

        int x, y;
        char operation;
        public void test()
        {
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");
            Console.ReadKey();
        }
    }
        class Celsius
        {
            public void temp()
            {
                //double fahrenheit;

                //double celsius ;
                //Console.WriteLine("Celsius: " );

                //fahrenheit = (celsius* 9) / 5 + 32;
                //Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.Write("Enter temperature in Celsius : ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine("The converted fahrenheit temperature is : " + fahrenheit);

            Console.ReadLine();
            }
         
              public void student()
            {
                        int r, marks1, marks2, marks3, total;
                      float percentage;
                    string n;
            Console.WriteLine("Enter Student Roll Number :");
            r = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter Student Name :");
            n = Console.ReadLine();

            
            Console.WriteLine("Enter C# Marks : ");
            marks1 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter HTML Marks : ");
            marks2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Enter SQL Marks :");
            marks3 = Convert.ToInt32(Console.ReadLine());

           
            total = marks1 + marks2 + marks3;

           
            percentage = total / 3.0f;

            
            Console.WriteLine("Final result of {0} is:", n);
            Console.WriteLine("Total Marks : " + total);
            Console.WriteLine("Percentage : " + percentage);

           
            if (percentage <= 50)
            {
                Console.WriteLine(" failed");
            }
            else
            {
                Console.WriteLine("passed");
            }
            Console.ReadKey();


          
        }
    }


    
}