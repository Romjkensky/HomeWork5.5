using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string userText = Console.ReadLine(); 
            string[] words = SplitText(userText); 
            Console.WriteLine("Слова в предложении:");
            PrintWords(words);
        }

        static string[] SplitText(string text)
        {
            char[] delimiter = { ' ' };
            string[] words = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        static void PrintWords(string[] words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
