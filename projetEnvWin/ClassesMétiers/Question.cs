
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    /*fait par Guillaume*/
    public class Question
    {
        String enonce;
        List<Reponse> reponsesPossibles;
        List<int> correction;
        Type type;

        public Question(String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction, Type p_type)
        {
            this.enonce = p_enonce;
            this.reponsesPossibles = p_reponsesPossibles;
            this.correction = p_correction;
            this.type = p_type;
        }

        public enum Type
        {
            CLOSE, QCM, SORT
        }

        public string Enonce
        {
            get { return enonce; }
            set { enonce = value; }
        }

        public List<Reponse> ReponsesPossibles
        {
            get { return reponsesPossibles; }
            set { reponsesPossibles = value; }
        }

        public Type Types
        {
            get { return type; }
            set { type = value; }
        }
    }
}