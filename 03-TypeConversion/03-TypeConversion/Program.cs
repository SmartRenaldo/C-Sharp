namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte b = 5;
                int i = b;
                Console.WriteLine(i);

                int i2 = 6;
                byte b2 = (byte)i2;
                Console.WriteLine(b2);

                int i3 = 555;
                byte b3 = (byte)i3;
                Console.WriteLine(b3);

                var numStr = "34567";
                var num = Convert.ToInt32(numStr);
                Console.WriteLine(num);

                string boolStr = "false";
                bool flag = Convert.ToBoolean(boolStr);
                Console.WriteLine(flag);
            }
            catch (Exception)
            {
                Console.WriteLine("Casting Error!");
            }
            
        }
    }
}