using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaine2
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeChainee<int> maListe = new ListeChainee<int>();
            maListe.Add(5);
            maListe.Add(22);
            maListe.Add(12);
            Console.WriteLine(maListe.Premier.Value);
            Console.WriteLine(maListe.Premier.Suivant.Value);
            Console.WriteLine(maListe.Premier.Suivant.Suivant.Value);
            maListe.Insert(2222, 1);
            for (int i = 0; i < maListe.Count; i++)
            {
                Console.WriteLine(maListe.GetElementById(i).Value);
            }
        }
    }
}
