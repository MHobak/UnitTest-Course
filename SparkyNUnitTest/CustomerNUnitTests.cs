using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
            //Arrange
            var customer = new Customer();

            //Act
            customer.GreetCombineNames("Ben", "Spark");

            //Assert
            //string methods and helpers to validate strings
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, Ben Spark"));
            Assert.That(customer.GreetMessage, Does.Contain("ben Spark").IgnoreCase); //without IgnoreCase the test will fail
            Assert.That(customer.GreetMessage, Does.StartWith("Hello,"));
            Assert.That(customer.GreetMessage, Does.EndWith("Spark"));
            Assert.That(customer.GreetMessage, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+")); //using regular expression
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            //Arrange
            var customer = new Customer();

            //Act

            //Assert
            Assert.IsNull(customer.GreetMessage);
        }
    }
}
