using System;
using Xunit;

namespace calculate.Tests
{
    public class CalculateTests
    {
        private readonly Calculate _calculate;

        public CalculateTests()
        {
            _calculate = new Calculate();
        }

        [Fact]
        public void Plus_PositiveNumbers_ReturnsCorrectSum()
        {
            int result = _calculate.Plus(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Plus_NegativeNumbers_ReturnsCorrectSum()
        {
            int result = _calculate.Plus(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Minus_PositiveNumbers_ReturnsCorrectDifference()
        {
            int result = _calculate.Minus(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Minus_NegativeNumbers_ReturnsCorrectDifference()
        {
            int result = _calculate.Minus(-5, -3);
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Multiple_PositiveNumbers_ReturnsCorrectProduct()
        {
            int result = _calculate.Multiple(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiple_NegativeNumbers_ReturnsCorrectProduct()
        {
            int result = _calculate.Multiple(-2, -3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Divide_PositiveNumbers_ReturnsCorrectQuotient()
        {
            int result = _calculate.Divide(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_NegativeNumbers_ReturnsCorrectQuotient()
        {
            int result = _calculate.Divide(-6, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculate.Divide(6, 0));
        }
    }
}
