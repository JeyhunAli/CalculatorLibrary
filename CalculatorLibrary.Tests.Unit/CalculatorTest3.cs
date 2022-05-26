using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;


namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTest3 : IAsyncLifetime
    {
        //sut stands for system under test
        private readonly Calculator _sut = new();
        private readonly ITestOutputHelper _outputHelper;

        //setup goes here 
        public CalculatorTest3(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _outputHelper.WriteLine("hello inside ctor");
        }

        [Fact]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers2()
        {
            //Arrange 
            var _sut = new Calculator();
            var result1 = _sut.Add(10, 10);
            var result2 = _sut.Add(20, 20);

            //Assert
            Assert.Equal(20, result1);
            Assert.Equal(40, result2);
            _outputHelper.WriteLine("hello inside Add method result is " + result1);
            _outputHelper.WriteLine("hello inside Add method result is " + result2);


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
