//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment1
//{
//    class Student
//    {
//        static void Main(string[] args)
//        {

//            // Declare variables for marks and total
//            int r, marks1, marks2, marks3, total;

//            // Declare percentage variable
//            float percentage;
//            string n;

//            // Enter student roll number
//            Console.WriteLine("Enter Student Roll Number :");
//            r = Convert.ToInt32(Console.ReadLine());

//            // Enter student name
//            Console.WriteLine("Enter Student Name :");
//            n = Console.ReadLine();

//            // Enter student subject 1 marks
//            Console.WriteLine("Enter C# Marks : ");
//            marks1 = Convert.ToInt32(Console.ReadLine());

//            // Enter student subject 2 marks
//            Console.WriteLine("Enter HTML Marks : ");
//            marks2 = Convert.ToInt32(Console.ReadLine());

//            // Enter student subject 3 marks
//            Console.WriteLine("Enter SQL Marks :");
//            marks3 = Convert.ToInt32(Console.ReadLine());

//            // Calculate total marks
//            total = marks1 + marks2 + marks3;

//            // Calculate percentage
//            percentage = total / 3.0f;

//            // Display the final result
//            Console.WriteLine("Final result of {0} is:", n);
//            Console.WriteLine("Total Marks : " + total);
//            Console.WriteLine("Percentage : " + percentage);

//            // Calculate grades
//            if (percentage <= 50)
//            {
//                Console.WriteLine(" failed");
//            }
//            else 
//            {
//                Console.WriteLine("passed");
//            }
//            Console.ReadKey();
            
            
//        }
//    }
//}

