using System;

namespace FunctionsLib
{
    public sealed class Constant(double val) : Function
    {
        public readonly double value = val;

        public double Value => this.value;

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override double Calc(double x)
        {
            return this.value;
        }

        public override Function Diff()
        {
            return new Constant(0);
        }
    }
}