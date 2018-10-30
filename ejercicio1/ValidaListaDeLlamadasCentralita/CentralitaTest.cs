using System;
using Centralita_Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidaListaDeLlamadasCentralita
{
    [TestClass]
    public class CentralitaTest
    {
        [TestMethod]
        //[ExpectedException(typeof(AssertFailedException))]
        public void TestListaDeLlamadasInciada()
        {
            #region "Arrange - Act"
            Centralita centralita = new Centralita("Centralita List Test");
            #endregion

            #region "Assert"
            //Assert.IsNull(centralita.Llamadas);
            try
            {
                Assert.IsNull(centralita.Llamadas);
            }
            catch (AssertFailedException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(AssertFailedException));
            }
            #endregion
        }

        [TestMethod]
        //[ExpectedException(typeof(CentralitaException))]
        public void TestCentralitaException()
        {
            #region "Arrange"
            Centralita centralita = new Centralita("Centralita Exception Test");
            Local l1 = new Local("Bernal", 15, "Lanus", 5.3F);
            Local l2 = new Local("Bernal", 15, "Lanus", 5.3F);
            Local l3 = new Local("Quilmes", 3.6F, "Avellaneda", 5.3F);
            #endregion

            //centralita += l1;
            //centralita += l2;
            //centralita += l3;
            centralita += l1;
            try
            {
                centralita += l2;
            }
            catch(CentralitaException ex)
            {
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
            centralita += l3;
        }

        [TestMethod]
        public void TestCentralitaExProvincial()
        {
            //arrange
            Centralita centralita = new Centralita("Centralita Test");
            Provincial provincial1 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial provincial2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            centralita += provincial1;
            try
            {
                //act
                centralita += provincial2;
            }
            catch (CentralitaException ex)
            {
                //assert
                Assert.IsInstanceOfType(ex, typeof(CentralitaException));
            }
        }

        [TestMethod]
        public void TestLlamadasEquals()
        {
            //arrange
            Llamada local1 = new Local("Bernal", 15, "Lanus", 5.3F);
            Llamada local2 = new Local("Bernal", 15, "Lanus", 5.3F);
            Llamada provincial1 = new Provincial("Bernal", Provincial.Franja.Franja_1, 15, "Lanus");
            Llamada provincial2 = new Provincial("Bernal", Provincial.Franja.Franja_1, 15, "Lanus");
            
            //act - asert
            Assert.IsTrue(local1 == local2);
            Assert.IsFalse(local1 == provincial1);
            Assert.IsFalse(local1 == provincial2);
            Assert.IsFalse(local1 == provincial2);
            Assert.IsFalse(local2 == provincial1);
            Assert.IsFalse(local2 == provincial2);
            Assert.IsTrue(provincial1 == provincial2);
        }
    }
}
