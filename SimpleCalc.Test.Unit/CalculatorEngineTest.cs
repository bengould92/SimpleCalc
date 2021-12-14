using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalc.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _CalculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _CalculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _CalculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }
    }
}
