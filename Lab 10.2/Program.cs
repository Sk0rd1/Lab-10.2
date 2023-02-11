using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-5, 6);
            }
            Array.ForEach(arr, x => Console.Write(x + " "));
            Console.WriteLine();

            Console.WriteLine(arr.Where(x => x > 1).ToArray().Select(x => x * x).Sum());

            Console.ReadKey();
        }
    }
}
