using System;

namespace BilletLib
{
    public class Vehicle
    {
        private string _nummerPlade;
        private DateTime _dato;
        private string _køreTøj;
        private double _pris;
        private bool _broBizz;
        

        public Vehicle(string Køretøj, double pris, string Nummerplade, bool BroBizz)
        {
            _køreTøj = Køretøj;
            _pris = pris;
            _nummerPlade = Nummerplade;
            _broBizz = BroBizz;
            _dato = new DateTime();
        }

        public string NummerPlade
        {
            get { return _nummerPlade; }
            set
            {
                    _nummerPlade = value;

                if (_nummerPlade.Length > 7)
                { // det er ikke optimalt men det virker, det sletter altså den førhenværende for store nr plade og sætter den til null.
                    _nummerPlade = null;
                    throw new ArgumentException("Der er indtastet mere end 7 karaktere i Nummerplade");
                }
            }
        }

        public DateTime Dato
        {
            get => _dato;
            set => _dato = value;
        } 

        public bool BroBizz => _broBizz;

        public virtual double Pris()
        {
            if (_broBizz)
            {
               return _pris - (_pris * 0.05);
            }
            return _pris;
        }

        public string Køretøj()
        {
            return _køreTøj;
        }

    }
}
