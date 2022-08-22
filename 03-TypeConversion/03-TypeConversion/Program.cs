namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            int i = b;
            Console.WriteLine(i);

            int i2 = 5;
            byte b2 = (byte)i;
            Console.WriteLine(b2);
        }
    }
}