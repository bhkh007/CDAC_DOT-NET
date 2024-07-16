namespace MathEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        private MathEngine mathEngine;

        [TestInitialize]
        public void Init()
        {
            mathEngine = new MathEngine();
        }

        [TestMethod]
        public void AdditionTest()
        {
            int a = 10;
            int b = 5;

            int actualResult = mathEngine.Addition(a, b);
            int expectedResult = 15;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            int a = 10;
            int b = 5;

            int actualResult = mathEngine.Subtraction(a, b);

            int expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            int a = 10;
            int b = 5;

            int actualResult = mathEngine.Multiplication(a, b);
            int expectedResult = 50;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DivisionTest()
        {
            int a = 10;
            int b = 5;

            int actualResult = mathEngine.Division(a, b);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
