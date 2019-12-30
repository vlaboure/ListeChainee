using System;
using System.Collections.Generic;
using System.Text;

namespace ListeChainee 
{//ajouter supprimer à l'indice et vider liste
    public class ListeChainee<T>
    {
        public int Count{ get; set; }
        public Chainage<T> Premier { get; set; }
        public Chainage<T> Dernier
        {
            get
            {//si chaine vide retouner null
                if (Premier == null)
                    return null;
                //premier élément premier = dernier pour la boule while de parcour de liste
                Chainage<T> dernier = Premier;
                //tant qu'on est pas à la fin de la liste
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
        public void AjouterElement(T element)
        {
            Count++;
            // a chaque insertion on met à jour les valeurs premier et dernier
            if (Premier == null)
            {
                //si pas de premier nouvelle liste
                Premier = new Chainage<T> { Valeur = element };
            }
            else
            {   //sinon on crée une variable temporaire dernier de type Chainage et on l'inintialise avec la derinière valeur
                Chainage<T> dernier = Dernier;
                //là.. on ajoute en dernier
                //on crée une instance dernier.suivant on donne la valeur element au dernier et la valeur avant insertion
                // a précédent
                dernier.Suivant = new Chainage<T> { Valeur = element, Precedent = dernier };
                //on fait un new Chainage pk la classe chainage est l'objet générique ajouté dans la liste
                // cet objet possède la propriété précédent et suivant et un valeur
            }        
        }
        public Chainage<T> ObtenirElement(int indice)
        {
            //chainage.Dernier contient le dernier alimenté dans AjouterElement
            //précédent a été alimenté par l'ancienne valeur
            Chainage<T> temp = Premier;
            for(int i = 1; i <= indice; i++)
            {// si vide on retourne null et on sort
            //sinon on retourne le suivant jusque indice
            //i=0 --> suivant du premier
            //i=1 --> suivant du deuxième ....
                if (temp == null)
                    return null;
                temp = temp.Suivant;
            }
            return temp;
        }
        public void Inserer(T element, int indice)
        {
            Count++;
            if (indice == 0)
            {//insertion en première position
                Chainage<T> temp = Premier;
             //on fait un new Chainage pk la classe chainage est l'objet générique inséré dans la liste
             // cet objet possède la propriété précédent et suivant et un valeur
                Premier = new Chainage<T> { Suivant = temp, Valeur = element };
          //      temp.Precedent = Premier;
            }
            else
            {
                Chainage<T> elementALindice = ObtenirElement(indice);
                if (elementALindice == null)//pas d'élément à l'indice
                    AjouterElement(element);
                else
                {   //précédent d'élément à l'indice
                    Chainage<T> precedent = elementALindice.Precedent;
                    Chainage<T> temp = precedent.Suivant;
                    //*************
                    //Création de l'élement suivant générique 
                    //on alimente en fonction de precedent et value--> Suivant = précédent.suivant.. 
                    precedent.Suivant = new Chainage<T> { Suivant = temp, Precedent=precedent, Valeur = element };
                    // temp.Precedent = temp;
                    temp.Precedent = precedent.Suivant;
                }

            }

        }
        public void SuppElement(int indice)
        {
            Chainage<T> elementALindice = ObtenirElement(indice);
            if (elementALindice != null)
            {
                Count--;
                if (indice != 0)
                {                    
                    Chainage<T> precedent = elementALindice.Precedent;
                    precedent.Suivant = elementALindice.Suivant;
               //     Chainage<T> suiv = elementALindice.Suivant;

                }
                else
                {
             //       Chainage<T> tp = Premier;
                    Premier = elementALindice.Suivant;
                }
            }         
        }
    }
}
