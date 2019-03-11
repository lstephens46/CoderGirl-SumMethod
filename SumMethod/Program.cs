using System;

namespace SumMethod
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Sum(input);

            Console.ReadLine();
        }


        public static int Sum(int input)
      {
            return (input * (input + 1)) / 2;
        }
    }
}
