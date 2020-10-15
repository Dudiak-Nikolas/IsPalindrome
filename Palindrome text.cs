using System;
using System.Linq;

namespace Palindrome_text
{
    class Solution
    {
        public static bool IsFilter(string y)
        {
            if (y != string.Concat(y.Where(x => char.IsLetterOrDigit(x))))
                return true;
            else 
            {
                var newText = string.Concat(y.ToLower()
                    .Where((a) => char.IsDigit(a) || (a >= 'a' & a <= 'z'))
                    .Where(x => !char.IsDigit(x))
                    .ToArray());
                var export = IsPalindrome(newText);
                return export;
            }
        }



        private static bool IsPalindrome(string x)
        {
            if (x.Length <= 1)
                return true;
            else
            {
                if (x[0] != x[x.Length - 1])
                    return false;
                else
                    return IsPalindrome(x.Substring(1, x.Length - 2));
            }
        }
            static void Main(string[] args)
            {
                bool Expo;

                Console.Write("\n Для того чтобы проверить есть ли Текст палиндромным укажите снизу эго:\n");
                Console.Write("---------------------------------------------------------------\n ");

                Console.Write(" Укажите Текст : ");
                Expo = IsFilter(Console.ReadLine());

                if (Expo == true)
                {
                    Console.WriteLine(" Этот текст являются палиндромним.\n");
                }
                else
                {
                    Console.WriteLine(" Этот текст не являются палиндромним.\n");
                }
                Console.Read();
         }
    }
}
