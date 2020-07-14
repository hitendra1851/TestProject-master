using System.Collections.Generic;
using rover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rovertest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScanrio_12N_LMLMLMLMM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            position.StartMoving(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestScanrio_33E_MRRMMRMRRM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MMRMMRMRRM";

            position.StartMoving(maxPoints, moves);

            var actualOutput = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}