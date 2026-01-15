using UnitTestWithGithubActionDemo.Models;

namespace CalculatorTests.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var result = Calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }
    }
}