using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the start number of the range: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the end number of the range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime numbers between {0} and {1} are :",start,end);


            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("\n"+i);
                }
            }
           
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}