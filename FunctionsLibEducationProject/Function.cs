namespace FunctionsLib
{
    /// <summary>
    /// Base class for all mathematical functions. Contains three abstract methods.
    /// </summary>
    public abstract class Function
    {
        /// <summary>
        /// For future implementaitions of function representation in text form.
        /// </summary>
        /// <returns>string text representation of function</returns>
        public abstract override string ToString();

        /// <summary>
        /// For future implementaitions of function that will returns value of some concrete mathematical function in point x.
        /// </summary>
        /// <param name="x">Value from that you need to calculate function value.</param>
        /// <returns>double value obtained by math function.</returns>
        public abstract double Calc(double x);

        /// <summary>
        /// Calculates the value of the derivative as a function for the current function using the derivative table and the standard rules of mathematical analysis for complex functions.
        /// </summary>
        /// <returns>Function - reference to base class.</returns>
        public abstract Function Diff();
    }
}