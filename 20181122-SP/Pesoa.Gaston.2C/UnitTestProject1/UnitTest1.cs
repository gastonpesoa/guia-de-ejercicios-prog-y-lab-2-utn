using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20181122_SP;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            FrmPpal frm;
            //act
            frm = new FrmPpal();
            //assert
            Assert.IsNotNull(frm.hilos);
        }
    }
}
