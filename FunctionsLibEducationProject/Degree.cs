using System;

namespace FunctionsLib
{
    public sealed class Degree(Function f, int degree) : Unares(f)
    {
        private readonly int degree = degree;

        public override string ToString()
        {
            return $"({this.arg})^({this.degree})";
        }

        public override Function Diff()
        {
            if (this.degree == 1)
            {
                return this.arg.Diff();
            }

            var derivedInner = this.arg.Diff();
            var degreeMinusOne = new Degree(this.arg, this.degree - 1);

            if (derivedInner is Constant constant && constant.Value == 0)
            {
                return new Multiplication(new Constant(this.degree), degreeMinusOne);
            }

            return new Multiplication(new Constant(this.degree), new Multiplication(degreeMinusOne, derivedInner));
        }
    }
}