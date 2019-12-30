using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Yield
{// classe permettant d'implémenter l'interface IEnumerable
    //ne sera pas utilisé avec le yield
    class ChaineEnumerateur : IEnumerator<char>
    {
        private string chaine;
        private int indice;
        public ChaineEnumerateur(string valeur)
        {
            indice = -1;
            chaine = valeur;
        }
        public char Current
        {
            //retourne le carctère de indice
            get{ return chaine[indice]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
    
        }

        public bool MoveNext()
        {
            indice++;
            return indice < chaine.Length;
        }

        public void Reset()
        {
            indice = -1;
        }
    }
}
