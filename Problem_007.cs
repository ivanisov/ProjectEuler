using System;

namespace EulerProject
{
    public class Problem_007
    {
        public void Run()
        {
            var maxPrimes = 10001;

            var currentPrimeId = 0;
            var number = 2;
            while (currentPrimeId < maxPrimes)
            {
                if (IsPrime(number))
                {
                    currentPrimeId++;
                }
                number++;
            }
            Console.WriteLine(number - 1);
        }

        private bool IsPrime(int number)
        {
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