using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaine2
{
    public class ListeChainee<T>
    {
        public Chainage<T> Premier { get; private set; }
        public int Count { get; private set; }
        public Chainage<T> Dernier
        {
            get
            {
                if (Premier == null)
                    return null;
                Chainage<T> dernier = Premier;
                while (dernier.Suivant != null)
                {
                    dernier = dernier.Suivant;
                }
                return dernier;
            }
        }
        public ListeChainee()
        {
            Count = 0;
        }
        public void Add(T element)
        {
            Count++;
            if (Premier == null)
                Premier = new Chainage<T> { Value = element };
            else
            {
                Chainage<T> dernier = Dernier;
                Dernier.Suivant = new Chainage<T> { Value = element, Precedent = dernier };
            }
        }
        public Chainage<T> GetElementById(int id)
        {
            Chainage<T> tp = Premier;
            for (int i = 1; i <= id; i++)
            {
                if (tp == null)
                    return null;
                tp = tp.Suivant;
            }
            return tp;
        }
        public void Insert(T element, int id)
        {
            Count++;
            if (id == 0)
            {
                Chainage<T> tp = Premier;
                Premier = new Chainage<T> { Value = element, Suivant = tp };
            }
            else
            {
                Chainage<T> elementAIndice = GetElementById(id);
                if (elementAIndice == null)
                    Set(element);
                else
                {
                    Chainage<T> precedent = elementAIndice.Precedent;
                    Chainage<T> tp = precedent.Suivant;
                    precedent.Suivant = new Chainage<T> { Value = element, Suivant = tp, Precedent = precedent };
                    //tp.Precedent = precedent.Suivant;
                }
            }
        }
    }
}
