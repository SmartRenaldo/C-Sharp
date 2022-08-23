namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            for (int i = 9; i >= 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            var name = "Scott Morrison";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine();

            foreach (var ch in name)
            {
                Console.WriteLine(ch);
            }

            Console.WriteLine();

            var t = 0;

            while (t <= 20)
            {
                if (t % 4 == 0)
                    Console.WriteLine(t);
                t++;
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write("Type a string: ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine(input);
            }
        }
    }
}