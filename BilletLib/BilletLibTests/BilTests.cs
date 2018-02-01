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
    public class BilTests
    {
        
        

        [TestMethod()]
        public void PrisTest()
        {
            Bil B = new Bil("asd", false);

            Assert.AreEqual(240, B.Pris());
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            Bil B = new Bil("asd", false);

            Assert.AreEqual("Bil", B.Køretøj());
        }

        [TestMethod()]
        public void BroBizzTest()
        {
            Bil B = new Bil("asd",true);

            Assert.AreEqual(240-12, B.Pris());
        }

        [TestMethod()]
        public void WeekendRabat()
        {
            Bil B = new Bil("asd", true);

            B.Dato = new DateTime(2018,2,3);

            Assert.AreEqual(182.4, B.Pris());
        }
    }
}