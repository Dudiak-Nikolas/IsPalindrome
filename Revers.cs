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
                if ((NewRev - list) / 10 != rev)
                {
                    break;
                }
                rev = NewRev;

                x = x / 10;
            }
            return rev;
        }

        static void Main()
        {
            int a, Export;
            Console.Write("Укажите сколько нужно виполнить проверок в Реверсе : ");
            int i = int.Parse(Console.ReadLine());

            for (int j = 1; j <= i; j++)
            {
                try
                {
                    Console.Write("Укажите Числа : ");
                    a = unchecked(int.Parse(Console.ReadLine()));
                    Export = Solution.Reverse(a);

                    checked
                    {
                        Console.WriteLine("Числа в реверсе : " + Export + "\n");  
                    }
                }
                catch (OverflowException)
                {
                    Console.Write("Переполнение\n\n");
                }
            }
            Console.ReadLine();
        }
    }
}
