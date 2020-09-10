using System;

namespace Revers
{
    class Solution
    {

        public static int Reverse(int x)
        {
            int rev = 0;
            while (x > 0)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }
            return rev;
        }

        static void Main(String[] args)
        { 
              Console.Write(" Укажите Числа : ");              
                Console.Write("Числа в реверсе : "
                        + Reverse(Convert.ToInt32(Console.ReadLine())));
        }
    }
}
