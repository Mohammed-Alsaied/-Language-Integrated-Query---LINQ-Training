using Core_Of_LINQ;
using System.Linq;

namespace LINQTut03.Ex04
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var empMale = employees.Where(x => x.Gender == "Male");

            var empSalaryOver300K = employees.Where(x => x.Salary == 300_000);

            empMale.Print("Male Emoloyees");

            empSalaryOver300K.Print("Emoloyees with salary >= 300K");

            var empmaleInHRDepartment = empMale.Where(x => x.Department.ToLowerInvariant() == "hr");

            empmaleInHRDepartment.Print("Male Employee in HR Department Debartment");






        }
    }
}
