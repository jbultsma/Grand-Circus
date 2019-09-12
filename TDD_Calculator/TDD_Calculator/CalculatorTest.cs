using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace TDD_Calculator
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            int actual = c.Add(1, 2);
            int expected = 4;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAddFivePlusTenShouldBeFifteen()
        {
            Calculator c = new Calculator();
            int actual = c.Add(5,10);
            int expected = 15;

            Assert.Equal(expected, actual);
            
        }

        [Theory]
        [InlineData(1,2)]
        [InlineData(3, 5)]
        [InlineData(500, 350)]
        
        public void TestAddManyValues(int x, int y)
        {
            Calculator c = new Calculator();

            int expected = x + y;
            int actual = c.Add(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
