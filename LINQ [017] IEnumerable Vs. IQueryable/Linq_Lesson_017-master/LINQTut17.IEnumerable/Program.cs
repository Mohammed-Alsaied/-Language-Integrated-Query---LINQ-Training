namespace LINQTut17.IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new BookContext();

            //IEnumerable->get all data in memory and make process(memory) on it
            //IEnumerable(Client)->Get All data from DB and load all data in Memory then apply Filtration process
            //Applicable Deaferd Excution
            //good in LInq to Object iteration be on sequence
            //best Performance->Data in Memory

            //IQueryable(Client)->Get All data from DB(Provider)and apply Filtration process
            //IEnumerable<Book> books = db.Books;
            //Applicable Deaferd Excution
            //Lambda Expresion translate tp Expression tree
            //best Performance->External Provider(DB)

            //Enumerable
            var booksOver50 = books.Where(x =>
            {
                Console.WriteLine($"Processing : {x.Id}");
                return x.Price > 50;
            });


            foreach (var item in booksOver50)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();



        }
    }
}
