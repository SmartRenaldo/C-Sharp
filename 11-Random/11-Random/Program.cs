namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var randomInt = random.Next();
            Console.WriteLine(randomInt);

            randomInt = random.Next(1, 10);
            Console.WriteLine(randomInt);

            randomInt = random.Next(97, 123);
            Console.WriteLine((char)randomInt);

            char[] buffer = new char[10];

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}