﻿namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[5] { 1, 2, 3, 4, 5 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}