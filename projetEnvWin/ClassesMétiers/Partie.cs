using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    /*fait par Guillaume*/
    class Partie
    {
        List<Question> listeQuestion;

        public Partie(List<Question> p_listeQuestion)
        {
            this.listeQuestion = p_listeQuestion;
        }
    }
}