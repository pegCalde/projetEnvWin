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
            public Questions() : base()
            {
            //String p_enonce, List<Reponse> p_reponsesPossibles, List<int> p_correction
                Add(new Question("Un triangle qui a un angle droit est un triangle : "));
                Add(new Question("Vrai ou faux : s'ils ont la même aire, un carré et un rectangle ont aussi le même périmètre"));
                Add(new Question("Qui couvre la plus grande surface ?"));
                Add(new Question("Un carré a tous ses côtés : "));
                Add(new Question("Comment s'appelle un triangle qui a 2 côtés de même longeur ?"));
            }

            public Question GetQuestion(String enonce)
            {
                return null;
            }
        }
    }
}
