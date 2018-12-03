using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class SinEvaluater : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression expression;
        public const string Symbol = "sin";
        public SinEvaluater(EvaluatableThreeDimensionalExpression expression)
        {
            this.expression = expression;
        }
        public double Evaluate(double x, double y)
        {
            return Math.Sin(this.expression.Evaluate(x, y));
        }
    }
}
