using System;
using System.Linq;

namespace Anagrama_y_Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word1; string word2;
            Console.WriteLine("Ingrese la primera palabra");
            word1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda palabra");
            word2 = Console.ReadLine();
            if (IsAnagram(word1,word2) == true)
            {
                Console.WriteLine("SON ANAGRAMA!!");

            }
            else
            {
                Console.WriteLine("NO SON ANAGRAMA!!");
            }

        }
        public static bool IsAnagram(string word1, string word2)
        {
            string esAnagrama1 = SortWords(word1);
            string esAnagrama2 = SortWords(word2);

            if (esAnagrama1 == esAnagrama2)
            {
                return true;
            }
            else
            {
                return false;
            }
             
        }
        public static string SortWords(string word)
        {
            
            string ordenado;
            if (word == "")
            {
                string error = "Llene todos los espacios";
                Console.WriteLine(error);
                return error;
            }
            else
            {
                ordenado = new String(word.OrderBy(x => x).ToArray());
                return ordenado;
            }

        }
    }
}
