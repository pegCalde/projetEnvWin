using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetEnvWin.Données
{
    class Eleves : ObservableCollection<Eleve>
    {
        /*fait par Guillaume*/
        public Eleves(): base()
        {
            Add(new Eleve("Savin Guillaume", 0));
            Add(new Eleve("Calderon Peggy", 0));
            Add(new Eleve("Tachibana Kanade", 0));
        }

        public Eleve GetEleve(String nom) 
        {
            foreach(Eleve e in this)
            {
                if(e.Nom == nom)
                {
                    return e;
                }
            }

            return null;
        }
    }
}
