namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            int i = b;
            Console.WriteLine(i);

            int i2 = 6;
            byte b2 = (byte)i2;
            Console.WriteLine(b2);

            int i3 = 555;
            byte b3 = (byte)i3;
            Console.WriteLine(b3);
        }
    }
}