using System;
using NUnit.Framework;

namespace CADIceTray.UnitTests
{
    [TestFixture]
    public class ParameterTest
    {
        [TestCase(ParameterName.Length, 100, 0, 10, 
            "ss", TestName = "Негативный тест проверки Value")]
        public void Value_BadValue_ThrowsException(ParameterName name,
            double wrongValue, double min, double max, string printName)
        {
            //Setup
            var parameter = new Parameter(1, name, min, 
                max, printName);

            //Asset
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    parameter.Value = wrongValue;
                });
        }

        [TestCase(ParameterName.Length, 5, 0, 10,
            "ss", TestName = "Позитивный тест проверки Value")]
        public void Value_CorrectValue_ThrowsException(ParameterName name,
            double correctValue, double min, double max, string printName)
        {
            //Setup
            var parameter = new Parameter(1, name, min,
                max, printName);
            var expectedValue = correctValue;

            //Act
            parameter.Value = correctValue;
            var actualValue = parameter.Value;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}