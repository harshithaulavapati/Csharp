using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Dotnet
{
    class Program
    {
        static double average(int[] a, int n)
        {

            // Find sum of array element
            int sum = 0;

            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)sum / n;

        }

        // Driver code
        public static void Main()
        {

            int[] arr = { 10, 62, 37, 4, 5, 6, 7, 8, 9 };
            int n = arr.Length;
            Console.WriteLine(average(arr, n));
            Program program = new Program();
            program.min();
            program.marks();
            Console.ReadKey();
            program.word();
            program.revers();
            program.same();
            program.palindrome();

        }
        public void min()
        {
            int[] arr = new int[5] { 99, 95, 93, 89, 87 };
            int i, max, min, n;
            // size of the array
            n = 5;
            max = arr[0];
            min = arr[0];
            for (i = 0; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Maximum element = {0}\n", max);
            Console.Write("Minimum element = {0}\n\n", min);
            Console.ReadKey();

        }
        public void word()
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("Length of the string is : " + len);

        }
        public void revers()
        {
            
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word");
            //Getting String(word) from Console  
            str = Console.ReadLine();
            //Calculate length of string str  
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
        public void same()
        {
            //Receive Words from User  
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

          //step 1  
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //Step 2  
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            
            if (NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }

            
            Console.ReadLine();
        }
        public void palindrome()
        {
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
}  
    

