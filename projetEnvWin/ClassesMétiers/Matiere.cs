using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace projetEnvWin
{
    public class Matiere
    {
        string nom;
        List<Partie> listePartie;

        public Matiere(List<Partie> p_listePartie, string p_nom)
        {
            this.listePartie = p_listePartie;
            this.nom = p_nom;
        }

        public Matiere(string p_nom)
        {
            this.nom = p_nom;
        }

        public string Nom
        { 
            get { return nom; }
            set { nom = value; }
        }

        public List<Partie> ListePartie
        {
            get { return listePartie; }
            set { listePartie = value; }
        }        
    }
}