using projetEnvWin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnvWin.Données
{
    class Reponses : ObservableCollection<Reponse>
    {
        public Reponses() : base()
        {
            //String p_contenu, Type p_type, int p_statut
            /*Comment s'appelle un triangle qui a 2 côtés de même longeur ?*/
            Add(new Reponse("Un triangle isocèle", 1));
            Add(new Reponse("Un triangle équilatéral", -1));
            Add(new Reponse("Un triangle quelconque", -1));
            /*Qui couvre la plus grande surface ?*/
            Add(new Reponse("Un carré de côté de longueur a", 1));
            Add(new Reponse("Un cercle de diamètre de longueur a", -1));
            Add(new Reponse("Un rectangle dont la diagonale mesure a", -1));
            /*Vrai ou faux : s'ils ont la même aire, un carré et un rectangle ont aussi le même périmètre*/
            Add(new Reponse("Vrai", -1));
            Add(new Reponse("Faux", 1));
            Add(new Reponse("Je sais pas", -1));
            /*Un carré a tous ses côtés : */
            Add(new Reponse("Parallèles", -1));
            Add(new Reponse("Perpendiculaires", -1));
            Add(new Reponse("De même longueur", 1));
            /*Un triangle qui a un angle droit est un triangle*/
            Add(new Reponse("Triangle rectangle", 1));
            Add(new Reponse("Triangle isocèle", -1));
            Add(new Reponse("Triangle équilatéral", -1));
        }

        public Reponse GetReponse(String contenu)
        {
            return null;
        }
    }
}
