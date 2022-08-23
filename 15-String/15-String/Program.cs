namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "  Christina Liu ";
            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.Trim().ToLower());
            Console.WriteLine(fullName.Trim().ToUpper());

            var names = fullName.Trim().Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            var newFullName = fullName.Replace("Christina", "Christine");
            Console.WriteLine(newFullName.Trim());

            float price = 19.99f;
            Console.WriteLine(price.ToString("C"));
        }
    }
}