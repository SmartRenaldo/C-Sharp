namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4 };
            Console.WriteLine(Array.IndexOf(numbers, 3));
            Console.WriteLine();

            Array.Clear(numbers, 0, 2);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            int[] newNumbers = new int[3];
            Array.Copy(numbers, 1, newNumbers, 0, 3);
            Console.WriteLine();

            foreach (var newNumber in newNumbers)
            {
                Console.WriteLine(newNumber);
            }


            var matrix = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 }
            };

            /*foreach (int i in matrix)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j); 
                }
            }*/
        }
    }
}