using System;

namespace FunctionsLib
{
    /// <summary>
    /// Abstract class for all functions with two arguments (binary operations).
    /// </summary>
    public abstract class Binares : Function
    {
        protected readonly Function leftArg;
        protected readonly Function rightArg;
        protected readonly Func<double, double, double> funcPtr;
        protected readonly string operatorSymbol;

        /// <summary>
        /// Constructor for binary operation with two arguments and a function pointer.
        /// </summary>
        /// <param name="l">Function representing the left operand.</param>
        /// <param name="r">Function representing the right operand.</param>
        /// <param name="func">Delegate for the binary operation function.</param>
        /// <param name="symbol">Symbol representing the operation (e.g., "+", "-", "*", "/").</param>
        protected Binares(Function l, Function r, Func<double, double, double> func, string symbol)
        {
            this.leftArg = l;
            this.rightArg = r;
            this.funcPtr = func;
            this.operatorSymbol = symbol;
        }

        /// <summary>
        /// Calculates the value of the binary operation at a given point x.
        /// </summary>
        /// <param name="x">The point at which to calculate the function.</param>
        /// <returns>The result of the binary operation.</returns>
        public override double Calc(double x)
        {
            return this.funcPtr(this.leftArg.Calc(x), this.rightArg.Calc(x));
        }

        /// <summary>
        /// Returns a string representation of the binary operation.
        /// </summary>
        /// <returns>String representation in the form "(leftArg operatorSymbol rightArg)".</returns>
        public override string ToString()
        {
            return $"{this.leftArg}{this.operatorSymbol}{this.rightArg}";
        }
    }
}