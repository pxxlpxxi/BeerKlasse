using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKlasse
{
    internal class CompareName : IComparer<Beer>
    {
        public int Compare(Beer? x, Beer? y)
        {
            return x.Navn.CompareTo(y.Navn);
        }

    }
}
