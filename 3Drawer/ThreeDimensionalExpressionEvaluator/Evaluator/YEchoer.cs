using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class YEchoer : EvaluatableThreeDimensionalExpression
    {
        public const string Symbol = "y";
        public double Evaluate(double x, double y)
        {
            return y;
        }
    }
}
