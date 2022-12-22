using Shared;
using System;
using System.Linq;

namespace LINQTut11.ElementAt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var questions = QuestionBank.All;

            //var questionAt10 = questions.ElementAt(10);

            //// var questionAt300 = questions.ElementAt(300); ArugumentOutOfRangeException
            //var questionAt300 = questions.ElementAtOrDefault(300);

            //if(questionAt300 is null)
            //{

            //}


            //Console.WriteLine(questionAt300);

            var questions = QuestionBank.All;
            //var qat10 = questions.ElementAt(10);
            //var qat300 = questions.ElementAt(300);
            var qat300 = questions.ElementAtOrDefault(300);//avoid null
                                                           // can make check of null

            if (qat300 is null)
            {
                Console.WriteLine("Quisttion is Null");
            }
            Console.WriteLine(qat300);

            Console.ReadKey();
        }
    }
}
