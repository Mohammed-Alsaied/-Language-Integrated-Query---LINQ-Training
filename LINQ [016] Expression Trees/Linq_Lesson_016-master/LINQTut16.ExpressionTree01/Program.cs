namespace LINQTut16.ExpressionTree01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Func<int, bool> IsEven = (num) => num % 2 == 0;
            //Console.WriteLine(IsEven(10));
            //Console.WriteLine(IsEven.Invoke(10));


            //Expression<Func<int, bool>> IsEvenExpression = (num) => num % 2 == 0;
            //Func<int, bool> IsEvenV2 = IsEvenExpression.Compile();
            //Console.WriteLine(IsEvenV2(10));

            Func<int, bool> IsEven = (num) => num % 2 == 0;//Delegate
            System.Console.WriteLine(IsEven(10));
            System.Console.WriteLine(IsEven.Invoke(10));
            global::System.Console.WriteLine(IsEvenMethod(10));
            ExpressionTree01<Func<int, bool>> ISEvenExpression = (num) => num % 2 == 0;
            Func<int, bool> IsEven2 = ISEvenExpression.Compile();
            global::System.Console.WriteLine(IsEven2(10));
            //Console.ReadKey();

        }


        //static bool IsEvenMethod(int num)
        //{
        //    return num % 2 == 0;
        //}
    }
}
