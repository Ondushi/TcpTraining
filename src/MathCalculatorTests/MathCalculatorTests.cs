using System;
using Xunit;
using MathCalculator;

namespace MathCalculatorTests
{
    public class MathCalculatorTests
    {
        private const int Three = 3;
        private const int Five = 5;
        [Fact]
        public void WhenSumFiveAndThreeThenGotEight()
        {
            //Arrange
            MathCalculator calculator = new MathCalculator();

            //Act
            var result1 = calculator.Sum(Five, Three);
            var result2 = calculator.Sub(Five, Three);

            //Assert
            Assert.Equal(Five + Three, result1);
        }
        [Fact]
        public void WhenSubFiveAndThreeThenGotTwo()
        {
            //Arrange
            MathCalculator calculator = new MathCalculator();

            //Act
            var result2 = calculator.Sub(Five, Three);

            //Assert
            Assert.Equal(Five - Three, result2)
        }
    }
}
