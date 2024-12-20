using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionsLib
{
    public sealed class Sqrt(Function f) : Unares(f)
    {
        public override string ToString()
        {
            return $"Sqrt({this.arg})";
        }

        public override Function Diff()
        {
            return new Division(this.arg.Diff(), new Multiplication(new Constant(2), new Sqrt(this.arg)));
        }
    }
}
