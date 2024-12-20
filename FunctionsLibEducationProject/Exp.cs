using System;

namespace FunctionsLib
{
    public sealed class Exp(Function f) : Unares(f)
    {
        public override string ToString()
        {
            return $"Exp({this.arg})";
        }

        public override Function Diff()
        {
            return new Multiplication(new Exp(this.arg), this.arg.Diff());
        }
    }
}