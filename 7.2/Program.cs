using System;

namespace _7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.2, 2-й вариант, высокий уровень, Гребенюк А. 21-ИСП-2.

            Console.WriteLine("Введите первую строку: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string s2 = Console.ReadLine();
            string s3 = "";
            char prob = ' ';
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != prob)
                {
                    char ch = s1[i];
                    if (s2.IndexOf(ch) != -1)
                    {
                        s3 = s3 + s1[i] + prob;
                        s1 = s1.Replace(s1[i], prob);
                    }
                }
            }
            Console.WriteLine("Символы, имеющиеся в обеих строках: " + s3);
        }
    }
}
