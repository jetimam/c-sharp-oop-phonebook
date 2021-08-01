using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    static class Utils
    {
        public static string stringInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        public static int intInput(string text)
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static char charInput(string text)
        {
            Console.WriteLine(text);
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
