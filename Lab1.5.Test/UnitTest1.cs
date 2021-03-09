using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.lab._1._5;
using System;
namespace Lab1._5.Test
{
    [TestClass]
    public class UnitTest1
    {
    [TestMethod]
        public void TestMethod1()
        {
            RightTriAngle rightTriAngle = new RightTriAngle();
            rightTriAngle.FirstCount = 3;
            rightTriAngle.SecondCount = 4;
            var template = rightTriAngle.Multiplay();
            var hypotenusa = rightTriAngle.Hipotenusa();

            Assert.AreEqual(12, rightTriAngle.Multiplay());
            Assert.AreEqual(5, rightTriAngle.Hipotenusa());
            Assert.AreEqual(6, rightTriAngle.Square());

        }
    }
}
