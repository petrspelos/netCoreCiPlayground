using System;

namespace NetCoreTravisPlayground
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        public static string DataToText(string name, int age)
        {
            return $"{name} is {age} years old.";
        }
    }
}
