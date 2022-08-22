namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArr = new int[4];
            numArr[0] = 1;
            Console.WriteLine(numArr[0]);
            Console.WriteLine(numArr[1]);
            Console.WriteLine(numArr[2]);

            var flags = new bool[5];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);
            Console.WriteLine(flags[3]);
            Console.WriteLine(flags[4]);
        }
    }
}