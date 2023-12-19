using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Generique_03
{
    internal class Formation
    {
        public string Name { get; private set; }

        public Formation(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Formation : {Name}";
        }
    }
    internal class Formation<T> : Formation where T : Personne, IPersonneFinale
    {
        private List<T> _list;

        public Formation(string name) : base(name)
        {
            _list = new List<T>();
        }

        public void Inscrire(T participant) {
            _list.Add(participant);
        }

        public string ListEtudiant()
        {
            string result = "";
            foreach (T personne in _list)
            {
                if (personne is MembreEntreprise m)
                    result += $"{m.Nom} {m.Prenom} {m.NomEntreprise}\n";
                else
                    result += $"{personne.Nom} {personne.Prenom}\n";
            }
            return result;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{ListEtudiant()}";
        }
    }
}
