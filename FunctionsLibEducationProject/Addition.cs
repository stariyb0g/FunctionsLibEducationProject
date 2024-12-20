using System;

namespace FunctionsLib
{
    /// <summary>
    /// Implements addition operation as Binares Function.
    /// </summary>
    public sealed class Addition(Function l, Function r) : Binares(l, r, (a, b) => a + b, "+")
    {
        public override Function Diff()
        {
            return new Addition(this.leftArg.Diff(), this.rightArg.Diff());
        }

        public override string ToString()
        {
            // Simplify output for cases where one of the arguments is 0
            if (this.leftArg.ToString() == "0")
            {
                return this.rightArg.ToString();
            }

            if (this.rightArg.ToString() == "0")
            {
                return this.leftArg.ToString();
            }

            return $"{this.leftArg}{this.operatorSymbol}{this.rightArg}";
        }
    }
}