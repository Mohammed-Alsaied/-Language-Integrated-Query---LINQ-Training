using Shared;
using System;
using System.Linq;

namespace LINQTut11.First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    var questions = QuestionBank.All;
            //    var firstQuestion = questions.First();
            //    Console.WriteLine(firstQuestion);

            //    //var someQuestion = questions.First(x => x.Title.Length == 0); //InvalidOperationException
            //    var someOtherQuestion = questions.FirstOrDefault(x => x.Title.Length == 0); //null

            //    if(someOtherQuestion is null)
            //    {
            //        Console.WriteLine("Question is null");
            //    }

            var q = QuestionBank.All;
            var fQ = q.First();
            Console.WriteLine(fQ);

            //var someQ = q.First(q => q.Title.Length <= 0);
            var someOtherQ = q.FirstOrDefault(q => q.Title.Length <= 0);
            // can make check of null

            if (someOtherQ is null)
            {
                Console.WriteLine("Quisttion is Null");
            }
            Console.WriteLine(someOtherQ);

            Console.ReadKey();
        }
    }
}
