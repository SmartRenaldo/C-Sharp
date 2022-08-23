using System.Text;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Method");
            builder.Replace('-', '+');
            builder.Remove(0, 5);
            Console.WriteLine(builder.ToString());
        }
    }
}