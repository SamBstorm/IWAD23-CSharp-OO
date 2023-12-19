using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal class MembreEntreprise : Personne, IPersonneFinale
    {
        public string NomEntreprise { get; private set; }
        public MembreEntreprise(string nom, string prenom, string nomEntreprise) : base(nom, prenom)
        {
            NomEntreprise = nomEntreprise;
        }
    }
}
