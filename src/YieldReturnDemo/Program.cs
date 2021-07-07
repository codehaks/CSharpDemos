using System;
using System.Collections.Generic;

namespace YieldReturnDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var count = 10;
            var powers = PowerBy2Yield(count);
            foreach (var item in powers)
            {
                Console.WriteLine(item);
            }
        }

        public static IList<double> PowerBy2List(int count)
        {
            var result = new List<double>();
            for (int i = 1; i < count + 1; i++)
            {
                result.Add(Math.Pow(2, i));
            }

            return result;

        }

        public static IEnumerable<double> PowerBy2Yield(int count)
        {
            for (int i = 1; i < count + 1; i++)
            {
                yield return Math.Pow(2, i);
            }        

        }
    }
}
