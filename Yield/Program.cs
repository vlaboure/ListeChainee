using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string prenom in ObtenirListeDePrenoms())
            {
                Console.WriteLine(prenom);
            }
        }

        public static IEnumerable<string> ObtenirListeDePrenoms()
        {
            yield return "Nicolas";
            yield return "Jérémie";
            yield return "Delphine";
        }
    }
}
