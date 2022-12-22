using LINQTut04.Shared;
using System.Linq;

namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //RunExample01();
            RunExample02();
        }

        private static void RunExample01()
        {
            string[] sentences =
            {
                "I love asp.net core","i like sql server also"
                ,"in general i love programming"
            };

            var words = sentences.SelectMany(x => x.Split(' ')); // projection in values

            foreach (var word in words)
            {
                System.Console.WriteLine(word);
            }



        }

        private static void RunExample02()
        {
            var emp = Repository.LoadEmployees();
            //var skills = emp.SelectMany(x => x.Skills).Distinct();
            //quert syntax
            var result01 = (from embloyee in emp
                            from skill in embloyee.Skills
                            select skill).Distinct();
            foreach (var skill in result01)
            {
                System.Console.WriteLine(skill);
            }
        }

    }
}
