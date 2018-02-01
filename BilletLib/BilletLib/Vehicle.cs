using System;

namespace BilletLib
{
    public class Vehicle
    {
        private string _nummerPlade;
        private DateTime _dato;
        private string _køreTøj;
        private int _pris;

        public Vehicle(string Køretøj, int pris, string Nummerplade)
        {
            _køreTøj = Køretøj;
            _pris = pris;
            _nummerPlade = Nummerplade;
        }

        public string NummerPlade
        {
            get { return _nummerPlade; }
            set
            {
                if (_nummerPlade.Length > 7)
                {
                    throw new ArgumentException("Der er indtastet mere end 7 karaktere i Nummerplade");
                }
            }
        }
        public DateTime Dato => _dato;

        public int Pris()
        {
            return _pris;
        }

        public string Køretøj()
        {
            return _køreTøj;
        }
    }
}
