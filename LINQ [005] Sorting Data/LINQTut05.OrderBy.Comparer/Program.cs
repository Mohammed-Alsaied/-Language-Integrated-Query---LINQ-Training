﻿using LINQTut05.Shared;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut05.OrderBy.Comparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> emps = Repository.LoadEmployees();

            IOrderedEnumerable<Employee> sortedEmps =
                emps.OrderBy(e => e, new EmployeeComparer());

            sortedEmps.Print("Sorted Emps");

























        }
    }
}
