using System.Collections.Generic;
using FunctionsLib;
using NUnit.Framework;

namespace FunctionLib.Tests
{
    public class FunctionTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(FunctionsToStringData))]
        public void FunctionToStringCorrect(Function f, string expected)
        {
            Assert.True(expected == f.ToString(), $"Incorect ToString()! Expected: {expected}   Given:{f.ToString()} ");
        }

        [TestCaseSource(nameof(FunctionsDiffToStringData))]
        public void FunctionDiffCorrect(Function f, string expected)
        {
            Function df = f.Diff();
            Assert.True(expected == df.ToString(), $"Incorect ToString()! Expected: {expected}   Given:{df.ToString()} ");
        }

        private static IEnumerable<object[]> FunctionsToStringData()
        {
            yield return new object[]
            {
                new Argument(),
                "x",
            };

            yield return new object[]
            {
                new Constant(1),
                "1",
            };

            yield return new object[]
            {
                new Constant(5),
                "5",
            };

            yield return new object[]
            {
                new Sin(new Argument()),
                "Sin(x)",
            };

            yield return new object[]
            {
                new Cos(new Argument()),
                "Cos(x)",
            };

            yield return new object[]
            {
                new Ln(new Argument()),
                "Ln(x)",
            };

            yield return new object[]
            {
                new Pow(2, new Argument()),
                "2^(x)",
            };

            yield return new object[]
            {
                new Tan(new Argument()),
                "Tan(x)",
            };

            yield return new object[]
            {
                new CTan(new Argument()),
                "CTan(x)",
            };

            yield return new object[]
            {
                new Addition(new Argument(), new Constant(2)),
                "x+2",
            };

            yield return new object[]
            {
                new Subtraction(new Argument(), new Constant(2)),
                "x-2",
            };

            yield return new object[]
            {
                new Multiplication(new Argument(), new Constant(2)),
                "x*2",
            };

            yield return new object[]
            {
                new Division(new Argument(), new Constant(2)),
                "x/2",
            };

            yield return new object[]
            {
                new Exp(new Sin(new Argument())),
                "Exp(Sin(x))",
            };

            yield return new object[]
            {
                new Exp(new Cos(new Argument())),
                "Exp(Cos(x))",
            };

            yield return new object[]
            {
                new Exp(new Exp(new Argument())),
                "Exp(Exp(x))",
            };

            yield return new object[]
            {
                new Exp(new Addition(new Sin(new Argument()), new Constant(3))),
                "Exp(Sin(x)+3)",
            };

            yield return new object[]
            {
                new Degree(new Argument(), 2),
                "(x)^(2)",
            };

            yield return new object[]
            {
                new Degree(new Argument(), 5),
                "(x)^(5)",
            };

            yield return new object[]
            {
                new Degree(new Argument(), 6),
                "(x)^(6)",
            };

            yield return new object[]
            {
                new Degree(new Argument(), 555),
                "(x)^(555)",
            };
        }

        private static IEnumerable<object[]> FunctionsDiffToStringData()
        {
            yield return new object[]
            {
                new Argument(),
                "1",
            };
            yield return new object[]
            {
                new Constant(1),
                "0",
            };
            yield return new object[]
            {
                new Constant(5),
                "0",
            };
            yield return new object[]
            {
                new Sin(new Argument()),
                "Cos(x)",
            };
            yield return new object[]
            {
                new Cos(new Argument()),
                "-1*Sin(x)",
            };
            yield return new object[]
            {
                new Ln(new Argument()),
                "1/x",
            };
            yield return new object[]
            {
                new Pow(2, new Argument()),
                "2^(x)*Ln(2)",
            };
            yield return new object[]
            {
                new Tan(new Argument()),
                "1/(Cos(x))^(2)",
            };
            yield return new object[]
            {
                new CTan(new Argument()),
                "-1/(Sin(x))^(2)",
            };
            yield return new object[]
            {
                new Addition(new Argument(), new Constant(2)),
                "1",
            };
            yield return new object[]
            {
                new Subtraction(new Argument(), new Constant(2)),
                "1",
            };
            yield return new object[]
            {
                new Multiplication(new Argument(), new Constant(2)),
                "2",
            };
            yield return new object[]
            {
                new Division(new Argument(), new Constant(2)),
                "1/2",
            };
            yield return new object[]
            {
                new Division(new Constant(2), new Argument()),
                "-2/(x)^(2)",
            };

            yield return new object[]
            {
                new Exp(new Sin(new Argument())),
                "Exp(Sin(x))*Cos(x)",
            };
            yield return new object[]
            {
                new Exp(new Cos(new Argument())),
                "Exp(Cos(x))*-1*Sin(x)",
            };
            yield return new object[]
            {
                new Exp(new Exp(new Argument())),
                "Exp(Exp(x))*Exp(x)",
            };
            yield return new object[]
            {
                new Exp(new Addition(new Sin(new Argument()), new Constant(3))),
                "Exp(Sin(x)+3)*Cos(x)",
            };
            yield return new object[]
            {
                new Degree(new Argument(), 2),
                "2*(x)^(1)",
            };
            yield return new object[]
            {
                new Degree(new Argument(), 5),
                "5*(x)^(4)",
            };
            yield return new object[]
            {
                new Degree(new Argument(), 6),
                "6*(x)^(5)",
            };
            yield return new object[]
            {
                new Degree(new Argument(), 555),
                "555*(x)^(554)",
            };
        }
    }
}