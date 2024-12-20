using System;

namespace FunctionsLib
{
    /// <summary>
    /// Implements multiplication operation as Binares Function.
    /// </summary>
    public sealed class Multiplication(Function l, Function r) : Binares(l, r, (a, b) => a * b, "*")
    {
        public override Function Diff()
        {
            return new Addition(
                new Multiplication(this.leftArg.Diff(), this.rightArg),
                new Multiplication(this.leftArg, this.rightArg.Diff()));
        }

        public override string ToString()
        {
            if (this.leftArg.ToString() == "1")
            {
                return this.rightArg.ToString();
            }

            if (this.rightArg.ToString() == "1")
            {
                return this.leftArg.ToString();
            }

            if (this.leftArg.ToString() == "0" || this.rightArg.ToString() == "0")
            {
                return "0";
            }

            return this.leftArg.ToString() == this.rightArg.ToString() ? $"({this.leftArg})^(2)" : $"{this.leftArg}{this.operatorSymbol}{this.rightArg}";
        }
    }
}