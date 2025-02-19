﻿using Shared;
using System;
using System.Linq;

namespace LINQTut14.Aggregation
{
    internal class Program
    {
        //private static Random random = new Random();

        static void Main(string[] args)
        {
            //RunMethod01();
            //RunMethod02();
            RunMethod03();
            //RunMethod04();
            Console.ReadKey();
        }

        private static void RunMethod01()
        {
            var names = new[] { "Ali", "Mohamed", "Abeer", "Reem", "Jalal" };

            //    var output = "";
            //    foreach (var name in names)
            //    {
            //        output += $"{name},";

            //    }

            //    Console.WriteLine(output.TrimEnd(','));


            //var output = string.Join(',', names);
            //Console.WriteLine(output);

            //var commaSperatedNames = names.Aggregate((a, b) =>
            //{
            //    Console.WriteLine($"a={a},b={b}");
            //    return $"{a},{b}";
            //});

        }

        private static void RunMethod02()
        {
            //var numbers = new[] { 1, 2, 3, 4, 5 };

            ////var total = numbers.Aggregate(1, (a, b) => a + b);//16
            //var total1 = numbers.Aggregate(2, (a, b) => a + b);//17

            //Console.WriteLine($"Totla: {total1}");
        }


        private static void RunMethod03()
        {
            var quiz = QuestionBank.All;
            var longestQuestionTitle = quiz[0];
            Console.WriteLine(longestQuestionTitle);

            longestQuestionTitle =
                quiz.Aggregate(longestQuestionTitle,
                (longest, next) => longest.Title.Length < next.Title.Length ? next : longest
                , x => x
                );
            Console.WriteLine($"Totla: {longestQuestionTitle}");
        }


        //private static void RunMethod01()
        //{
        //    var names = new[] { "Ali", "Salem", "Abeer", "Reem", "Jalal" };
        //    // Ali, Salem, ....

        //    //var output = "";
        //    //foreach (var item in names)
        //    //    output += $"{item},";
        //    //Console.WriteLine(output.TrimEnd(','));

        //    //var output = string.Join(',', names);
        //    //Console.WriteLine(output);

        //    var commaSeparatedNames = names.Aggregate((a, b) =>
        //    {
        //        Console.WriteLine($"a = {a}, b = {b}");
        //        return $"{a},{b}";
        //    });

        //}

        //private static void RunMethod02()
        //{
        //    var numbers = new[] { 1, 2, 3, 4, 5 };

        //    //var total = 0;
        //    //foreach (var n in numbers)
        //    //    total += n;

        //    var total = numbers.Aggregate(2, (a, b) => a + b);

        //    Console.WriteLine($"Total: {total}");
        //}


        //private static void RunMethod03()
        //{
        //    var quiz = QuestionBank.All;

        //    var longestQuestionTitle = quiz[0];

        //    Console.WriteLine($"{longestQuestionTitle}");
        //    Console.WriteLine("-----");
        //    longestQuestionTitle =
        //        quiz.Aggregate(longestQuestionTitle,
        //                        (longest, next) => longest.Title.Length < next.Title.Length ? next : longest,
        //                        x => x);



        //    Console.WriteLine($"{longestQuestionTitle}");
        //}
    }
}
