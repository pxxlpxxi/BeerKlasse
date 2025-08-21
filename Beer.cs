using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKlasse
{
    enum BeerType
    {
        Lager,
        Pilsner,
        Münchener,
        WienerDortmunder,
        Bock,
        Doppelbock,
        Porter,
        Mix
    }
    internal class Beer : IComparable<Beer>
    {
        //private fields
        private string _navn;
        private BeerType _slags;
        private float _procent;
        private int _volumenCl;

        //properties, get og set til alle fields
        public string Navn { get { return _navn; } set { _navn = value; } }
        public BeerType Slags { get { return _slags; } set { _slags = value; } }
        public float Procent { get { return _procent; } set { _procent = value; } }
        public int VolumenCl { get { return _volumenCl; } set { _volumenCl = value; } }

        public Beer()
        {

        }
        public Beer(string navn, BeerType slags, float procent, int volumen)
        {
            _navn = navn;
            _slags = slags;
            _procent = procent;
            _volumenCl = volumen;
        }
        public override string ToString()
        {
            string retur = $"\nNavn: {Navn}" +
                $"\nType: {Slags}" +
                $"\nProcent: {Procent}%" +
                $"\nVolumen: {VolumenCl}cl." +
                $"\nGenstande: {GetUnits():N2}";
            return retur; //base.ToString();
        }
        public double GetUnits()
        {
            return _volumenCl*_procent/150;
        }
        public static Beer operator + (Beer beer1, Beer beer2)
        {
            float nyPct = (beer1._volumenCl * beer1._procent + beer2._volumenCl * beer2._procent)
                    / (beer1._volumenCl + beer2._volumenCl);
            BeerType nyType = BeerType.Mix;
            int nyVolumen=beer1._volumenCl + beer2._volumenCl;


            return new Beer($"{beer1._navn}-{beer2._navn}", nyType, nyPct, nyVolumen);
        }

        int IComparable<Beer>.CompareTo(Beer? other)
        {
            return this.Procent.CompareTo(other.Procent);
        }
    }
}
