using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [ExcludeFromCodeCoverage]
    public class LogicalTests
    {
        [Test]
        public void Or_WhenCalled_ReturnTrue()
        {
            // Arrange
            var logical = new Logical();

            // Act
            var or = logical.Or(true, false);

            // Assert
            Assert.IsTrue(or);
        }

        [Test]
        public void And_WhenCalled_ReturnFalse()
        {
            // Arrange
            var logical = new Logical();

            // Act
            var and = logical.And(true, false);

            // Assert
            Assert.IsFalse(and);
        }
    }
}
