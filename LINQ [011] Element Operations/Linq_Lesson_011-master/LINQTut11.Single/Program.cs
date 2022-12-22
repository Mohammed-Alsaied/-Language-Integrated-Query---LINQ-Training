using Shared;
using System;
using System.Linq;

namespace LINQTut11.Single
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //restriction one only
            //var questions = QuestionBank.All;
            ////var question = questions.Single(x => x.Title.Contains("#245"));
            ////var question2 = questions.SingleOrDefault(x => x.Title.Contains("#245"));
            ////var question3 = questions.Single(x => x.Title.Length == 0);

            //QuestionBank.All.ToQuiz();

            var q = QuestionBank.All;
            //var q1 = q.Single(q => q.Title.Contains("#245"));

            var q2 = q.SingleOrDefault(q => q.Title.Length <= 0);
            if (q2 is null)
            {
                Console.WriteLine("null");
            }
            Console.WriteLine(q2);
            Console.ReadKey();
        }
    }
}
