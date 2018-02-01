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
        public void NummerpladeStørrerEndSyvTest()
        {
            Vehicle V = new MC("asd");
            V.NummerPlade = "1234567890";
            Assert.ThrowsException<ArgumentException>(()=>null, "Der er indtastet mere end 7 karaktere i Nummerplade");
        }
    }
}