using System;

namespace FunctionsLib
{
    public sealed class CTan(Function a) : Unares(a)
    {
        public override string ToString()
        {
            return $"CTan({arg})";
        }

        public override Function Diff()
        {
            // Derivative of cot(x): -1 / (sin(x))^2
            return new Division(
                new Constant(-1),
                new Degree(new Sin(arg), 2)
            );
        }
    }
}