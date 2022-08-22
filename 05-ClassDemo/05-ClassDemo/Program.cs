namespace CSharpFundamentals
{
    public class Dog
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void bark()
        {
            Console.WriteLine("Barking...");
            Console.WriteLine(Name);
            Console.WriteLine(Description);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var cinnamon = new Dog();
            cinnamon.Name = "Cinnamon";
            cinnamon.Description = "A golden hair dog";
            cinnamon.bark();
        }
    }
}