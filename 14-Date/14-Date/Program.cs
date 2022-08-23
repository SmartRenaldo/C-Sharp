namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            numbers.Add(9);
            numbers.AddRange(new int[2] { -4, 0 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(numbers.IndexOf(-5));
            Console.WriteLine(numbers.IndexOf(5));
            Console.WriteLine("Count: " + numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 9)
                    numbers.Remove(numbers[i]);
            }

            foreach (var number in numbers)
                Console.WriteLine(number);
        }
    }
}