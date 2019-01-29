using System;

namespace EulerProject
{
    public class Problem_010
    {
        public void Run()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var number = 2000000;
            long sumPrimes = 0;

            for (int i = 2; i < number; i ++)
            {
                if (IsPrime(i))
                {
                    sumPrimes += i;
                }
            }

            Console.WriteLine(sumPrimes);

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