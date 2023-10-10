using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class FiboNUnitTests
    {
        private Fibo fibo;

        [SetUp]
        public void SetUp()
        {
            fibo = new();
        }

        [Test]
        public void FiboChecker_Input1_ReturnsFiboSeries()
        {
            //Arrange
            fibo.Range = 1;
            List<int> expectedRange = new() { 0 };

            //Act
            var result = fibo.GetFiboSeries();

            //Assert
            Assert.Multiple(() => 
            {
                Assert.That(result, Is.Not.Empty); //should not be empty
                Assert.That(result, Is.Ordered); //should be ordered
                Assert.That(result, Is.EqualTo(expectedRange)); //should contain number 0
            });
        }

        [Test]
        public void FiboChecker_Input6_ReturnsFiboSeries()
        {
            //Arrange
            fibo.Range = 6;
            var fibonacci = new List<int>{0, 1, 1, 2, 3, 5};

            //Act
            var series = fibo.GetFiboSeries();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.Contains(3, series);
                //Assert.IsTrue(series.Count == 6);
                Assert.That(series.Count, Is.EqualTo(6));
                //Assert.That(series, Is.Not.Contains(4));
                Assert.That(series, Has.No.Contain(4));
                Assert.That(series, Is.EquivalentTo(fibonacci));
            });
        }
    }
}
