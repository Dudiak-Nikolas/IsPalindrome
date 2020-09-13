using System;
using System.Text.RegularExpressions;

namespace Palindrome_text
{
    class Solution
    {
        public static bool IsPalindrome(string x)
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
            string Read, Low, Match, Value;
            bool Expo;


            Console.Write("\n Для того чтобы проверить есть ли Текст палиндромным укажите снизу эго:\n");
            Console.Write("---------------------------------------------------------------\n ");

            Console.Write(" Укажите Текст : ");
            Read = Console.ReadLine();
            Low = Read.ToLower();
            Regex myReg = new Regex(@"^[a-zA-Z0-9,\s]+$");
            Match = Regex.Replace(Low, @"\d", " ");
            Match match = myReg.Match(Match);

            Value = match.Value;

            Expo = IsPalindrome(Value);

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
