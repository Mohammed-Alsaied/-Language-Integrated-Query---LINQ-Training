using Core_Of_LINQ;
using System.Linq;

namespace LINQTut03.Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Language Integrated Query
            //MS.NET Component langyage + features
            //Type safe queries in code
            //Query local object IEnumerabla<T>
            //LINQ To Remote (SQL) iQueryable<T>
            //Set Of Query Operator Extension Methods

            //Write LINQ Statments Using 
            //1-Method Syntax
            //2-Query Syntax

            var employees = Repository.LoadEmployees();
            var femalsWithFnameStartWithS01 = employees
                .Filter(x => x.Gender == "female"
                && x.FirstName.ToLowerInvariant().StartsWith("s"));
            femalsWithFnameStartWithS01.Print("femals With Fname Start With S /Filter");

            var femalsWithFnameStartWithS02 = employees
                .Where(x => x.Gender == "female"
                && x.FirstName.ToLowerInvariant().StartsWith("s"));
            femalsWithFnameStartWithS01.Print("femals With Fname Start With S /Where");




        }
    }
}
