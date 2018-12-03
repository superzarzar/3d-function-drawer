using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class XEchoer : EvaluatableThreeDimensionalExpression
    {
        public const string Symbol = "x";
        public double Evaluate(double x, double y)
        {
            return x;
        }
    }
}
