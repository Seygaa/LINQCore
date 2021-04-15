using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Zadanie2
    {
        public static void display(List<List<int>> listOfList)
        {
            foreach (List<int> subList in listOfList)
            {
                foreach (int item in subList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        public static List<int> generateRandomList(int N)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            list = Enumerable
                .Range(0, N)
                .Select(index => rnd.Next(1, 10))
                .ToList();
            return list;
        }
        public static void generateSetOfNumbers(int N,int M)
        {
            List<int> list=new List<int>();
            List<List<int>> listOfList = new List<List<int>>(M);
            list = generateRandomList(N);

            listOfList = list.Select(elements => generateRandomList(N)).ToList();
            IEnumerable<int> sum = listOfList.SelectMany(item => item.Distinct());

            display(listOfList);
            Console.WriteLine("Suma: "+sum.Sum());

        }
        /*
        static void Main()
        {
            generateSetOfNumbers(5, 7);
        }
        */
    }
}
