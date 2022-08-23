namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine(now);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(today);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine(tomorrow.ToLongDateString());
            Console.WriteLine(tomorrow.ToShortDateString());
            Console.WriteLine(tomorrow.ToLongTimeString());
            Console.WriteLine(tomorrow.ToShortTimeString());
            Console.WriteLine(tomorrow.ToString("yyyy MM dd HH mm ss"));

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine(duration);

            Console.WriteLine(timeSpan);
            Console.WriteLine("Total days: " + timeSpan.TotalDays);
            Console.WriteLine("Days: " + timeSpan.Days);

            Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        }
    }
}