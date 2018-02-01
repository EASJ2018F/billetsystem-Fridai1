using System;

namespace BilletLib
{
    public class MC
    {

        private string _nummerPlade;
        private DateTime _dato;
        private string _køreTøj;
        private int _pris;

        public MC()
        {
            _køreTøj = "MC";
            _pris = 125;
        }
        public string NummerPlade => _nummerPlade;
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
