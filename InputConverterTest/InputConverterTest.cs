using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalc;
using System;

namespace InputConverterTest
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputToDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            
        }
    }
}
