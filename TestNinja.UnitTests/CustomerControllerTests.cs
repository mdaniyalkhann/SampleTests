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
    public class CustomerControllerTests
    {
        private ActionResult _result;

        [SetUp]
        public void SetUp()
        {
            _result = null;
        }

        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            _result = controller.GetCustomer(0);
            
            // NotFound or one of its derivatives 
//            Assert.That(result, Is.InstanceOf<NotFound>());
            this.ShouldSatisfyAllConditions(
                () => _result.ShouldNotBeNull(),
                () => _result.ShouldBeOfType<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            _result = controller.GetCustomer(1);
            this.ShouldSatisfyAllConditions(
                () => _result.ShouldNotBeNull(),
                () => _result.ShouldBeOfType<Ok>());
        }
    }
}
