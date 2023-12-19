using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Evenements.Models
{

    //internal delegate void AnimalActionEventHandler(object sender, EventArgs args);
    //Le délégué AnimalActionEventHandler peut être remplacé par un EventHandler, mais aussi par le délégué générique Action<object,EventArgs>
    internal abstract class Animal
    {
        //public event AnimalActionEventHandler AvoirFaim = null;
        public event EventHandler AvoirFaim = null;
        protected int _faim;

        public virtual int Faim
        {
            get { return _faim; }
            set {
                if (value < 0) value = 0;
                else if (value > 10) value = 10;
                _faim = value;
                if (_faim < 5) { 
                    RaiseAvoirFaimEvent(this, EventArgs.Empty);
                }
            }
        }

        public string Name { get; protected set; }

        public Animal()
        {
            _faim = 10;
        }

        protected void RaiseAvoirFaimEvent(object sender, EventArgs args)
        {
            AvoirFaim?.Invoke(sender, args);
        }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
