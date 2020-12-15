using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlClient.Fakes;
using System.Diagnostics.CodeAnalysis;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.QualityTools.Testing.Fakes.Shims;
using NUnit.Framework;
using Shouldly;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [ExcludeFromCodeCoverage]
    public class PhoneDataAccessTestBase
    {
        private const int Id = 111;

        protected IDisposable Context { get; set; }

        protected PhoneDataAccess Instance { get; set; }

        protected bool ConnectionClosed { get; set; }

        protected bool ExecuteScalar { get; set; }

        protected bool ConnectionOpen { get; set; }

        protected int Disposed { get; set; }

        protected IList<IStructuralComparable> Records { get; set; }

        protected Action Action { get; set; }

        protected object Result { get; set; }

        public ShimSqlCommand SqlCommandShim { get; set; }

        [SetUp]
        public void SetUp()
        {
            Context = ShimsContext.Create();
            Instance = new PhoneDataAccess();
            ConnectionOpen = false;
            ConnectionClosed = false;
            ExecuteScalar = false;
            Disposed = 0;
            Records = new List<IStructuralComparable>();
            Action = null;

            SetupFakes();
        }

        [TearDown]
        public void TearDown()
        {
            Context?.Dispose();
        }

        public enum StatusX
        {
            A = 0,
            B = 1
        }

        private void SetupFakes()
        {
            ShimSqlConnection.Constructor = connection => { };

            ShimSqlConnection.AllInstances.Open = connection =>
            {
                ConnectionOpen = true;
            };
            ShimSqlConnection.AllInstances.Close = _ => { ConnectionClosed = true; };

            ShimSqlCommand.Constructor = _ =>
            {
                SqlCommandShim = new ShimSqlCommand(_)
                {
                    InstanceBehavior = ShimBehaviors.Fallthrough,
                    ExecuteNonQuery = () =>
                    {
                        _.CommandText.ShouldBe("some_store_procedure");
                        for (var index = 0; index < _.Parameters.Count; index++)
                        {
                            var commandParameter = _.Parameters[index];
                            var tuple = Tuple.Create(commandParameter.ParameterName, commandParameter.Value.ToString(),
                                commandParameter.DbType, (string)null);
                            Records.Add(tuple);
                        }

                        return Id;
                    },
                    DisposeBoolean = __ =>
                    {
                        Disposed++;
                    },
                    ExecuteScalar = () =>
                    {
                        for (var index = 0; index < _.Parameters.Count; index++)
                        {
                            SqlParameter commandParameter = _.Parameters[index];
                            var tuple = Tuple.Create(commandParameter.ParameterName, commandParameter.Value.ToString(), commandParameter.DbType, (object)null);
                            Records.Add(tuple);
                        }

                        ExecuteScalar = true;
                        return 0;
                    }
                };
            };
        }
    }
}