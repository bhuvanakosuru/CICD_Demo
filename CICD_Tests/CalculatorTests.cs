namespace CICD_Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            int result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsIncorrectSum() // Issue: This test is wrong intentionally
        {
            int result = Calculator.Add(-2, -3);
            Assert.Equal(-6, result); // Issue: Should be -5
        }
    }
}