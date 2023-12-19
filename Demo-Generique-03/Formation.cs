using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal class Formation<T> where T : Personne, IPersonneFinale
    {
        private List<T> _list;

        public Formation()
        {
            _list = new List<T>();
        }

        public void Inscrire(T participant) {
            _list.Add(participant);
        }

        public void ListEtudiant()
        {
            foreach (T personne in _list)
            {
                if (personne is MembreEntreprise m)
                    Console.WriteLine($"{m.Nom} {m.Prenom} {m.NomEntreprise}");
                else
                    Console.WriteLine($"{personne.Nom} {personne.Prenom}");
            }
        }
    }
}
