using System;
using System.Text.RegularExpressions;

namespace Palindrome_text
{
    class Solution
    {
        public static bool IsPalindrome(string x)
        {
            string Low, Match, Pal;

            Low = x.ToLower();
            Regex myReg = new Regex(@"^[a-zA-Z0-9]+$");
            Match = Regex.Replace(Low, @"\d", "");
            Match match = myReg.Match(Match);

            Pal = match.Value;

            if (Pal.Length <= 1)
                return true;
            else
            {
                if (Pal[0] != Pal[Pal.Length - 1])
                    return false;
                else
                    return IsPalindrome(Pal.Substring(1, Pal.Length - 2));
            }
        }
        static void Main(string[] args)
        {
            bool Expo;

            Console.Write("\n Для того чтобы проверить есть ли Текст палиндромным укажите снизу эго:\n");
            Console.Write("---------------------------------------------------------------\n ");

            Console.Write(" Укажите Текст : ");
            Expo = IsPalindrome(Console.ReadLine());

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
