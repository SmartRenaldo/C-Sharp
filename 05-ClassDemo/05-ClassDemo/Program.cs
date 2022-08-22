using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinnamon = new Dog();
            cinnamon.Name = "Cinnamon";
            cinnamon.Description = "A golden hair dog";
            cinnamon.bark();

            int res = Calculator.Add(5, 6);
            Console.WriteLine(res);
        }
    }
}