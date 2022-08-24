namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Hello");
        }
    }
}