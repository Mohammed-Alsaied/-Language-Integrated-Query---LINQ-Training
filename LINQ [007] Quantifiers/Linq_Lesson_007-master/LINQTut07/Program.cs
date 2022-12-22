using LINQTut07.Shared;
using System;
using System.Linq;

namespace LINQTut07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        RunAny();
            //        RunAll();
            //        RunAnyAllQuerySyntax();
            //        RunContain();
            //        Console.ReadKey();
            //    }
            //    private static void RunAny()
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("+++++++++");
            //        Console.WriteLine("Run Any()");
            //        Console.WriteLine("+++++++++");
            //        Console.WriteLine();


            //        var employees = Repository.LoadEmployees();


            //        // if any employee name starts with some sequence of letter
            //        var input1 = "jac";
            //        var result1 = employees.Any(e => e.Name.StartsWith(input1, StringComparison.OrdinalIgnoreCase));
            //        Console.WriteLine($"find employee with name starts with '{input1}' result: {result1}");

            //        // if any employee employee salary less tham 1000
            //        var input2 = 10000;
            //        var result2 = employees.Any(e => e.Salary < input2);
            //        Console.WriteLine($"at least one employee with salary less than {input2.ToString("C2")} result: {result2}");

            //        // if any employee with skills less tham 1000
            //        var noOfSkills = 1;
            //        var result3 = employees.Any(e => e.Skills.Count < noOfSkills);
            //        Console.WriteLine($"at least one employee with skill count less than {noOfSkills} result: {result3}");

            //    }

            //    private static void RunAll()
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("+++++++++");
            //        Console.WriteLine("Run All()");
            //        Console.WriteLine("+++++++++");
            //        Console.WriteLine();

            //        var employees = Repository.LoadEmployees();

            //        // if all employees have email defined
            //        var result1 = employees.All(e => !string.IsNullOrWhiteSpace(e.Email));
            //        Console.WriteLine($"All employees have email result: {result1}");

            //        // if all employees have at least 1 skill
            //        var result2 = employees.All(e => e.Skills.Any(x => x.Contains("C#")));
            //        Console.WriteLine($"All employees have c# in their skills list result: {result2}");
            //    }

            //    private static void RunAnyAllQuerySyntax()
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("++++++++++++++++++++++++++++++++++");
            //        Console.WriteLine("Run All() + Any() Query Expression");
            //        Console.WriteLine("++++++++++++++++++++++++++++++++++");
            //        Console.WriteLine();
            //        var employees = Repository.LoadEmployees();

            //        var result1 = from emp in employees
            //                      where emp.Skills.All(x => x.Contains("c", StringComparison.OrdinalIgnoreCase))
            //                      select emp;

            //        result1.Print("Employees having skills  > skills");

            //        var result2 = from emp in employees
            //                      where emp.Skills.Any(x => x.Contains("node", StringComparison.OrdinalIgnoreCase))
            //                      select emp;

            //        result2.Print("Employees having skill node");
            //    }

            //    private static void RunContain()
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("++++++++++++++");
            //        Console.WriteLine("Run Contain()");
            //        Console.WriteLine("++++++++++++++");
            //        Console.WriteLine();
            //        var employees = Repository.LoadEmployees();


            //        // if any employee contains 'ee' in his/her name

            //        var e1 = employees.ToArray()[0];
            //        var result1 = employees.Contains(e1);
            //        Console.WriteLine($"find if any employee contains " +
            //            $"'{e1.Email}' in his/her name result: {result1}");

            //        var e2 = new Employee { Email = "Cole.Cochran02@example.com" };
            //        var result2 = employees.Contains(e2);
            //        Console.WriteLine($"find if any employee contains " +
            //            $"'{e2.Email}' in his/her name result: {result2}");
            //
            //


            //quantifiers return bool

            //1.Any()

            //RunAnyDemo();
            //RunAllDemo();
            //RunQuerySyntax();
            RunContains();
        }

        #region Method Syntax
        #region Any()
        //private static void RunAnyDemo()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine("Run Any()");
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine();

        //    var employees = Repository.LoadEmployees();

        //    var result1 = employees.Any(x => x.Name.StartsWith("jac", StringComparison.OrdinalIgnoreCase));

        //    Console.WriteLine(result1);

        //    var result2 = employees.Any(e => e.Salary < 10000m);
        //    Console.WriteLine(result2);

        //    var result3 = employees.Any(e => e.Skills.Count == 1);
        //    Console.WriteLine(result3);


        //}
        #endregion

        #region All()
        //private static void RunAllDemo()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine("Run All()");
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine();

        //    var emoloyee = Repository.LoadEmployees();

        //    var result1 = emoloyee.All(e => !string.IsNullOrWhiteSpace(e.Email));

        //    Console.WriteLine(result1);




        //    var result = emoloyee.All(e => e.Skills.Any(s => s == "C#"));

        //    Console.WriteLine(result1);
        //}
        #endregion

        #endregion


        #region QuerySyntax()
        #region RunQuerySyntax
        //private static void RunQuerySyntax()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine("Run All()");
        //    Console.WriteLine("+++++++++");
        //    Console.WriteLine();

        //    var employees = Repository.LoadEmployees();

        //    var query1 = from emp in employees
        //                 where emp.Skills.Any(s => s == "C++")
        //                 select emp;
        //    query1.Print("Emps with C++ Skills");



        //    var query2 = from emp in employees
        //                 where emp.Skills.All(s => s.Length >= 3)
        //                 select emp;
        //    query2.Print("Emps with  Skills > 3 char");


        //}
        #endregion

        #endregion


        #region Contains()
        private static void RunContains()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++");
            Console.WriteLine("Run All()");
            Console.WriteLine("+++++++++");
            Console.WriteLine();

            var emoloyee = Repository.LoadEmployees();

            //Contains instance Method
            var result1 = emoloyee.Any(e => e.Name.Contains("ee"));

            Console.WriteLine(result1);

            //Contains Extension Method

            var emps = new Employee { Email = "Cole.Cochran01@example.com" };

            var result2 = emoloyee.Contains(emps);//false difrent reference
        }
        #endregion


    }
}
