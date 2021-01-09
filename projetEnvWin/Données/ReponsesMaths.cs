using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnvWin.Données
{
    class ReponsesMaths : ObservableCollection<Reponse>
    {
        /*fait par Peggy*/
        public ReponsesMaths() : base()
        {
            //String p_contenu, Type p_type, int p_statut
            /*MATHS*/
            /**GEOMETRIE**/
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
            /**CALCUL**/
            /*Tables de multiplications : 8x8= */
            Add(new Reponse("56", -1));
            Add(new Reponse("49", -1));
            Add(new Reponse("64", 1));
            /*Divisions : 102 / 3 = */
            Add(new Reponse("99", -1));
            Add(new Reponse("34", 1));
            Add(new Reponse("33", -1));
            /*Quel est le reste de la division de 99 par 5 ?*/
            Add(new Reponse("1", -1));
            Add(new Reponse("4", 1));
            Add(new Reponse("2", -1));
            /*Priorités de calcul : 2 x 3 + 4 x 5 = */
            Add(new Reponse("50", -1));
            Add(new Reponse("35", -1));
            Add(new Reponse("26", 1));
            /*J'ai 35 bonbons, j'en donne 5 à mes 7 copains. Combien me reste-t-il de bonbons ?*/
            Add(new Reponse("0", 1));
            Add(new Reponse("10", -1));
            Add(new Reponse("5", -1));
            /**NUMERATION**/
            /*Écris ce nombre en chiffres : Huit-cent-quatre-mille-six */
            Add(new Reponse("804 006", 1));
            Add(new Reponse("840 600", -1));
            Add(new Reponse("804 600", -1));
            /*15 743 < 325 806 est : */
            Add(new Reponse("Faux", -1));
            Add(new Reponse("Vrai", 1));
            Add(new Reponse("Je ne sais pas", -1));
            /*Ecris 13/10 sous la forme d'un nombre décimal*/
            Add(new Reponse("3", -1));
            Add(new Reponse("0,3", -1));
            Add(new Reponse("1.3", 1));
            /*Dans 6,34 : 3 est le chiffre des : */
            Add(new Reponse("dixièmes", 1));
            Add(new Reponse("millièmes", -1));
            Add(new Reponse("centièmes", -1));
            /*4,2 est plus proche de 4 que de 5*/
            Add(new Reponse("Vrai", 1));
            Add(new Reponse("Faux", -1));
            Add(new Reponse("Je ne sais pas", -1));
            /**MESURES**/
            /*Dans une heure, combien y a t'il de minutes ?*/
            Add(new Reponse("365", -1));
            Add(new Reponse("60", 1));
            Add(new Reponse("24", -1));
            /*Qu'est ce qui est plus petit que 5 cm ?*/
            Add(new Reponse("40 mm", 1));
            Add(new Reponse("40 cm", -1));
            Add(new Reponse("60 mm", -1));
            /*Quel baton est le plus long ?*/
            Add(new Reponse("1050 mm", -1));
            Add(new Reponse("1 m", 1));
            Add(new Reponse("120 cm", -1));
            /*Voici la taille de 4 enfants. Quel est le plus petit ?*/
            Add(new Reponse("Céleste - 1 m", -1));
            Add(new Reponse("Auguste - 89 cm", 1));
            Add(new Reponse("Désiré - 1100 mm", -1));
            /*Qu'est ce qui mesure autant que 300 cm ?*/
            Add(new Reponse("3 m", 1));
            Add(new Reponse("30 mm", -1));
            Add(new Reponse("30 m", -1));
        }

        public Reponse GetReponse(String contenu)
        {
            return null;
        }
    }
}
