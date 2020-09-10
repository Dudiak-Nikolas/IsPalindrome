using System;

namespace prog_1
{
    class Solution
    {
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var len = (int)Math.Log10(x);

            while (x != 0)
            {
                var low = x % 10;
                var high = x / (int)Math.Pow(10, len);

                if (low != high) return false;
                x = x % (int)Math.Pow(10, len) / 10;

                len -= 2;
            }
            return true;
        }

        public static void Main()
        {
            Console.Write("\n\n Для того чтобы проверить есть ли числа палиндромными укажите снизу их :\n");
            Console.Write("---------------------------------------------------------------\n");
            string str1;
            int to;
            bool tf;
          
            Console.Write(" Укажите Числа : ");
            str1 = Console.ReadLine();
            to = Convert.ToInt32(str1);
            tf = Solution.IsPalindrome(to);
            if (tf == true)
            {
                Console.WriteLine(" Эти числа являются палиндромними.\n");
            }
            else
            {
                Console.WriteLine(" Эти числа не являются палиндромними.\n");
            }
            Console.Read();
        }

    }
}
