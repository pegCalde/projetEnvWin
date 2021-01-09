using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnvWin.Données
{
    class QuestionsMaths : ObservableCollection<Question>
    {
        /*création + ajout des questions par Peggy
        * classe terminée par Guillaume*/
        public QuestionsMaths() : base()
        {
            //String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction
            /*MATHS*/
            /**GEOMETRIE**/
            ReponsesMaths answers = new ReponsesMaths();
            Add(new Question("Un triangle qui a un angle droit est un triangle : ", new List<Reponse>() { answers[0], answers[1], answers[2] }, new List<int>() { answers[0].Statut, answers[1].Statut, answers[2].Statut }, Question.Type.CLOSE));
            Add(new Question("Vrai ou faux : s'ils ont la même aire, un carré et un rectangle ont aussi le même périmètre", new List<Reponse>() { answers[3], answers[4], answers[5] }, new List<int>() { answers[3].Statut, answers[4].Statut, answers[5].Statut }, Question.Type.CLOSE));
            Add(new Question("Qui couvre la plus grande surface ?", new List<Reponse>() { answers[6], answers[7], answers[8] }, new List<int>() { answers[6].Statut, answers[7].Statut, answers[8].Statut }, Question.Type.CLOSE));
            Add(new Question("Un carré a tous ses côtés : ", new List<Reponse>() { answers[9], answers[10], answers[11] }, new List<int>() { answers[9].Statut, answers[10].Statut, answers[11].Statut }, Question.Type.CLOSE));
            Add(new Question("Comment s'appelle un triangle qui a 2 côtés de même longeur ?", new List<Reponse>() { answers[12], answers[13], answers[14] }, new List<int>() { answers[12].Statut, answers[13].Statut, answers[14].Statut }, Question.Type.CLOSE));
            /**CALCUL**/
            Add(new Question("Tables de multiplications : 8x8= ", new List<Reponse>() { answers[15], answers[16], answers[17] }, new List<int>() { answers[15].Statut, answers[16].Statut, answers[17].Statut }, Question.Type.CLOSE));
            Add(new Question("Divisions : 102 / 3 = ", new List<Reponse>() { answers[18], answers[19], answers[20] }, new List<int>() { answers[18].Statut, answers[19].Statut, answers[20].Statut }, Question.Type.CLOSE));
            Add(new Question("Quel est le reste de la division de 99 par 5 ?", new List<Reponse>() { answers[21], answers[22], answers[23] }, new List<int>() { answers[21].Statut, answers[22].Statut, answers[23].Statut }, Question.Type.CLOSE));
            Add(new Question("Priorités de calcul : 2 x 3 + 4 x 5 = ", new List<Reponse>() { answers[24], answers[25], answers[26] }, new List<int>() { answers[24].Statut, answers[25].Statut, answers[26].Statut }, Question.Type.CLOSE));
            Add(new Question("J'ai 35 bonbons, j'en donne 5 à mes 7 copains. Combien me reste-t-il de bonbons ?", new List<Reponse>() { answers[27], answers[28], answers[29] }, new List<int>() { answers[27].Statut, answers[28].Statut, answers[29].Statut }, Question.Type.CLOSE));
            /**NUMERATION**/
            Add(new Question("Écris ces nombres en chiffres : ", new List<Reponse>() { answers[30], answers[31], answers[32] }, new List<int>() { answers[30].Statut, answers[31].Statut, answers[32].Statut }, Question.Type.CLOSE));
            Add(new Question("15 743 < 325 806 est : ", new List<Reponse>() { answers[33], answers[34], answers[35] }, new List<int>() { answers[33].Statut, answers[34].Statut, answers[35].Statut }, Question.Type.CLOSE));
            Add(new Question("Ecris 13/10 sous la forme d'un nombre décimal", new List<Reponse>() { answers[0], answers[1], answers[2] }, new List<int>() { answers[0].Statut, answers[1].Statut, answers[2].Statut }, Question.Type.CLOSE));
            Add(new Question("Dans 6,34 : 3 est le chiffre des : ", new List<Reponse>() { answers[36], answers[37], answers[38] }, new List<int>() { answers[36].Statut, answers[37].Statut, answers[38].Statut }, Question.Type.CLOSE));
            Add(new Question("4,2 est plus proche de 4 que de 5", new List<Reponse>() { answers[39], answers[40], answers[41] }, new List<int>() { answers[39].Statut, answers[40].Statut, answers[41].Statut }, Question.Type.CLOSE));
            /**MESURES**/
            Add(new Question("Dans une heure, combien y a t'il de minutes ?", new List<Reponse>() { answers[42], answers[43], answers[44] }, new List<int>() { answers[42].Statut, answers[43].Statut, answers[44].Statut }, Question.Type.CLOSE));
            Add(new Question("Qu'est ce qui est plus petit que 5 cm ?", new List<Reponse>() { answers[45], answers[46], answers[47] }, new List<int>() { answers[45].Statut, answers[46].Statut, answers[47].Statut }, Question.Type.CLOSE));
            Add(new Question("Quel baton est le plus long ?", new List<Reponse>() { answers[48], answers[49], answers[50] }, new List<int>() { answers[48].Statut, answers[49].Statut, answers[50].Statut }, Question.Type.CLOSE));
            Add(new Question("Voici la taille de 4 enfants. Quel est le plus petit ?", new List<Reponse>() { answers[51], answers[52], answers[53] }, new List<int>() { answers[51].Statut, answers[52].Statut, answers[53].Statut }, Question.Type.CLOSE));
            Add(new Question("Qu'est ce qui mesure autant que 300 cm ?", new List<Reponse>() { answers[54], answers[55], answers[56] }, new List<int>() { answers[54].Statut, answers[55].Statut, answers[56].Statut }, Question.Type.CLOSE));
        }

        public Question GetQuestion(String enonce)
        {
            return null;
        }
    }
}
