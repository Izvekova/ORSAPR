using System;
using NUnit.Framework;

namespace CADIceTray.UnitTests
{
    [TestFixture]
    public class PhoneCaseParametersTest
    {
        [TestCase(ParameterName.CellHeight, 0,
            TestName = "Негативный тест проверки CellHeight в индексаторе")]
        [TestCase(ParameterName.CellLength, 0,
            TestName = "Негативный тест проверки CellLength в " +
                       "индексаторе")]
        [TestCase(ParameterName.CellWidth, 0,
            TestName = "Негативный тест проверки CellWidth в " +
                       "индексаторе")]
        public void Indexer_BadValue_ThrowsException(ParameterName name, 
            double wrongValue)
        {
            //Setup
            var iceTrayParameters = new IceTrayParameters();

            //Asset
            Assert.Throws<ArgumentException>(
                () =>
                {
                    //Act
                    iceTrayParameters[name] = wrongValue;
                });
        }


        [TestCase(ParameterName.CellHeight, 25,
            TestName = "Позитивный тест проверки CellHeight в индексаторе")]
        [TestCase(ParameterName.CellLength, 25,
            TestName = "Позитивный тест проверки CellLength в " +
                       "индексаторе")]
        [TestCase(ParameterName.CellWidth, 25,
            TestName = "Позитивный тест проверки CellWidth в " +
                       "индексаторе")]
        [TestCase(ParameterName.Width, 80,
            TestName = "Позитивный тест проверки Width в " +
                       "индексаторе")]
        public void Indexer_CorrectValue_ReturnsSameValue
            (ParameterName name, double correctValue)
        {
            //Setup
            var iceTrayParameters = new IceTrayParameters();
            var expectedValue = correctValue;

            //Act
            iceTrayParameters[name] = correctValue;
            var actualValue = iceTrayParameters[name];

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
