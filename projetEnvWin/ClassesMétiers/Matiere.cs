using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    /*fait par Guillaume*/
    class Matiere
    {
        List<Partie> listePartie;

        public Matiere(List<Partie> p_listePartie)
        {
            this.listePartie = p_listePartie;
        }
    }
}