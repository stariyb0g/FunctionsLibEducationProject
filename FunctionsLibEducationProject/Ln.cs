using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsLib
{
    public sealed class Ln(Function arg) : Unares(arg)
    {
        public override string ToString()
        {
            return $"Ln({this.arg})";
        }

        public override Function Diff()
        {
            return new Division(this.arg.Diff(), this.arg);
        }
    }
}
