using System;

namespace BilletLib
{
    public class Bil
    {
        private string _nummerPlade;
        private DateTime _dato;
        private string _køreTøj;
        private int _pris;

        public Bil()
        {
            _køreTøj = "Bil";
            _pris = 240;
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