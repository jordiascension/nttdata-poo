using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                Console.WriteLine("Hello Laura");

#if DEBUG
    Console.WriteLine("Debug version");
#else
    Console.WriteLine("Release version");
#endif

            if (i == 1)
                Console.WriteLine("Hello Laura");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            // The query variables can also be implicitly typed by using var

            // Query #1.
            IEnumerable<int> filteringQuery =
                from num in numbers
                where num < 3 || num > 7
                select num;

            List<int> lista = filteringQuery.ToList();
        }
    }
}
