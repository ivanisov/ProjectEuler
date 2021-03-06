using System;

namespace EulerProject
{
    public class Problem_007
    {
        public void Run()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
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

            watch.Stop();
            Console.WriteLine("Time taken: " + watch.ElapsedMilliseconds + "ms");
        }

        private bool IsPrime(int number)
        {
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
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