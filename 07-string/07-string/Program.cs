namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Zoe";
            Console.WriteLine(firstName[0]);
            var strArr = new string[] { "aaa", "bbb", "ccc" };
            string list = string.Join(",", strArr);
            Console.WriteLine(list);
        }
    }
}