using CalculationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        public UnitTest1(){
            calc=new Calculator();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int num1 = 20;
            int num2 = 20;
            Assert.AreEqual(num1, num2);
        }
        [TestMethod]
        public void AddMethod() {
            double num1 = 5;
            double num2 = 10;
            double result = 15;
            Assert.AreEqual(result, calc.Add(num1,num2));
        }
        [TestMethod]
        public void SubMethod()
        {
            double num1 = 5;
            double num2 = 10;
            double result = -5;
            Assert.AreEqual(result, calc.Sub(num1, num2));
        }
        [TestMethod]
        public void MultiplyMethod()
        {
            double num1 = 5;
            double num2 = 10;
            double result = 50;
            Assert.AreEqual(result, calc.Multi(num1, num2));
        }
        [TestMethod]
        public void DividMethod()
        {
            double num1 = 5;
            double num2 = 10;
            double result = 0.50;
            Assert.AreEqual(result, calc.Divid(num1, num2));
        }
    }
}
