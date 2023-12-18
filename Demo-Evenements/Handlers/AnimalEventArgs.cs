using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Evenements.Handlers
{
    internal class AnimalEventArgs : EventArgs
    {
        public string AnimalName { get; set; }
        public int AnimalFaimLevel { get; set; }

        public AnimalEventArgs( string name, int faim)
        {
            AnimalName = name;
            AnimalFaimLevel = faim;
        }
    }
}
