using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DemeritPointsCalculatorTests
    {
        private int _result;
        private Action _action;

        [SetUp]
        public void Setup()
        {
            _result = 0;
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            var calculator = new DemeritPointsCalculator();

            // Act
            _action = () => calculator.CalculateDemeritPoints(speed);
           

            // Assert
            _action.ShouldThrow<ArgumentOutOfRangeException>().Message.ShouldBe("Specified argument was out of the range of valid values.");
        }
        
        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var calculator = new DemeritPointsCalculator();

            _result = calculator.CalculateDemeritPoints(speed);
            _action.ShouldThrow<ArgumentOutOfRangeException>().Message.ShouldBe("Specified argument was out of the range of valid values.");

            if (CheckParameter("70,1"))
            {
                _result.ShouldBe(expectedResult);
            }

            if (CheckParameter("75,2"))
            {
                _result.ShouldBe(expectedResult);
            }
        }

        private static bool CheckParameter(string argument)
        {
            var testName = NUnit.Framework.TestContext.CurrentContext.Test.Name;
            var arguments = testName.Substring(testName.IndexOf("(", StringComparison.InvariantCultureIgnoreCase) + 1);
            return arguments.StartsWith(argument);
        }

        private static void ShouldContain(IEnumerable<IStructuralComparable> collection, params object[] param)
        {
            var method = typeof(Tuple).GetMethods().FirstOrDefault(x=> x.GetParameters().Length == param.Length);
            var genericMethod = method?.MakeGenericMethod(param.Select(x=> x?.GetType() ?? typeof(string)).ToArray());
            collection.ShouldContain(genericMethod?.Invoke(null, param));
        }
    }
}
