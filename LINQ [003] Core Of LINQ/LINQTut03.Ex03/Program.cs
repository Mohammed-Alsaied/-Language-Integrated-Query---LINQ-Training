using Core_Of_LINQ;
using System.Collections.Generic;
using System.Linq;

namespace LINQTut03.Ex03
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbersUsingExtensionWhere =
                numbers.Where(x => x % 2 == 0);

            var evenNumbersUsingEnumerableWhereMethode =
                Enumerable.Where(numbers, x => x % 2 == 0);

            //Select n From numbers where n % 2=0
            var evenNumbersUsingQuerySyntax =
                from n in numbers
                where n % 2 == 0
                select n;


            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhereMethode.Print("evenNumbersUsingEnumerableWhereMethode");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");














        }
    }
}
