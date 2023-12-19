using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Démo_Generique
{
    internal class ListGeneric<T>
    {
        private ArrayList _list;

        public T this[int index]
        {
            get
            {
                if (index >= _list.Count || index < 0) throw new ArgumentOutOfRangeException(nameof(index), $"L'index doit être compris entre 0 et {_list.Count - 1} inclus.");
                return (T)_list[index];
            }
        }
        public int Count
        {
            get { return _list.Count; }
        }
        public ListGeneric()
        {
            _list = new ArrayList();
        }

        public void Add(T value)
        {
            _list.Add(value);
        }
    }
}
