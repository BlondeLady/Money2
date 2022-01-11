using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money2
{
    class Money
    {
        private int _grivna;
        private int _kopiyka;
        static double _dollarCost;
        public Money() { }
        public Money(int grivna, int kopiyka)
        {
            Grivna = grivna;
            Kopiyka = kopiyka;
        }
        public int Grivna
        {
            get => _grivna;
            set => _grivna = value != 0 ? value : 0;
        }
        public int Kopiyka
        {
            get => _kopiyka;
            set => _kopiyka = value != 0 ? value : 0;
        }
        static Money()
        {
            _dollarCost = 28.9;
        }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return _grivna;
                    case 1: return _kopiyka;

                    default: throw new Exception("неверный индекс");
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        _grivna = value;
                        break;
                    case 1:
                        _kopiyka = value;
                        break;
                }
            }

        }

        public static Money operator +(Money mon1, Money mon2)
        {
            int b = mon1._kopiyka + mon2._kopiyka;
            int a = mon1._grivna + mon2._grivna;
            if (mon1._kopiyka + mon2._kopiyka >= 100)
            {
                a = mon1._grivna + mon2._grivna + 1;
                b = mon1._kopiyka + mon2._kopiyka - 100;
            }
            return new Money(a, b);
        }
        public static Money operator -(Money mon1, Money mon2)
        {
            return new Money(mon1._grivna - mon2._grivna, mon1._kopiyka - mon2._kopiyka);
        }
        public override string ToString() => $"{Grivna} {Kopiyka} {_dollarCost}";
        public double ToDollar()
        {
            double dollar = (_grivna + _kopiyka / 100) / _dollarCost;
            return dollar;
        }
        public void FromDollar(double dollar)
        {
            double total_ = _grivna * _dollarCost;

        }
    }
}
