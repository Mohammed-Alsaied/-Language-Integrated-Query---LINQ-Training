using LINQTut06.Shared;
using System.Linq;

namespace LINQTut06.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var q1 = emps.Skip(10);
            q1.Print("Skip First 10 Employee");

            var q2 = emps.SkipWhile(x => x.Salary != 214400);

            q2.Print("Skip While Salary at 214400");

            var q3 = emps.SkipLast(10);
            q3.Print("Skip last 10 Employee");

        }
    }
}
