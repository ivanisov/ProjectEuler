using System;

namespace EulerProject
{
    public class Problem_009
    {
        public void Run()
        {
            bool complete = false;
            for (int a = 3; a < 500; a += 2)
            {
                for (int b = 4; b < 500; b += 2)
                {
                    var powC = Math.Pow(a, 2) + Math.Pow(b, 2);
                    var c = Math.Sqrt(powC);
                    if (c % 1 == 0)
                    {
                        var sum = a + b + c;
                        if (sum > 1000)
                        {
                            break;
                        }
                        else if (sum == 1000)
                        {
                            Console.WriteLine(string.Format("{0} * {1} = {2}", a, b, c));
                            Console.WriteLine(a * b * c);
                            complete = true;
                            break;
                        }
                    }
                }
                if (complete) break;
            }
        }
    }
}