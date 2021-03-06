﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void LørdagRabat()
        {
            Bil B = new Bil("asd", true);

            B.Dato = new DateTime(2018,2,3);

            Assert.AreEqual(182.4, B.Pris());
        }

        [TestMethod()]
        public void SøndagRabat()
        {
            Bil B = new Bil("asd", true);

            B.Dato = new DateTime(2018, 2, 4);

            Assert.AreEqual(182.4, B.Pris());
        }
        [TestMethod()]
        public void ØresundPrisMedBroBizz()
        {
            Bil B = new Bil("asd", true, true);

           

            Assert.AreEqual(161, B.Pris());
        }
        [TestMethod()]
        public void ØresundNavn()
        {
            Bil B = new Bil("asd", true, true);



            Assert.AreEqual("Øresund Bil", B.Køretøj());
        }

        [TestMethod()]
        public void ØresundPrisUdenBrobizz()
        {
            Bil B = new Bil("asd", false, true);

            Assert.AreEqual(410, B.Pris());
        }
    }
}
