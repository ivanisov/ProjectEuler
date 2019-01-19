using System;

namespace EulerProject
{
    public class Problem_002
    {
        public void Run()
        {
            var number = 4000000;
            var a = 0;
            var b = 1;
            var fib = 0;
            var sum = 0;
            while (fib <= number)
            {
                fib = a + b;
                a = b;
                b = fib;
                if (fib % 2 == 0)
                {
                    sum += fib;
                }
            }
            Console.WriteLine(sum);
        }
    }
}