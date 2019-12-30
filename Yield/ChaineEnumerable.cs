using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Yield
//ne sera pas utilisé avec le yield
{
    class ChaineEnumerable : IEnumerable<char>
    {
        string chaine;

        public ChaineEnumerable(string valeur)
        {
            chaine=valeur;
        }
        public IEnumerator<char> GetEnumerator()
        {
            // Utilisation de Yield
            for (int i = 0; i < chaine.Length; i++)
            {
                yield return chaine[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
