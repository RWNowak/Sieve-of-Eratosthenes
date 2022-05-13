using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sito_Eratotenesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 1000000;
            bool[] liczby_pierwsze = new bool[MAX + 1];
            for (int i = 0; i < liczby_pierwsze.Length; i++)
            {
                liczby_pierwsze[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(MAX) + 1; i++)
            {
                if (liczby_pierwsze[i - 1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= MAX; j += i)
                    {
                        liczby_pierwsze[j - 1] = false;
                    }
                }
            }
            int count = 0;
            for (int i = 2; i < liczby_pierwsze.Length; i++)
            {
                if (liczby_pierwsze[i - 1])
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Istnieje {count} liczb pierwszych do {MAX}");
        }
    }
}
