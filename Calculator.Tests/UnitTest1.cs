

namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        Calculator calculator = new Calculator();

        [Fact]
        public void AdditionTest()
        {
            Assert.Equal(15, calculator.Addition(14, 1));
            Assert.Equal(16, calculator.Addition(14, 2));
            Assert.Equal(16, calculator.Addition(13, 3));
            Assert.Equal(16, calculator.Addition(12, 4));
            Assert.Equal(30, calculator.Addition(25, 5));
        }

        [Fact]
        public void AdditionArrayTest()
        {
            int[] test = { 5, 9, 6, 3, 4, 78, 9, 2 };
            Assert.Equal(116, calculator.Addition(test));
        }

        [Fact]
        public void SubtractionTest()
        {
            Assert.Equal(13, calculator.Subtraction(14, 1));
            Assert.Equal(12, calculator.Subtraction(14, 2));
            Assert.Equal(10, calculator.Subtraction(13, 3));
            Assert.Equal(8, calculator.Subtraction(12, 4));
            Assert.Equal(20, calculator.Subtraction(25, 5));
        }

        [Fact]
        public void SubtractionArray()
        {
            int[] test = { 150, 9, 6, 3, 4, 78, 9, 2 };
            Assert.Equal(39, calculator.Subtraction(test));
        }

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(14, calculator.Division(14, 1));
            Assert.Equal(7, calculator.Division(14, 2));
            Assert.Equal(0, calculator.Division(0, 3));
            Assert.Equal(5, calculator.Division(25, 5));
        }

        [Fact]
        public void MultiplicationTest()
        {
            Assert.Equal(14, calculator.Multiplication(14, 1));
            Assert.Equal(28, calculator.Multiplication(14, 2));
            Assert.Equal(39, calculator.Multiplication(13, 3));
            Assert.Equal(48, calculator.Multiplication(12, 4));
            Assert.Equal(0, calculator.Multiplication(25, 0));
        }

        [Fact]
        public void SquareRootnTest()
        {
            Assert.Equal(3, calculator.SquareRoot(14));
            Assert.Equal(5, calculator.SquareRoot(28));
            Assert.Equal(6, calculator.SquareRoot(39));
            Assert.Equal(10, calculator.SquareRoot(120));
            Assert.Equal(50 , calculator.SquareRoot(2500));
        }

        [Fact]
        public void MaxTest()
        {
            Assert.Equal(25, calculator.Max(14, 25));
            Assert.Equal(14, calculator.Max(14, 12));
            Assert.Equal(96, calculator.Max(13, 96));
            Assert.Equal(125, calculator.Max(125, 4));
            Assert.Equal(1300 , calculator.Max(255, 1300));
        }

        [Fact]
        public void MinTest()
        {
            Assert.Equal(14, calculator.Min(14, 25));
            Assert.Equal(12, calculator.Min(28, 12));
            Assert.Equal(13, calculator.Min(13, 96));
            Assert.Equal(4, calculator.Min(125, 4));
            Assert.Equal(9 , calculator.Min(255, 9));
        }

        [Fact]
        public void AbsoluteTest()
        {
            Assert.Equal(5, calculator.Absolute(-5));
            Assert.Equal(28, calculator.Absolute(-28));

        }

        [Fact]
        public void Log2Test()
        {
            Assert.Equal(2, calculator.Log2(5));
            Assert.Equal(7, calculator.Log2(255));
        }

        [Fact]
        public void Log10Test()
        {
            Assert.Equal(0, calculator.Log10(5));
            Assert.Equal(2, calculator.Log10(125));
            Assert.Equal(2, calculator.Log10(255));
        }


        [Fact]
        public void PercentTest()
        {
            Assert.Equal(25, calculator.Max(14, 25));
            Assert.Equal(14, calculator.Max(14, 12));
            Assert.Equal(96, calculator.Max(13, 96));
            Assert.Equal(125, calculator.Max(125, 4));
            Assert.Equal(1300, calculator.Max(255, 1300));
        }

        [Fact]
        public void DivisionByZeroTest()
        {

            Assert.Throws<DivideByZeroException>(() => calculator.Division(16, 0));
            //try
            //{
            //    calculator.Division(16, 0);
            //}
            //catch (DivideByZeroException)
            //{
            //    // Test was a success
            //    return;
            //}

            // Fail the test
            //Assert..Fail("Call to FileExists() did NOT throw an ArgumentNullException.");

        }

    }
}