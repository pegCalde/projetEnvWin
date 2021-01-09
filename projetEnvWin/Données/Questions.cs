using projetEnvWin;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnvWin.Données
{
    class Questions : ObservableCollection<Question>
    {
        /*création + ajout des questions par Peggy
        * classe terminée par Guillaume*/
        public Questions() : base()
            {
            //String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction
            /*MATHS*/
                /**GEOMETRIE**/
                Add(new Question("Un triangle qui a un angle droit est un triangle : "));
                Add(new Question("Vrai ou faux : s'ils ont la même aire, un carré et un rectangle ont aussi le même périmètre"));
                Add(new Question("Qui couvre la plus grande surface ?"));
                Add(new Question("Un carré a tous ses côtés : "));
                Add(new Question("Comment s'appelle un triangle qui a 2 côtés de même longeur ?"));
                /**CALCUL**/
                Add(new Question("Tables de multiplications : 8x8= "));
                Add(new Question("Divisions : 102 / 3 = "));
                Add(new Question("Quel est le reste de la division de 99 par 5 ?"));
                Add(new Question("Priorités de calcul : 2 x 3 + 4 x 5 = "));
                Add(new Question("J'ai 35 bonbons, j'en donne 5 à mes 7 copains. Combien me reste-t-il de bonbons ?"));
                /**NUMERATION**/
                Add(new Question("Écris ces nombres en chiffres : "));
                Add(new Question("15 743 < 325 806 est : "));
                Add(new Question("Ecris 13/10 sous la forme d'un nombre décimal"));
                Add(new Question("Dans 6,34 : 3 est le chiffre des : "));
                Add(new Question("4,2 est plus proche de 4 que de 5"));
                /**MESURES**/
                Add(new Question("Dans une heure, combien y a t'il de minutes ?"));
                Add(new Question("Qu'est ce qui est plus petit que 5 cm ?"));
                Add(new Question("Quel baton est le plus long ?"));
                Add(new Question("Voici la taille de 4 enfants. Quel est le plus petit ?"));
                Add(new Question("Qu'est ce qui mesure autant que 300 cm ?"));
        }

            public Question GetQuestion(String enonce)
            {
                return null;
            }
        }
    }
}
