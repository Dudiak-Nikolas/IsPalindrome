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
            string vin, Text, Lov, Tow;
            bool to;
            

            Console.Write("\n Для того чтобы проверить есть ли Текст палиндромным укажите снизу эго:\n");
            Console.Write("---------------------------------------------------------------\n ");

            Console.Write(" Укажите Текст : ");
            vin = Console.ReadLine();
            Lov = vin.ToLower();
            Regex myReg = new Regex(@"[a-zA-Z,\s]{5,50}");
            Tow = Regex.Replace(Lov, @"\d", " ");
            Match match = myReg.Match(Tow);

            Text = match.Value;
           
            to = IsPalindrome(Text);

            if(to == true)
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
