using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._5_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string userText = Console.ReadLine();
            string reversed = Reverse(userText);
            Console.WriteLine("Переставленные слова: " + reversed);
        }

        static string[] SplitText(string text)
        {
            char[] delimiter = { ' ' };
            string[] words = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        static string Reverse(string text)
        {
            string[] words = SplitText(text);
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}
