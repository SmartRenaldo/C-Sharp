namespace CSharpFundamentals
{
    public enum Shipping
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var express = Shipping.Express;
            Console.WriteLine(express);
            Console.WriteLine((int)express);

            Console.WriteLine((Shipping)2);

            Console.WriteLine(express.ToString());
            var shippingExpress = (Shipping)Enum.Parse(typeof(Shipping), express.ToString());
            Console.WriteLine(shippingExpress);
        }
    }
}