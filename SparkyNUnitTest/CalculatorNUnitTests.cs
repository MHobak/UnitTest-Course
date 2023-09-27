using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            //Arragne
            Calculator calculator = new();

            //Act
            int result = calculator.AddNumbers(10, 20);

            //Assert
            //Assert.AreEqual(30, result); //OLD
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void IsOddNumber_InputEvenNumber_ReturnFalse()
        {
            //Arrange
            Calculator calculator = new();

            //Act
            bool isOdd = calculator.IsOddNumber(10);

            //Assert
            //Assert.That(isOdd, Is.EqualTo(false));
            Assert.IsFalse(isOdd);
        }

        [Test]
        [TestCase(11)]
        [TestCase(13)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int a)
        {
            //Arrange
            Calculator calculator = new();

            //Act
            bool isOdd = calculator.IsOddNumber(a);

            //Assert
            Assert.That(isOdd, Is.EqualTo(true));
            Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calculator = new();
            return calculator.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] //15.93
        [TestCase(5.49, 10.59)] //16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            //Arragne
            Calculator calculator = new();

            //Act
            double result = calculator.AddNumbersDouble(a, b);

            //Assert
            //Assert.That(result, Is.EqualTo(15.9));
            Assert.AreEqual(15.9, result, .2); //double delta, is a range
        }
    }
}