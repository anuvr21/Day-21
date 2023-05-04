using BasicMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BasicMathTest
{
    [TestClass]
    public class BasicMathTests
    {
        [TestMethod]
        public void Test_AddMethod()
        {
            //Arrange
            BasicMathOp bm = new BasicMathOp();
            //Act
            double res = bm.Add(10, 10);
            //Assert
            Assert.AreEqual(res, 20);
        }
        [TestMethod]
        public void Test_SubstractMethod()
        {
            //Arrange
            BasicMathOp bm = new BasicMathOp();
            //Act
            double res = bm.Substract(10, 10);
            //Assert
            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void Test_DivideMethod()
        {
            //Arrange
            BasicMathOp bm = new BasicMathOp();
            //Act
            double res = bm.divide(10, 5);
            //Assert
            Assert.AreEqual(res, 2);
        }
        [TestMethod]
        public void Test_MultiplyMethod()
        {
            //Arrange
            BasicMathOp bm = new BasicMathOp();
            //Act
            double res = bm.Multiply(10, 10);
            //Assert
            Assert.AreEqual(res, 100);
        }
    }
}
