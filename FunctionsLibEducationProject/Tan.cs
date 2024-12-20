using System;

namespace FunctionsLib
{
    public sealed class Tan(Function a) : Unares(a)
    {
        public override string ToString()
        {
            return $"Tan({this.arg})";
        }

        public override Function Diff()
        {
            // Derivative of tan(x) is 1 / (cos(x))^2
            return new Division(new Constant(1), new Degree(new Cos(this.arg), 2));
        }
    }
}