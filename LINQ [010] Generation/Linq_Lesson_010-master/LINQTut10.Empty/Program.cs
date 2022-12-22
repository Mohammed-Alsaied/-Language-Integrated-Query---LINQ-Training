using Shared;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut10.Empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var questions = new List<Question>(); // empty list

            ////1
            ////...
            ////1000
            //foreach (var q in questions)
            //{
            //    Console.WriteLine(q);
            //}

            //var questions2 = Enumerable.Empty<Question>(); // empty list

            ////1
            ////...
            ////1000
            //foreach (var q in questions2)
            //{
            //    Console.WriteLine(q);
            //}

            //Console.ReadKey();


            var quistions = new List<Question>();

            foreach (var q in quistions)
            {
                System.Console.WriteLine(q);
            }


            var q2 = Enumerable.Empty<Question>();// best in performance amd ather
            foreach (var q in q2)
            {
                System.Console.WriteLine(q);
            }
        }
    }
}
