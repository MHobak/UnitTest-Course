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
        public void GetFibonnacciNumbers_Input1_ValidList()
        {
            fibo.Range = 1; 
            var series = fibo.GetFiboSeries();

            Assert.Multiple(() => 
            {
                Assert.That(series, Is.Not.Empty); //should not be empty
                Assert.Contains(0, series); //should contain number 0
                Assert.That(series, Is.Ordered); //should be ordered
            });
        }

        [Test]
        public void GetFibonnacciNumbers_Input6_ValidList()
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
                Assert.IsTrue(series.Count == 6);
                Assert.That(series, Is.Not.Contains(4));
                Assert.That(series, Is.EquivalentTo(fibonacci));
            });
        }
    }
}
