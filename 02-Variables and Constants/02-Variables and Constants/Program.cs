namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 5;
            Console.WriteLine(number);

            const int conNum = 7;
            Console.WriteLine(conNum);

            string name = "Tara";
            Console.WriteLine(name);

            var num2 = 10;
            Console.WriteLine(num2);

            var price = 10.99f;
            Console.WriteLine(price);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            var s = "5";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}