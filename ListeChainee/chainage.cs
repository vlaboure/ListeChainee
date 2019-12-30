using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee
{
    //T represente le générique
    public class Chainage<T>
    {
        //générique renvoie le suivant
        public Chainage<T>Precedent{ get; set; }
        //générique renvoie le suivant
        public Chainage<T> Suivant { get; set; }
        //pour entrer la valeur générique dans la chaine
        public T Valeur { get; set; }
    }
}
