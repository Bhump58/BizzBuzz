using System;

namespace BizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            BizBuzz();
        }

        public static void BizBuzz()
        {
            Console.Write("Let's play a game of BizzBuzz. Pick a number from 1-100. This will be our stopping point:   ");
            var result = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= result; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine("Bizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Bizz");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
