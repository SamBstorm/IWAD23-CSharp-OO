using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal class DemandeurEmploi : Personne, IPersonneFinale
    {
        public DemandeurEmploi(string nom, string prenom) : base(nom, prenom)
        {
        }
    }
}
