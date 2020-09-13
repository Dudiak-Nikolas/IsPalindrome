using System;

namespace Revers
{
    class Solution
    {

        public static int Reverse(int x)
        {

            int rev = 0;
            while (x != 0)
            {
                int list = x % 10;
                int NewRev = rev * 10 + list;
                if((NewRev - list)/10 != rev)
                {
                    break;
                }
                rev = NewRev;

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
