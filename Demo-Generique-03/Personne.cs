using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal abstract class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
    }
}
