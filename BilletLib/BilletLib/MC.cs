using System;

namespace BilletLib
{
    public class MC : Vehicle
    {
        private bool _øresund;
        private double _øresundPris = 210;
        private double _pris = 125;
        public MC(string Nummerplade, bool Brobizz) : base("MC", 125, Nummerplade, Brobizz)
        {

        }

        public MC(string Nummerplade, bool Brobizz, bool øresund) : base("Øresund MC", 210, Nummerplade, Brobizz)
        {
            _øresund = øresund;
        }

        public override double Pris()
        {
            if (BroBizz && !_øresund)
            {
                return _pris - (_pris * 0.05);
            }

            if (_øresund && BroBizz)
            {
                return 73;
            }

            if (_øresund && !BroBizz)
            {
                return _øresundPris;
            }


            return _pris;
        }
    }
    }

