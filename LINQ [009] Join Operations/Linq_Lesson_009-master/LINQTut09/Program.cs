using LINQTut09.Shared;
using System;
using System.Linq;

namespace LINQTut09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunJoinMethodeSyntax();
            //RunJoinQuerySyntax();
            RunGroupJoin();
            //RunGroupJoinQuerySyntax();
            Console.ReadKey();
        }

        #region RunJoinMethodeSyntax
        //private static void RunJoinMethodeSyntax()
        //{
        //    var employee = Repository.LoadEmployees();
        //    var department = Repository.LoadDepartment();

        //    var result = employee.Join(
        //        department,
        //        emp => emp.DepartmentId,
        //        dept => dept.Id,
        //        (emp, dept) => new EmployeeDto
        //        {
        //            FullName = emp.FullName,
        //            Department = dept.Name
        //        });

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine($"{item.FullName} [{item.Department}]");
        //    }
        //}
        #endregion


        #region RunJoinQuerySyntax
        //private static void RunJoinQuerySyntax()
        //{
        //    var employee = Repository.LoadEmployees();
        //    var department = Repository.LoadDepartment();

        //    var result = from emp in employee
        //                 join dept in department on emp.DepartmentId equals dept.Id
        //                 select new EmployeeDto
        //                 {
        //                     FullName = emp.FullName,
        //                     Department = dept.Name
        //                 };

        //    foreach (var item in result)
        //    {
        //        Console.WriteLine($"{item.FullName} [{item.Department}]");
        //    }
        //}
        #endregion


        #region RunGroupJoinMethodeSyntax
        //private static void RunGroupJoin()
        //{
        //    var employee = Repository.LoadEmployees();
        //    var departments = Repository.LoadDepartment();

        //    var result = departments.GroupJoin(
        //        employee,
        //        dept => dept.Id,
        //        emp => emp.DepartmentId,
        //        (dept, emp) => new Group
        //        {
        //            Department = dept.Name,
        //            Employees = emp.Select(e => e.FullName).ToList()
        //        }

        //        );

        //    foreach (var g in result)
        //    {
        //        Console.WriteLine($"******* {g.Department} *******");
        //        foreach (var name in g.Employees)
        //        {
        //            Console.WriteLine($"{name}");
        //        }
        //    }

        //}
        #endregion


        #region RunGroupJoinQuerySyntax
        private static void RunGroupJoin()
        {
            var employee = Repository.LoadEmployees();
            var departments = Repository.LoadDepartment();

            var result = from dept in departments
                         join emp in employee
                         on dept.Id equals emp.DepartmentId into empGroup
                         select empGroup;




            foreach (var g in result)
            {
                Console.WriteLine($"******* Group *******");
                foreach (var item in g)
                {
                    Console.WriteLine($"{item.FullName}");
                }
            }

        }
        #endregion









        //private static void RunJoin()
        //{
        //    var employees = Repository.LoadEmployees();
        //    var departments = Repository.LoadDepartment();
        //    var query = from emp in employees
        //                join dept in departments on emp.DepartmentId equals dept.Id
        //                select new { emp.FullName, dept.Name };

        //    foreach (var item in query)
        //    {
        //        Console.WriteLine($"{item.FullName} [{item.Name}]");
        //    }
        //}

        //private static void RunJoinQuerySyntax()
        //{
        //    var employees = Repository.LoadEmployees();
        //    var departments = Repository.LoadDepartment();
        //    var query = employees.Join(departments, emp => emp.DepartmentId, dept => dept.Id, (emp, dept) => new { emp.FullName, dept.Name });

        //    foreach (var item in query)
        //    {
        //        Console.WriteLine($"{item.FullName} [{item.Name}]");
        //    }
        //}


        //private static void RunGroupJoin()
        //{
        //    var employees = Repository.LoadEmployees();
        //    var departments = Repository.LoadDepartment();
        //    var empGroups = from dept in departments 
        //                    join emp in employees
        //                    on dept.Id equals emp.DepartmentId into empGroup
        //                    select empGroup;


        //    foreach (var group in empGroups)
        //    {
        //        Console.WriteLine("--------------------------------");
        //        foreach (var item in group)
        //        {
        //            Console.WriteLine($"{item.FullName}");
        //        }
        //    } 
        //}

        //private static void RunGroupJoinQuerySyntax()
        //{
        //    var employees = Repository.LoadEmployees();
        //    var departments = Repository.LoadDepartment();
        //    var query = departments.GroupJoin
        //        (employees, 
        //          dept => dept.Id, 
        //          emp => emp.DepartmentId, 
        //          (dept, emps) => new 
        //          {   
        //              Department =dept.Name,
        //              Employees = emps 
        //          });

        //    foreach (var group in query)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine($"********************** { group.Department } ***********************");
        //        Console.WriteLine();
        //        foreach (var item in group.Employees)
        //        {
        //            Console.WriteLine($"{item.FullName}");
        //        }
        //    }
        //}

        //Joining Join - Group Join


    }
}
