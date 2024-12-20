using System;

namespace FunctionsLib
{
    /// <summary>
    /// Implements all common operations for unares Functions and operators: F(G(x))
    /// </summary>
    public abstract class Unares : Function
    {
        protected Function arg;
        protected Func<double, double> funcPtr;

        /// <summary>
        /// Constructor with one parameter that realises Dependency Injection of Functions (G(x) encapsulated in F(x)). In Mathematical Analisys it`s called as Superposition of Functions (Fore example: F(G(x)).
        /// </summary>
        /// <param name="f">Function corresponding to argumnet (G(x) Function encapsulated in F(x) Function).</param>
        protected Unares(Function f)
        {
            this.arg = f;
        }

        /// <summary>
        /// Default ToString() implementation for all Unares Function.
        /// </summary>
        /// <returns>string - text representation of Unares Function.</returns>
        public override string ToString()
        {
            if (this.funcPtr == null)
            {
                this.funcPtr = this.Calc;
            }

            return $"{this.funcPtr.Method.Name}({this.arg})";
        }

        /// <summary>
        /// Default Calc implementation for all Unares Function.
        /// </summary>
        /// <param name="x">double x - point in that value will be calculated.</param>
        /// <returns>double - value of F(G(x)) function in point x.</returns>
        public override double Calc(double x)
        {
            return this.funcPtr(this.arg.Calc(x));
        }

        protected Function DiffFg(Function f, Function g)
        {
            return new Multiplication(f.Diff(), g.Diff());
        }
    }
}