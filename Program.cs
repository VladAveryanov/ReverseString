using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "123456789qwertyuioplkjhgfdsazxcvbnm";

            Console.WriteLine(Reverse(text));

        }

        public static string Reverse(string s)
        {
            if (s == null || s.Length <= 1) 
                return s;
            return Reverse(s.Substring(1)) + s[0];
        }
    }
}
