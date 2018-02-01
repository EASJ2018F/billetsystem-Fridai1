using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class VehicleTests
    {
       

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Der er indtastet mere end 7 karaktere i Nummerplade")]
        public void NummerpladeStørrerEndSyvTest()
        {
            Vehicle V = new MC("2321", false);
            
            V.NummerPlade = "1234567890";
            
        }
    }
}