using System;
using System.Text;

namespace zadatak5
{
    class Program
    {
        public static bool DaLiJePalindrom(string x)
        {

            x = x.Replace(" ", String.Empty);
            x = x.ToLower();

            StringBuilder y = new StringBuilder(x);
            int i = 0, j = x.Length - 1;
            while (i < x.Length)
            {
                y[i] = x[j];
                i++;
                j--;
            }


            return x == y.ToString();

        }

        static void Main(string[] args)
        {
            Console.WriteLine(DaLiJePalindrom("nije palindrom"));
            Console.WriteLine(DaLiJePalindrom("anana"));
            Console.WriteLine(DaLiJePalindrom("ne znam"));
            Console.WriteLine(DaLiJePalindrom("abba"));
            Console.WriteLine(DaLiJePalindrom("false"));
            Console.ReadKey();
        }
    }
}
