using System;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;

namespace TestNinja.Tests
{
    [TestFixture]
    public class SyntaxAnalyzer
    {
        private SyntaxNode _syntax;

        [SetUp]
        public void SetUp()
        {
            _syntax = CSharpSyntaxTree.ParseText(File.ReadAllText(@"D:\Repos\Tools\Testing\TestNinja\TestNinja.UnitTests\PhoneDataAccessTestBase.cs")).GetRoot();
        }

        [Test]
        public void Method_State_ExpectedBehavior()
        {
            var message = string.Empty;
            var node
                = _syntax.DescendantNodes<ClassDeclarationSyntax>().First();

            foreach (var method in node
                .DescendantNodes<MethodDeclarationSyntax>())
            {
                foreach (var obj in method.DescendantNodes<ObjectCreationExpressionSyntax>())
                {
                    if (method.DescendantNodes<MemberAccessExpressionSyntax>().Any(x=> x.ToString() == $"{obj.Type}.AllInstances"))
                    {
                        
                    }
                }
            }
        }
    }
}
