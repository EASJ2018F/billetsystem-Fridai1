using System;

namespace BilletLib
{
    public class Bil : Vehicle
    {
        private int _pris = 240;
        private int _øresundPris = 410;
        private bool _øresund;
       
        
        public Bil(string Nummerplade, bool Brobizz) : base("Bil", 240, Nummerplade, Brobizz)
        {
            
        }

        public Bil(string Nummerplade, bool Brobizz, bool øresund) : base("Øresund Bil", 410, Nummerplade, Brobizz)
        {
            _øresund = øresund;
        }

        public override double Pris()
        {
            if ( Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                double rabatpris = _pris - _pris * 0.20;
                if (BroBizz)
                {
                    return rabatpris - (rabatpris * 0.05);
                }
            }

            if (BroBizz && !_øresund)
            {
                return _pris - (_pris * 0.05);
            }

            if (_øresund && BroBizz)
            {
                return 161;
            }

            if (_øresund && !BroBizz)
            {
                return _øresundPris;
            }

            return _pris;
        }
    }
        
}