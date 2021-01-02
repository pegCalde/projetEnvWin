using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    class Reponse
    {
        String contenu;
        Type type;
        int statut;

        public Reponse(String p_contenu, Type p_type, int p_statut)
        {
            this.contenu = p_contenu;
            this.type = p_type;
            this.statut = p_statut;
        }
        
    }

    enum Type
    {
        CLOSE, QCM, SORT
    }
}