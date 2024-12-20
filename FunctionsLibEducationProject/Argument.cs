using System;

namespace FunctionsLib
{
    public sealed class Argument : Function
    {
        public override double Calc(double x)
        {
            return x;
        }

        public override Function Diff()
        {
            return new Constant(1);
        }

        public override string ToString()
        {
            return "x";
        }
    }
}