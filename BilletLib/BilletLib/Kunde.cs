using System.Collections.Generic;

namespace BilletLib
{
    
    public class Kunde
    {
        private List<Vehicle> _ture;

        public Kunde()
        {
            _ture = new List<Vehicle>();

            AddNormalCarTrip();
            AddNormalCarTripWithBroBizz();
            AddNormalMCTrip();
            AddNormalMCTripWithBroBizz();
            AddØresundCarTrip();
            AddØresundCarTripWithBroBizz();
            AddØresundMCTrip();
            AddØresundMCTripWithBroBizz();
        }

        public void AddNormalCarTrip()
        {
            _ture.Add(new Bil("asdh", false));
        }

        public void AddNormalCarTripWithBroBizz()
        {
            _ture.Add(new Bil("asdh", true));
        }

        public void AddØresundCarTrip()
        {
            _ture.Add(new Bil("asdh", false, true));
        }

        public void AddØresundCarTripWithBroBizz()
        {
            _ture.Add(new Bil("asdh", true, true));
        }

        public void AddNormalMCTrip()
        {
            _ture.Add(new MC("asdh", false));
        }

        public void AddNormalMCTripWithBroBizz()
        {
            _ture.Add(new MC("asdh", true));
        }

        public void AddØresundMCTrip()
        {
            _ture.Add(new MC("asdh", false, true));
        }

        public void AddØresundMCTripWithBroBizz()
        {
            _ture.Add(new MC("asdh", true, true));
        }

        public double SumOfTrips()
        {
            double sum = 0;
            foreach (Vehicle v in _ture)
            {
                sum = sum + v.Pris();
            }
            return sum;
        }

    }
}