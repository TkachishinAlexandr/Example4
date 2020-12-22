using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
            var pow = from n in numbers.AsParallel()
                             select Pow(n);
            List<int> list = pow.ToList();
                foreach (var n in list)
                Console.WriteLine(n);
            Console.ReadLine();
        }
        static int Pow(int x)
        {
            int result = x * x * x;
            Console.WriteLine($"Возведение втретью степень числа {x} равно {result}");
            return result;
        }
    }
}
