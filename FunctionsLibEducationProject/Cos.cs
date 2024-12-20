using System;

namespace FunctionsLib
{
    public sealed class Cos(Function f) : Unares(f)
    {
        public override string ToString()
        {
            return $"Cos({this.arg})";
        }

        public override Function Diff()
        {
            return new Multiplication(new Constant(-1), new Multiplication(new Sin(this.arg), this.arg.Diff()));
        }
    }
}