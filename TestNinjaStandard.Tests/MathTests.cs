using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MathTests
    {
        private Math _math;
        private int _result;
        private IList<int> _oddNumbers;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
            _oddNumbers = new List<int>();
            _result = 0;
        }

        [TearDown]
        public void TearDown()
        {
            _math = null;
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange, Act
            _result = _math.Add(1, 2);

            // Assert
            _result.ShouldBe(3);
        }

        private static readonly IList<TestCaseData> MaxTestCases = new[]
        {
            new TestCaseData(2,1,2),
            new TestCaseData(1,2,2),
            new TestCaseData(1,1,1),
        };

        [TestCaseSource(nameof(MaxTestCases))]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Arrange, Act
            _result = _math.Max(a, b);

            // Assert
            _result.ShouldBe(expectedResult);
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            // Arrange, Act
            _oddNumbers = _math.GetOddNumbers(5).ToList();

            // Assert
            _oddNumbers.Count.ShouldBeGreaterThanOrEqualTo(3);
            this.ShouldSatisfyAllConditions(
                () => _oddNumbers.ShouldContain(1),
                () => _oddNumbers.ShouldContain(3),
                () => _oddNumbers.ShouldContain(5));
        }
    }
}