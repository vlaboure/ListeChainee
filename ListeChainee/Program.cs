using System;

namespace ListeChainee
{
    class Program
    {
        static void Main(string[] args)
        {
            ListeChainee<int> maListe = new ListeChainee<int>();
            maListe.AjouterElement(5);
            maListe.AjouterElement(22);
            maListe.AjouterElement(12);
            Console.WriteLine(maListe.Premier.Valeur);
            Console.WriteLine(maListe.Premier.Suivant.Valeur);
            Console.WriteLine(maListe.Premier.Suivant.Suivant.Valeur);
            Console.WriteLine("************************");
            Console.WriteLine(maListe.ObtenirElement(0).Valeur);
            Console.WriteLine(maListe.ObtenirElement(1).Valeur);
            Console.WriteLine(maListe.ObtenirElement(2).Valeur);
            Console.WriteLine("************************");
            maListe.Inserer(99, 0);
            maListe.Inserer(33, 2);
            maListe.Inserer(30, 2);
            Console.WriteLine(maListe.ObtenirElement(0).Valeur);
            Console.WriteLine(maListe.ObtenirElement(1).Valeur);
            Console.WriteLine(maListe.ObtenirElement(2).Valeur);
            Console.WriteLine(maListe.ObtenirElement(3).Valeur);
            Console.WriteLine(maListe.ObtenirElement(4).Valeur);
            Console.WriteLine(maListe.ObtenirElement(5).Valeur);
            Console.WriteLine("************************");
            maListe.SuppElement(4);
            for(int i = 0; i < maListe.Count; i++)
            {
                Console.WriteLine(maListe.ObtenirElement(i).Valeur);
            }
        }
    }
}
