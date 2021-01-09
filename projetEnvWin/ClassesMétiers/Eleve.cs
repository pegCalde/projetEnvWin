using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    /*fait par Guillaume*/
    class Eleve
    {
        String nom;
        int note;

        public Eleve(String p_nom, int p_note)
        {
            this.nom = p_nom;
            this.note = p_note;
        }

        public String toString()
        {
            return "L'élève " + this.nom + " à reçu la note de " + this.note;
        }

        public string Nom
        {
            get { return this.nom; }
        }
    }
}