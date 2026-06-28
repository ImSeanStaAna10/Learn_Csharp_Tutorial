using Debugging__Error_Handling_and_Unit_Test;
using Debugging_Error_Handling_and_Unit_Test;

namespace UnitTest
{
    [TestClass]
    public class Test1
    {
        #region -- BINARY TEST --

        [TestMethod]
        public void BinaryTest()
        {
            // Arrange
            var binary255 = "11111111";
            var binary15 = "00001111";

            // Act
            var binary255Result = Program.GetBitValues(binary255).Sum();
            var binary15Result = Program.GetBitValues(binary15).Sum();

            // Assert
            Assert.AreEqual(255, binary255Result);
            Assert.AreEqual(15, binary15Result);
        }

        #endregion

        #region -- MULTI SCENARIO TEST AND PARAMETERIZED TEST --

        private SampleComputation sample;

        [TestInitialize]
        public void Init()
        {
            sample = new SampleComputation();
        }

        [DataTestMethod]
        [DataRow(1, 1, SampleComputation.SampleOperator.Add, 2)]
        [DataRow(1, 5, SampleComputation.SampleOperator.Add, 6)]
        [DataRow(10, 5, SampleComputation.SampleOperator.Divide, 2)]
        [DataRow(100, 10, SampleComputation.SampleOperator.Divide, 10)]
        public void SampleComputationTest(
            int num1,
            int num2,
            SampleComputation.SampleOperator op,
            int expected)
        {
            // Arrange
            // (Parameters are provided by DataRow)

            // Act
            var actual = sample.Compute(num1, num2, op);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        #endregion

        [TestMethod]
        public void SimpleDataRowTest()
        {
            Assert.AreEqual(2, sample.Compute(1, 1, SampleComputation.SampleOperator.Add));
        }

    }
}