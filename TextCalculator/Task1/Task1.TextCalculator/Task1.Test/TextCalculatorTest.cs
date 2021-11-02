using System;
using Task1.TextCalculator.ClassLibrary;
using Xunit;

namespace Task1.Test
{
    public class TextCalculatorTest
    {
        [Fact]
        public void Add_EmptyString_ResultShouldBeZero()
        {
            var expctedResult = "0";
            var value = "";

            var textCalculator = new TexttCalculator();
            var result = textCalculator.Add(value);

            Assert.Equal(expctedResult, result);
        }

        [Fact]
        public void Add_ValidStringWithOneNumber_ResultShouldBeSameNumber()
        {
            var expctedResult = "5";
            var value = "5";

            var textCalculator = new TexttCalculator();
            var result = textCalculator.Add(value);

            Assert.Equal(expctedResult, result);
        }

        [Fact]
        public void Add_ValidStringWithTwoNumbers_ResultShouldBeSumOfTheTwoInsertedNumbers()
        {
            var expctedResult = "8";
            var value = "5,3";

            var textCalculator = new TexttCalculator();
            var result = textCalculator.Add(value);

            Assert.Equal(expctedResult, result);
        }

        [Fact]
        public void Add_InvalidStringWithNegativeNumber_ThrowsExeption()
        {
            var value = "-2";

            var textCalculator = new TexttCalculator();

            var exeption = Assert.Throws<Exception>(() => textCalculator.Add(value));

            Assert.Equal("Negative not allowed: -2", exeption.Message);
        }

        [Fact]
        public void Add_LeaveEmptyPositionInInputString_ThrowsInvalidOperationException()
        {
            var value = "3,,";

            var textCalculator = new TexttCalculator();

            
           var exeption = Assert.Throws<InvalidOperationException>(() => textCalculator.Add(value));

            Assert.Equal("Missing number on position 2,3", exeption.Message);
        }

        [Fact]
        public void Add_ValidStringWithThreeOrMoreNumbers_ResultShouldBeSumOfTheThreeOrMoreInsertedNumbers()
        {
            var expctedResult = "38";
            var value = "5,3,8,22";

            var textCalculator = new TexttCalculator();
            var result = textCalculator.Add(value);

            Assert.Equal(expctedResult, result);
        }

        [Fact]
        public void Add_InvalidStringNotANumber_ThrowsException()
        {
            var value = "blabla";

            var textCalculator = new TexttCalculator();

            Assert.Throws<Exception>(() => textCalculator.Add(value));
        }

    }
}
