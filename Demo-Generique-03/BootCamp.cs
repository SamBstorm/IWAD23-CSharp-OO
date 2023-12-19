using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal class BootCamp<T> : Formation<T> where T : Personne, IPersonneFinale
    {
        public BootCamp(string name) : base(name)
        {
        }
    }
}
