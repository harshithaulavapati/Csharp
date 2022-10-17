using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace annonymous
{
    class TuplesDemo
    {
        public static (int, double, double) GetData(List<Double> numbers)
        {
            return ((int)numbers.Min(), numbers.Max(), numbers.Average());
        }
        public static (double Mn, double Avg, double Mx) GetData1(List<Double> numbers)
        {
            return (numbers.Min(), numbers.Average(), numbers.Max());
        }
        public static(int ,float,short) GetData4(List<float> num)
        {
            return ((int)num.Min(), (float)num.Max(),(short)num.Average());
        }
        public static List<Double> GetData2(List<Double> numbers)
        {
            List<Double> listdbl = numbers;
            listdbl.Add(250.55);
            return listdbl;
        }

        static void Main()
        {
            //List<float> inputlist = new List<float> { 52, 65, 78.5, 31.6, 38.00, 307, 120 };
            //var ret_result = GetData4(inputlist);

           // Console.WriteLine($"Lowest:{ret_result.Item1}, Highest :{ret_result.Item2}, Average :{ret_result.Item3}");
            //Console.WriteLine("-----------------");
            //var ret_res = GetData1(inputlist);
            //Console.WriteLine($"Lowest:{ret_res.Mn}, Highest :{ret_res.Mx}, Average :{ret_res.Avg}");
            //Console.WriteLine("-------Tuple Deconstruction----------");
            //Tuple Deconstruction by using type name of the return value 
            //(int min, float avg, short max) = GetData4(inputlist);
            //Console.WriteLine($"Lowest :{min}, Highest :{max},Average :{avg}");
            //(double m, double mx, double a) = GetData(inputlist);
            //Console.WriteLine(m + " " + mx + " " + a);
            //var listdata = GetData2(inputlist);
            //foreach (var v in listdata)
            //{
            //    Console.WriteLine(v);
            //}
            Console.Read();
        }
    }
}

