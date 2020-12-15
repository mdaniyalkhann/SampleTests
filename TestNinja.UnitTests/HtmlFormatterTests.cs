using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HtmlFormatterTests
    {
        private string _result;

        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            _result = formatter.FormatAsBold("abc");
            
            // Assert
            _result.ShouldBe("<strong>abc</strong>");
        }
    }
}
