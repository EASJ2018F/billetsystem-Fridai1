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
            Bil B = new Bil();

            Assert.AreEqual(240, B.Pris());
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            Bil B = new Bil();

            Assert.AreEqual("Bil", B.Køretøj());
        }
    }
}