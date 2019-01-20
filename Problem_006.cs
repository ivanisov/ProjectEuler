using System;

namespace EulerProject
{
    public class Problem_006
    {
        public void Run()
        {
            var maxNumbers = 100;

            Console.WriteLine(SquareOfSum(maxNumbers) - SumOfSquares(maxNumbers));
        }

        private int SumOfSquares(int toNumber)
        {
            var sum = 0;
            for (int i = 1; i <= toNumber; i++)
            {
                sum += Pow(i);
            }
            return sum;
        }

        private int SquareOfSum(int toNumber)
        {
            var sum = 0;
            for (int i = 1; i <= toNumber; i++)
            {
                sum += i;
            }
            return Pow(sum);
        }

        private int Pow(int number)
        {
            return number * number;
        }
    }
}