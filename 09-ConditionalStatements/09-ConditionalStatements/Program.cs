namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 11;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("Afternoon");
            }
            else
            {
                Console.WriteLine("Evening");
            }
        }
    }
}