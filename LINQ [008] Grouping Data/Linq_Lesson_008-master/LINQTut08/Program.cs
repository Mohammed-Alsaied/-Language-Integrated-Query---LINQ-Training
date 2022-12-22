using LINQTut08.Shared;
using System;
using System.Linq;

namespace LINQTut08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunGroupByExample();
            RunLookupExample();
            //RunGroupByWithQuerySyntax();
            Console.ReadKey();
        }



        //private static void RunGroupByExample()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++++++++");
        //    Console.WriteLine("GroupBy (Method Syntax");
        //    Console.WriteLine("+++++++++++++++++++++++");
        //    Console.WriteLine();

        //    var employees = Repository.LoadEmployees();
        //    var result = employees.GroupBy(x => x.Department);
        //    foreach (var item in result)
        //    {
        //        item.Print($"Employee in '{item.Key}' Department");
        //    }
        //}

        //private static void RunLookupExample()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++++++++");
        //    Console.WriteLine("ToLookup (Method Syntax");
        //    Console.WriteLine("+++++++++++++++++++++++"); 
        //    Console.WriteLine();

        //    var employees = Repository.LoadEmployees(); 
        //    var result = employees.ToLookup(x => x.Department);
        //    foreach (var item in result) 
        //    {
        //        item.Print($"Employee in '{item.Key}' Department");
        //    }
        //}

        //private static void RunGroupByWithQuerySyntax()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("+++++++++++++++++++++++");
        //    Console.WriteLine("GroupBy (Query Syntax");
        //    Console.WriteLine("+++++++++++++++++++++++"); 
        //    Console.WriteLine();

        //    var employees = Repository.LoadEmployees();
        //    var result = from emp in employees
        //                 group emp by emp.Department;

        //    foreach (var item in result)
        //    {
        //        item.Print($"Employee in '{item.Key}' Department");
        //    }
        //}

        //Group By 
        // To Lock Up
        //Group By  VS  To Lock Up
        //Single process ->Group By
        //Mult process -> To Lock Up
        #region Group By  Method Syntax
        //private static void RunGroupByExample()
        //{
        //    Console.WriteLine("Group By Example");

        //    var employee = Repository.LoadEmployees();

        //    var groups = employee.GroupBy(x => x.Department);

        //    foreach (var gruop in groups)
        //    {
        //        gruop.Print($"Employys in '{gruop.Key} ' Departement");
        //    }

        //}
        #endregion

        #region Group By Query Syntax
        //private static void RunGroupByWithQuerySyntax()
        //{
        //    Console.WriteLine("Group By Example");

        //    var employee = Repository.LoadEmployees();

        //    var groups = from emps in employee
        //                 group emps by emps.Department;
        //    foreach (var gruop in groups)
        //    {
        //        gruop.Print($"Employys in '{gruop.Key} ' Departement");
        //    }

        //}
        #endregion


        #region ToLookUP
        private static void RunLookupExample()
        {
            Console.WriteLine("ToLookUP Example");

            var employee = Repository.LoadEmployees();


            var groups = employee.ToLookup(x => x.Department);

            foreach (var gruop in groups)
            {
                gruop.Print($"Employys in '{gruop.Key} ' Departement");
            }
        }

        #endregion

    }


}
