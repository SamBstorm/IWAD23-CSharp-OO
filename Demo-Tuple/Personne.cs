using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Tuple
{
    internal class Personne
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public void Deconstruct(out string nom, out string prenom)
        {
            nom = this.Nom;
            prenom = this.Prenom;
        }
    }
}
