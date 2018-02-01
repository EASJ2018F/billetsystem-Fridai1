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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            MC B = new MC("asd", false);

            Assert.AreEqual(125, B.Pris());
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            MC B = new MC("asd", false);

            Assert.AreEqual("MC", B.Køretøj());
        }

        [TestMethod()]
        public void BroBizzTest()
        {
            MC B = new MC("asd", true);

            Assert.AreEqual(125 - 6.25, B.Pris());
        }
    }
}