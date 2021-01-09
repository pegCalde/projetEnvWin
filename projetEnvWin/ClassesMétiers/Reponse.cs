using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    public class Reponse
    /*fait par Guillaume*/
    class Reponse
    {
        string contenu;
        int statut;

        public Reponse(String p_contenu, int p_statut)
        {
            this.contenu = p_contenu;
            this.statut = p_statut;
        }

        public string Contenu
        {
            get { return contenu; }
            set { contenu = value; }
        }
    }    
}