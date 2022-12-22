using LINQTut06.Shared;
using System.Linq;

namespace LINQTut06.Pagination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var page = 1;
            var size = 10;

            System.Console.WriteLine("result per page");
            if (int.TryParse(System.Console.ReadLine(), out int resuttPage))
            {
                size = resuttPage;
            }

            System.Console.WriteLine("page No..:");
            if (int.TryParse(System.Console.ReadLine(), out int pageNo))
            {
                page = pageNo;
            }
            var emps = Repository.LoadEmployees();


            var result = emps.Paginate(page, size);
            var resultCount = result.Count();
            var startRecord = ((page - 1) * size) + 1;
            var endRecord =
                resultCount < size ? startRecord + resultCount - 1
                : size * (page - 1) + size;
            result.Print($"showing Eployees {startRecord} - {endRecord}");
        }

    }
}
