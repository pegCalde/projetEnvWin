using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    class Partie
    {
        List<Question> listeQuestion;

        public Partie(List<Question> p_listeQuestion)
        {
            this.listeQuestion = p_listeQuestion;
        }
    }
}