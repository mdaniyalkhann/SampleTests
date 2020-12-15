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
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;
        private Action _action;
        private Guid _id;

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            // Arrange
            _logger = new ErrorLogger();

            // Act
            _logger.Log("a");
            
            // Assert
            _action.ShouldNotThrow();
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            // Arrange Act
            _action = () => new ErrorLogger();

            // Assert
            _action.ShouldNotThrow();
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            // Arrange Act
            _logger = new ErrorLogger();

            _id = Guid.Empty;
            _logger.ErrorLogged += (sender, args) => { _id = args; };

            _logger.Log("a");
            
            // Assert
            _action.ShouldNotThrow();
            _logger.LastError.ShouldBe("a");
        }
    }
}
