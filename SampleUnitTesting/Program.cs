using System;

namespace SampleUnitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            Console.WriteLine("Adding ints");
            return a + b;
        }
    }
}
