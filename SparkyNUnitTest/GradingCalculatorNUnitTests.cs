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
        ///Score 95, Attendance 55 -> 'F'
        ///Score 65, Attendance 55 -> 'F'
        ///Score 50, Attendance 90 -> 'F'
        /// </summary>
        /// <param name="score">Score ponts</param>
        /// <param name="attendancePercentage">Attandance percentage</param>
        /// <param name="result">Final Note</param>
        [Test]
        [TestCase(95, 90, ExpectedResult = "A")]
        [TestCase(85, 90, ExpectedResult = "B")]
        [TestCase(65, 90, ExpectedResult = "C")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(95, 55, ExpectedResult = "F")]
        [TestCase(65, 55, ExpectedResult = "F")]
        [TestCase(50, 90, ExpectedResult = "F")]
        public string GradingCalc_AllGradeLogicalScenarios_GradeOutput(int score, int attendancePercentage) 
        {
            //Act
            grading.Score = score;
            grading.AttendancePercentage = attendancePercentage;

            //Assert
            return grading.GetGrade();
        }
    }
}
