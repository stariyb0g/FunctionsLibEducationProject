using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    /// <summary>
    /// Implements substraction operation as Binares Function.
    /// </summary>
    public sealed class Subtraction(Function l, Function r) : Binares(l, r, (a, b) => a - b, "-")
    {
        public override Function Diff()
        {
            return new Subtraction(this.leftArg.Diff(), this.rightArg.Diff());
        }

        public override string ToString()
        {
            if (this.leftArg.ToString() == "0")
            {
                return $"{this.operatorSymbol}{this.rightArg}";
            }

            if (this.rightArg.ToString() == "0")
            {
                return $"{this.leftArg}";
            }

            return $"{this.leftArg}{this.operatorSymbol}{this.rightArg}";
        }
    }
}