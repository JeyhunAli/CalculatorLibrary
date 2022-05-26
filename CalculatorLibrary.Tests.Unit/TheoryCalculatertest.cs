using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit
{
    public class TheoryCalculatertest : IAsyncLifetime
    {
        //sut stands for system under test
        private readonly Calculator _sut = new();
        private readonly ITestOutputHelper _outputHelper;

        //setup goes here 
        public TheoryCalculatertest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _outputHelper.WriteLine("hello inside ctor");
        }

        //parameterization
        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(11, 10, 21)]
        [InlineData(12, 10, 22)]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers2(int a, int b, int expected)
        {
            //Arrange 
            var _sut = new Calculator();
            var result1 = _sut.Add(a, b);
            var result2 = _sut.Add(a, b);
            var result3 = _sut.Add(a, b);

            //Assert
            Assert.Equal(expected, result1);
            Assert.Equal(expected, result2);
            Assert.Equal(expected, result3);
            _outputHelper.WriteLine("hello inside Add method result is " + result1);
            _outputHelper.WriteLine("hello inside Add method result is " + result2);
            _outputHelper.WriteLine("hello inside Add method result is " + result3);



        }

        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(11, 10, 21)]
        [InlineData(12, 10, 22)]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers3(int a, int b, int expected)
        {
            //Arrange 
            var _sut = new Calculator();

            //Act
            var result1 = _sut.Add(a, b);
          
            //Assert
            Assert.Equal(expected, result1);
       
        }


        [Fact]
        public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
        {
            //Arrange 
            var _sut = new Calculator();
            var result1 = _sut.Subtract(10, 2);
            var result2 = _sut.Subtract(20, 2);

            //Assert
            Assert.Equal(8, result1);
            Assert.Equal(18, result2);
            _outputHelper.WriteLine("hello inside Subtract method result is " + result1);
            _outputHelper.WriteLine("hello inside Subtract method result is " + result2);


        }
        //teardown
        public async Task InitializeAsync()
        {
            _outputHelper.WriteLine("hello inside InitializeAsync method  ");
            await Task.Delay(1);
        }

        public async Task DisposeAsync()
        {
            await Task.Delay(1);
            _outputHelper.WriteLine("hello inside DisposeAsync method  ");
        }
    }
}
