using LINQTut05.Shared;
using System.Linq;

namespace LINQTut05.ThenBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var storedEmps1 = emps.OrderBy(x => x.Name).ThenBy(x => x.Salary);

            storedEmps1.Print("Stored Emps1");


            var storedEmps2 = emps.OrderBy(x => x.Name).ThenByDescending(x => x.Salary);

            storedEmps2.Print("Stored Emps2");





        }
    }
}
