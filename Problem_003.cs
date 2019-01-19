using System;

namespace EulerProject
{
    public class Problem_003
    {
        public void Run()
        {
            var number = 600851475143;
            var maxPrime = 0;
            for (int i = 0; i < number; i++)
            {
                var prime = 2;
                while (number % prime != 0)
                {
                    prime++;
                }
                number /= prime;
                maxPrime = prime;
            }
            Console.WriteLine(maxPrime);
        }
    }
}