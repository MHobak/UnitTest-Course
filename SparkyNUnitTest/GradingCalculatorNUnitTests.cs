using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        public GradingCalculator grading { get; set; }

        [SetUp]
        public void SetUp()
        {
            grading = new GradingCalculator();
        }

        /// <summary>
        ///Score 95, Attendance 90 -> 'A'
        ///Score 95, Attendance 90 -> 'B'
        ///Score 95, Attendance 90 -> 'C'
        ///Score 95, Attendance 90 -> 'B'
        /// </summary>
        /// <param name="score">Score ponts</param>
        /// <param name="attendancePercentage">Attandance percentage</param>
        /// <param name="result">Final Note</param>
        [Test]
        [TestCase(95, 90, "A")]
        [TestCase(85, 90, "B")]
        [TestCase(65, 90, "C")]
        [TestCase(95, 65, "B")]
        public void Grading_GetPasssingNote(int score, int attendancePercentage, string result) 
        {
            //Act
            grading.Score = score;
            grading.AttendancePercentage = attendancePercentage;

            //Assert
            Assert.That(grading.GetGrade(), Is.EqualTo(result));
        }

        /// <summary>
        ///Score 95, Attendance 55 -> 'F'
        ///Score 65, Attendance 55 -> 'F'
        ///Score 50, Attendance 90 -> 'F'
        /// </summary>
        /// <param name="score">Score ponts</param>
        /// <param name="attendancePercentage">Attandance percentage</param>
        /// <param name="result">Final Note</param>
        [Test]
        [TestCase(95, 55, "F")]
        [TestCase(65, 55, "F")]
        [TestCase(50, 90, "F")]
        public void Grading_GetFailedNote(int score, int attendancePercentage, string result)
        {
            //Act
            grading.Score = score;
            grading.AttendancePercentage = attendancePercentage;

            //Assert
            Assert.That(grading.GetGrade(), Is.EqualTo(result));
        }
    }
}
