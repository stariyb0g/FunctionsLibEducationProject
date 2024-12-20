using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    public sealed class Pow(double v, Function arg) : Unares(arg)
    {
        private readonly double a = v;

        public override Function Diff()
        {
            // Using the power rule: (a^x)' = a^x * ln(a)
            return new Multiplication(
                new Pow(this.a, this.arg),
                new Ln(new Constant(this.a)));
        }

        public override string ToString()
        {
            return $"{this.a}^({this.arg})";
        }
    }
}
