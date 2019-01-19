using System;

namespace EulerProject
{
    public class Problem_004
    {
        public void Run()
        {
            var maxNumber = 999;
            var minNumber = 100;

            var maxPalindrome = 0;

            for (int i = maxNumber; i >= minNumber; i--)
            {
                for (int j = maxNumber; j >= minNumber; j--)
                {
                    var number = i * j;
                    if (IsPalindrome(number))
                    {
                        if (maxPalindrome < number)
                        {
                            maxPalindrome = number;
                        }
                    }
                }
            }
            Console.WriteLine(maxPalindrome);
        }

        private bool IsPalindrome(int number)
        {
            string numbers = number.ToString();

            var halfLenth = numbers.Length / 2;

            for (int i = 0; i < halfLenth; i++)
            {
                if (numbers[i] != numbers[numbers.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}