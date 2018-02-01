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
    public class KundeTests
    {
        [TestMethod()]
        public void KundeTest()
        {
            Kunde k = new Kunde();

            Assert.AreEqual(1565.75, k.SumOfTrips());
        }
    }
}