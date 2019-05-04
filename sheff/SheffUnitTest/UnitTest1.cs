using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SheffUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Shifrator_qwer_sygt()
        {
            // arrange
            string a = "qwer";
            string extended = "sygt";
            // act
            var actual = sheff.Program.Shifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void Shifrator_lol_nqn()
        {
            // arrange
            string a = "lol";
            string extended = "nqn";
            // act
            var actual = sheff.Program.Shifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }


        [TestMethod]
        public void Deshifrator_sygt_qwer()
        {
            // arrange
            string a = "sygt";
            string extended = "qwer";
            // act
            var actual = sheff.Program.Deshifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void Deshifrator_asd__qb()
        {
            // arrange
            string a = "asd";
            string extended = "_qb";
            // act
            var actual = sheff.Program.Deshifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void nega_Shifrator_rtyy_sygt()
        {
            // arrange
            string a = "rtyy";
            string extended = "sygt";
            // act
            var actual = sheff.Program.Shifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }

        [TestMethod]
        public void nega_Deshifrator_aqwsqsq_uiuyu()
        {
            // arrange
            string a = "aqwsqsq";
            string extended = "uiuyu";
            // act
            var actual = sheff.Program.Deshifrator(a);
            // assert
            Assert.AreEqual(extended, actual);
        }
    }
}
