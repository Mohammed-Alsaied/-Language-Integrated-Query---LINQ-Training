using LINQTut05.Shared;
using System.Linq;

namespace LINQTut05.OrderBy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =
            {
                "apricot","orange","banana","mango"
                ,"apple","grape","straberry"
            };

            var orferFruits = fruits.OrderBy(f => f);//ASC
            orferFruits.Print("Fruitrs Acs (Methode Syntax)");


            var orferFruitsQ = from f in fruits
                               orderby f ascending // defualt
                               select f;//ASC
            orferFruitsQ.Print("Fruitrs Acs (Query Syntax)");

            var orferFruitsDesc = fruits.OrderByDescending(f => f);//ASC
            orferFruitsDesc.Print("Fruitrs DESC (Methode Syntax)");


            var orferFruitsQDesc = from f in fruits
                                   orderby f descending
                                   select f;//ASC
            orferFruitsQDesc.Print("Fruitrs DESC (Query Syntax)");




            var orferFruitsAcsLength = fruits.OrderBy(f => f.Length);//ASC
            orferFruitsAcsLength.Print("Fruitrs ASC Length (Methode Syntax)");


            var orferFruitsAcsLengthQ = from f in fruits
                                        orderby f.Length descending
                                        select f;//ASC
            orferFruitsAcsLengthQ.Print("Fruitrs DESC Length (Query Syntax)");







        }
    }
}
