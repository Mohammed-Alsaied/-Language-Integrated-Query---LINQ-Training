using Shared;
using System;
using System.Linq;

namespace LINQTut10.DefaultIfEmpty
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Emoty<>(),DefaultIfEmpty(),Range,Rapeat
            //// int x; // x=0;
            ////Console.WriteLine(default(int)); // 0
            ////Console.WriteLine(default(DateTime)); // 01-01-0001 12:00:00 AM
            ////Console.WriteLine(default(Object) is null ? "NULL" : default(Object) is null); // NULL
            //var questions = Enumerable.Empty<Question>();

            //var question2 = questions.DefaultIfEmpty();

            //var question3 = questions.DefaultIfEmpty(Question.Default);

            //question3.ToQuiz();

            var q = Enumerable.Empty<Question>();

            var q1 = q.DefaultIfEmpty();

            var q3 = q.DefaultIfEmpty(Question.Default);

            q3.ToQuiz();
            Console.ReadKey();
        }
    }
}
