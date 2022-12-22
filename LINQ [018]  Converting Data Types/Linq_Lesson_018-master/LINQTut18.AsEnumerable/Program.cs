namespace LINQTut18.AsEnumerable
{
    //As - ?Deaferd Excution
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippingList<Shipping> shippings = ShippingRepository.AllAsShippingList;

            var todayShipping = shippings.Where(x => x.ShippingDate == DateTime.Today);

            todayShipping.Process("Today's shipping using ShippingList<T> Where");


            var todayShipping2 = shippings.AsEnumerable().Where(x => x.ShippingDate == DateTime.Today);

            todayShipping2.Process("Today's shipping using IEnumerable<T> Where");



            Console.ReadKey();
        }
    }

}
