using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démo_Generique
{
    internal class ListString
    {
        private ArrayList _list;

        public string this[int index]
        {
            get
            {
                if (index >= _list.Count || index < 0) throw new ArgumentOutOfRangeException(nameof(index), $"L'index doit être compris entre 0 et {_list.Count - 1} inclus.");
                return (string)_list[index];
            }
        }

        public int Count
        {
            get { return _list.Count; }
        }

        public ListString()
        {
            _list = new ArrayList();
        }

        public void Add(string str)
        {
            _list.Add(str);
        }
    }
}
