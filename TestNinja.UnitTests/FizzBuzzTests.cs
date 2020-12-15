using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using Shouldly;
using TestNinjaOther;

namespace TestNinja.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FizzBuzzTests
    {
        private string _result;

        [Test]
        public void GetOutput_InputIsDivisibleBy3And5_ReturnFizzBuzz()
        {
            _result = FizzBuzz.GetOutput(15);
            _result.ShouldBe("FizzBuzz");
        }
        
        [Test]
        public void GetOutput_InputIsDivisibleBy3Only_ReturnFizz()
        {
            _result = FizzBuzz.GetOutput(3);
            _result.ShouldBe("Fizz");
        }
        
        [Test]
        public void GetOutput_InputIsDivisibleBy5Only_ReturnBuzz()
        {
            _result = FizzBuzz.GetOutput(5);
            _result.ShouldBe("Buzz");
        }
        
        [Test]
        public void GetOutput_InputIsNotDivisibleBy3Or5_ReturnTheSameNumber()
        {
            _result = FizzBuzz.GetOutput(1);
            _result.ShouldBe("1");
        }
    }
}
