using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace projetEnvWin
{
    /*fait par Guillaume*/
    public class Partie
    {
        List<Question> listeQuestion;
        string nom;

        public Partie(List<Question> p_listeQuest, string p_nom)
        {
            this.listeQuestion = p_listeQuest;
            this.nom = p_nom;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<Question> ListeQuestion
        {
            get { return listeQuestion; }
            set { listeQuestion = value; }
        }

        public Question this[string value]
        {
            get
            {
                foreach (Question q in ListeQuestion)
                {
                    if (q.Enonce == value)
                    {
                        return q;
                    }
                }
                return null;
            }
        }
    }
}