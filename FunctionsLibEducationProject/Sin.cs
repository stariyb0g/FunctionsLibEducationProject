using System;

namespace FunctionsLib
{
    public sealed class Sin(Function f) : Unares(f)
    {
        public override string ToString()
        {
            return $"Sin({this.arg})";
        }

        public override Function Diff()
        {
            return new Multiplication(new Cos(this.arg), this.arg.Diff());
        }
    }
}