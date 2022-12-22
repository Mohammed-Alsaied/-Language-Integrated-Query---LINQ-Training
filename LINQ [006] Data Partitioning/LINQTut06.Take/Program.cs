using LINQTut06.Shared;
using System.Linq;

namespace LINQTut06.Take
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var emps = Repository.LoadEmployees();

            var q1 = emps.Take(10);
            q1.Print("Take First 10 Employee");

            var q2 = emps.TakeWhile(x => x.Salary != 214400);

            q2.Print("Take While Salary does not wqual 214400");

            var q3 = emps.TakeLast(10);
            q3.Print("Take last 10 Employee");
        }
    }
}
