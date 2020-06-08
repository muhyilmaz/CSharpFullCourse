using System;

namespace CA.IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;
            PrimeNumber(number);

        }

        private static void PrimeNumber(int number)
        {
            if (IsPrime(number))
            {
                Console.WriteLine("Prime Number");
            }
            else Console.WriteLine("Not Prime Number");
        }

        private static bool IsPrime(int number)
        {
            

            for (int i = 2; i < number-1; i++)
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
