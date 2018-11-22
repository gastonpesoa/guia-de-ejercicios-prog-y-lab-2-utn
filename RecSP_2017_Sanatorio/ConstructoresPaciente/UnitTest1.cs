using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace ConstructoresPaciente
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructoresPacientes()
        {
            // arrenge
            Paciente p1;
            Paciente p2;
            Paciente p3;

            // act
            p1 = new Paciente("Nombre", "Apellido"); 
            p2 = new Paciente("Nombre", "Apellido", 5);
            p3 = new Paciente("Nombre", "Apellido");

            // assert
            Assert.AreEqual(1, p1.Turno);
            Assert.AreEqual(5, p2.Turno);
            Assert.AreEqual(6, p3.Turno);
        }
    }
}
