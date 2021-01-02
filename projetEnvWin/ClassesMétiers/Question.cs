
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    class Question
    {
        String enonce;
        List<Reponse> reponsesPossibles;
        List<int> correction;

        public Question(String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction)
        {
            this.enonce = p_enonce;
            this.reponsesPossibles = p_reponsesPossibles;
            this.correction = correction;
        }
    }
}