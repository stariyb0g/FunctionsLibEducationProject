using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    /// <summary>
    /// Implements division operation as Binares Function.
    /// </summary>
    public sealed class Division : Binares
    {
        public Division(Function l, Function r)
            : base(l, r, (a, b) => a / b, "/")
        {
        }

        public override Function Diff()
        {
            if (this.rightArg is Constant a)
            {
                return new Multiplication(
                    this.leftArg.Diff(),
                    new Division(
                        new Constant(1), a));
            }

            return new Division(
                new Subtraction(
                    new Multiplication(this.leftArg.Diff(), this.rightArg),
                    new Multiplication(this.leftArg, this.rightArg.Diff())),
                new Multiplication(this.rightArg, this.rightArg));
        }
    }
}