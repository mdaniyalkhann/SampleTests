using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient.Fakes;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.QualityTools.Testing.Fakes.Shims;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class PhoneDataAccessTest : PhoneDataAccessTestBase
    {
        private const string AreaParameter = "Area";
        private const string ZeroOneTwoOne = "0121";
        private const int Id = 111;

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void GetPhoneNumber_WhenCalled_Verify(bool voidMethod)
        {
            // Arrange, Act
            if (voidMethod)
            {
                Instance.GetPhoneNumber();
            }
            else
            {
                Instance.SavePhoneNumber();
            }

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Instance.Id.ShouldHaveSingleItem(),
                () => Records.Count.ShouldBeGreaterThanOrEqualTo(2));

            if (CheckParameter("True"))
            {
                Records.Count.ShouldBe(15);
                this.ShouldSatisfyAllConditions(
                    () => Records.ShouldContain(Tuple.Create("Area", "0121", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Area", "0122", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Area", "0123", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Area", "0124", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "3455", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "3456", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "3457", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "3458", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "3459", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "34510", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "34511", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Major", "345", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("Minor", "6789", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("ToString", "(012)345-6789--Area: 012Major: 345MinorMinor: 6789", DbType.String, (Object)null)),
                    () => Records.ShouldContain(Tuple.Create("FizzBuzz", "FizzBuzz", DbType.String, (Object)null)),
                    () => ConnectionClosed.ShouldBeTrue(),
                    () => ExecuteScalar.ShouldBeTrue(),
                    () => ConnectionOpen.ShouldBeTrue(),
                    () => Disposed.ShouldBe(1),
                    () => Instance.Id.ShouldContain(1));
            }

            if (CheckParameter("False"))
            {
                this.ShouldSatisfyAllConditions(
                    () => ShouldContain(Records, "Parameter1", "", DbType.String, (string)null),
                    () => ShouldContain(Records, "FizzBuzz", "FizzBuzz", DbType.String, (string)null),
                    () => Instance.Id.ShouldContain(111));
            }
        }


        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void GetPhoneNumber_WhenCalledTest_Verify(bool voidMethod)
        {
            // Arrange, Act
            if (voidMethod)
            {
                Instance.GetPhoneNumber();
            }
            else
            {
                Instance.GetPhoneNumber();
            }

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Records.Count.ShouldBeGreaterThanOrEqualTo(15),
                () => Instance.Id.ShouldHaveSingleItem());
            this.ShouldSatisfyAllConditions(
                () => Records.ShouldContain(Tuple.Create("Area", "0121", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0122", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0123", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0124", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3455", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3456", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3457", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3458", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3459", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "34510", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "34511", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "345", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Minor", "6789", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("ToString", "(012)345-6789--Area: 012Major: 345MinorMinor: 6789", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("FizzBuzz", "FizzBuzz", DbType.String, (Object)null)),
                () => ConnectionClosed.ShouldBeTrue(),
                () => ExecuteScalar.ShouldBeTrue(),
                () => ConnectionOpen.ShouldBeTrue(),
                () => Disposed.ShouldBe(1),
                () => Instance.Id.ShouldContain(1));
        }

        [Test]
        public void GetPhoneNumber_WhenCalledWithVoidMethod_Verify()
        {
            // Arrange, Act
            Instance.GetPhoneNumber();

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Records.Count.ShouldBe(15),
                () => Instance.Id.ShouldHaveSingleItem());
            this.ShouldSatisfyAllConditions(
                () => Records.ShouldContain(Tuple.Create("Area", "0121", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0122", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0123", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Area", "0124", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3455", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3456", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3457", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3458", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "3459", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "34510", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "34511", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Major", "345", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("Minor", "6789", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("ToString", "(012)345-6789--Area: 012Major: 345MinorMinor: 6789", DbType.String, (Object)null)),
                () => Records.ShouldContain(Tuple.Create("FizzBuzz", "FizzBuzz", DbType.String, (Object)null)),
                () => ConnectionClosed.ShouldBeTrue(),
                () => ExecuteScalar.ShouldBeTrue(),
                () => ConnectionOpen.ShouldBeTrue(),
                () => Disposed.ShouldBe(1),
                () => Instance.Id.ShouldContain(1));
        }

        [Test]
        public void GetPhoneNumber_ThrowException_Verify()
        {
            // Arrange
            ShimSqlCommand.Constructor = _ =>
            {
                new ShimSqlCommand(_)
                {
                    InstanceBehavior = ShimBehaviors.Fallthrough,
                    ExecuteScalar = () =>
                    {
                        ExecuteScalar = true;
                        Disposed++;
                        throw new InvalidOperationException("something wrong");
                    }
                };
            };

            // Act
            Action = () => Instance.GetPhoneNumber();

            // Assert
            Action.ShouldThrow<InvalidOperationException>().Message.ShouldBe("something wrong");
            this.ShouldSatisfyAllConditions(
                () => ExecuteScalar.ShouldBeTrue(),
                () => ConnectionOpen.ShouldBeTrue(),
                () => Disposed.ShouldBe(1));
        }

        [Test]
        public void ToString_WhenCalled_Verify()
        {
            // Arrange Act
            Result = new PhoneDataAccess().ToString();

            // Assert
            Result.ShouldBe("TestNinja.Fundamentals.PhoneDataAccess");
        }

        [Test]
        public void SavePhoneNumber_WhenCalled_Verify()
        {
            // Arrange, Act
            Instance.SavePhoneNumber();

            // Assert
            this.ShouldSatisfyAllConditions(
                () => Records.Count.ShouldBe(2),
                () => Instance.Id.ShouldHaveSingleItem());
            this.ShouldSatisfyAllConditions(
                () => ShouldContain(Records, "Parameter1", "", DbType.String, (string)null),
                () => ShouldContain(Records, "FizzBuzz", "FizzBuzz", DbType.String, (string)null),
                () => Instance.Id.ShouldContain(111));
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
