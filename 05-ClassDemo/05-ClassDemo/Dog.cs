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
}