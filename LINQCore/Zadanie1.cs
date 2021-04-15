using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Zadanie1
    {
        public static void generateSetOfNumbers(int length)
        {

            IEnumerable<int> numbers = Enumerable.Range(1, length);
            IEnumerable<int> assumptions = numbers.Where((num, index) => ((num != 5) && (num != 9)&&((num % 2) != 0 || (num % 7) == 0)));
            Console.WriteLine("Ilosc elementów spełniających założenia: " + assumptions.Count());
            IEnumerable<int> squares= assumptions.Select(x => x * x);

            
            Console.WriteLine("Suma elementów w zbiorze kwadratów: " + squares.Sum());
            Console.WriteLine("Ilosc elementów w zbiorze kwadratów: " + squares.Count());
            Console.WriteLine("Pierwszy element w zbiorze kwadratów: " + squares.First());
            Console.WriteLine("Ostatni element w zbiorze kwadratów: " + squares.Last());
            
            if (squares.Count() > 2)
                Console.WriteLine("Trzeci element w zbiorze kwadratów: " + squares.ElementAt(2));
            
        }
        /*
        static void Main()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            generateSetOfNumbers(length);
        }
        */
    }
}
