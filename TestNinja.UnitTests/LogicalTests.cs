using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [ExcludeFromCodeCoverage]
    public class LogicalTests
    {
        private bool _result;

        [Test]
        public void Or_WhenCalled_ReturnTrue()
        {
            // Arrange
            var logical = new Logical();

            // Act
            _result = logical.Or(true, false);

            // Assert
            _result.ShouldBeTrue();
        }

        [Test]
        public void And_WhenCalled_ReturnFalse()
        {
            // Arrange
            var logical = new Logical();

            // Act
            _result = logical.And(true, false);

            // Assert
            _result.ShouldBeFalse();
        }
    }
}
