using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKlasse
{
    internal class CompareVolumen : IComparer<Beer>
    {
        public CompareVolumen()
        {
        }

        public int Compare(Beer? x, Beer? y)
        {
            return x.VolumenCl.CompareTo(y.VolumenCl);
        }
    }
}
