using System;

namespace EulerProject
{
    public class Problem_005
    {
        private int minDividedNumber = 2;
        private int maxDividedNumber = 10;

        public void Run()
        {
            int number = maxDividedNumber;
            while(!IsDivided(number))
            {
                number++;
            }
            Console.WriteLine(number);
        }

        private bool IsDivided(int number)
        {
            for (int i = minDividedNumber; i <= maxDividedNumber; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}