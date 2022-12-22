using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut03.Ex02
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var collection = new ArrayList { 1, true, DateTime.Now };
            //var evenNumbers = numbers.Where(x => x % 2 == 0);
            IEnumerable<int> evenNumbers = numbers.Where(x => x % 2 == 0);

            //var blabla = collection.Where(x => x % 2 == 0);
            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            // [1] ==> 2,4,6,8
            // [2] ==> 2,6,8,10,12

            foreach (var n in evenNumbers) // Enumeration ,Lazy Loading
            {
                Console.Write($" {n}");
            }


















        }
    }
}
