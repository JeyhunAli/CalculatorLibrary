using System;
using Xunit;
using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTest
    {
        private readonly ITestOutputHelper _outputHelper;
        private readonly Calculator _sut = new();
        //creating long looking id   Guid -> Global unique Identifier
        private readonly Guid _guid = Guid.NewGuid();

        public CalculatorTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
        {
            //Arrange
            var _sut = new Calculator();

            //Act
            var result = _sut.Add(5, 10);
            _outputHelper.WriteLine("result is " + result.ToString());

            //Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void TestGuid()
        {
            _outputHelper.WriteLine(_guid.ToString());
        }

        [Fact]
        public void TestGuid2()
        {
            _outputHelper.WriteLine(_guid.ToString());
        }
    }
}