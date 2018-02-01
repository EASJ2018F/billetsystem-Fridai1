using System;

namespace BilletLib
{
    public class Bil : Vehicle
    {
        private int _pris = 240;
       
        
        public Bil(string Nummerplade, bool Brobizz) : base("Bil", 240, Nummerplade, Brobizz)
        {
            
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

            if (BroBizz)
            {
                return _pris - (_pris * 0.05);
            }

            return _pris;
        }
    }
        
}